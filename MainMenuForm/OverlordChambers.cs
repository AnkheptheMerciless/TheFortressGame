using GameLogic;
using System;
using System.Windows.Forms;

namespace MainMenuForm
{
    public partial class OverlordChambers : Form
    {
        public int ManaGain { get; set; }
        public Servant Servant { get; set; }
        public OverlordChambers()
        {
            InitializeComponent();

            ServantComboBox.Items.AddRange(Fortress.Servants.ToArray());
            ServantComboBox.SelectedItem = ServantComboBox.Items[0];
        }

        private void ServantComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Servant = (Servant)ServantComboBox.SelectedItem;
            ManaGain = Servant.Race.Beauty;

            HungerLabel.Text = $"Current hunger: {Servant.Hunger}";
            HungerRateLabel.Text = $"Servant will lose {Servant.Race.HungerRate} point of hunger.";
            ManaLabel.Text = $"Mana gain {ManaGain}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Servant.Hunger - Servant.Race.HungerRate > 0)
            {
                Fortress.Mana += ManaGain;
                Servant.IsRestingToday = true;
                Servant.Hunger -= Servant.Race.HungerRate;

                if (Servant.Race.Name == "Fianku")
                {
                    MessageBox.Show($"You're spending a few soft and tender hours with graceful creature. Pale skin, soft, a little bit cold lips, glimmering scales... And this pair of begging eyes... \n\nYou feel refreshed while your servant is lying next to you absolutely exhausted.", "A Snake Under the Blanket", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                if (Servant.Race.Name == "Gurdir")
                {
                    MessageBox.Show($"Hours passed almost unnoticed filled with harsh yet passionate movements. Sometimes it was hard even to figure out who exactly was setting the pace. \n\nYou feel... refreshed? But what with these eyes next to you? They are waiting for more?", "The Strength and Passion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                if (Servant.Race.Name == "Lakeya")
                {
                    MessageBox.Show($"Servant is looking at you feeling itself like a small insect. What are you going to do with her? What awaits her? Your servant doesn't know... but the pleasure will be immense. \n\nYou feel refreshed. The same for this little figure sleeping next to you.", "This Helpless Creature", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }

                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show($"The servant is too hunger to... rest with you.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
