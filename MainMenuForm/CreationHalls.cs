using GameLogic;
using System.Windows.Forms;

namespace MainMenuForm
{
    public partial class CreationHalls : Form
    {
        public int ManaCost { get; set; }
        public CreationHalls()
        {
            InitializeComponent();
            RaceComboBox.Items.AddRange(Fortress.Races.ToArray());
            RaceComboBox.SelectedItem = RaceComboBox.Items[0];
            var chosenRace = (Race)RaceComboBox.SelectedItem;
            ManaCost = (chosenRace.Intelligence + chosenRace.Strength + chosenRace.Beauty) * 2;
            LabelCost.Text = $"Mana Cost: {ManaCost}";
        }

        private void RaceComboBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            var chosenRace = (Race)RaceComboBox.SelectedItem;
            DescrTextBox.Text = $"{chosenRace.Desc} \n\nIntelligence: {chosenRace.Intelligence} \nStrength: {chosenRace.Strength} \nMax Hunger: {chosenRace.MaxHunger} \nHunger Rate: {chosenRace.HungerRate}";
            ManaCost = (chosenRace.Intelligence + chosenRace.Strength + chosenRace.Beauty) * 2;
            LabelCost.Text = $"Mana Cost: {ManaCost}";

        }

        private void CreateButton_Click(object sender, System.EventArgs e)
        {
            if (NameTextBox.Text.Length >= 4 && RaceComboBox.SelectedItem != null)
            {
                if (Fortress.Houses > Fortress.Servants.Count)
                {
                    if (ManaCost < Fortress.Mana)
                    {
                        Fortress.Servants.Add(new Servant(NameTextBox.Text, (Race)RaceComboBox.SelectedItem));
                        Fortress.Mana -= ManaCost;
                        DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show($"You don't have enough mana to create a servant!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show($"Build more houses for your servants to live!", "Not enough houses!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            if (NameTextBox.Text == null || NameTextBox.Text.Length < 4 || RaceComboBox.SelectedItem == null)
            {
                MessageBox.Show($"Fill up all the fields before creating new servant!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
