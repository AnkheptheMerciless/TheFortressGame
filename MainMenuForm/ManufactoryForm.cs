using GameLogic;
using System.Linq;
using System.Windows.Forms;

namespace MainMenuForm
{
    public partial class ManufactoryForm : Form
    {
        public Occupation Chosen { get; set; }
        public ManufactoryForm()
        {
            InitializeComponent();
            StructsComboBox.Items.AddRange(Fortress.Jobs.ToArray());
            StructsComboBox.SelectedItem = StructsComboBox.Items[0];
            ChangeFields();
        }

        private void StructsComboBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            Chosen = (Occupation)StructsComboBox.SelectedItem;
            ChangeFields();
        }

        private void ChangeFields()
        {
            GoldTextBox.Text = $"{Chosen.UpgradeCost}";
            WoodTextBox.Text = $"{Chosen.UpgradeCost / 50}";
            StoneTextBox.Text = $"{Chosen.UpgradeCost / 50}";
            DaysToBuildLabel.Text = $"Days to build: {Chosen.UpgradeCost / 50}";
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            if (Fortress.CompletedProductsStorage.Any(p => p.Name == "Wood") && Fortress.CompletedProductsStorage.Any(p => p.Name == "Stone"))
            {
                if (Fortress.Treasury >= Chosen.UpgradeCost && Fortress.CompletedProductsStorage.First(p => p.Name == "Wood").Count >= Chosen.UpgradeCost / 50 && Fortress.CompletedProductsStorage.First(p => p.Name == "Stone").Count >= Chosen.UpgradeCost / 50)
                {
                    Fortress.CurrentBuilding.DaysTillEnd = Chosen.UpgradeCost / 50;
                    Fortress.CurrentBuilding.BelongsToOccup = Chosen;

                    var wood = Fortress.CompletedProductsStorage.First(p => p.Name == "Wood");
                    wood.Count -= Chosen.UpgradeCost / 50;
                    if (wood.Count == 0)
                    {
                        Fortress.CompletedProductsStorage.Remove(wood);
                    }

                    var stone = Fortress.CompletedProductsStorage.First(p => p.Name == "Stone");
                    stone.Count -= Chosen.UpgradeCost / 50;
                    if (stone.Count == 0)
                    {
                        Fortress.CompletedProductsStorage.Remove(stone);
                    }

                    Fortress.Treasury -= Chosen.UpgradeCost;
                    DialogResult = DialogResult.OK;
                }
            }
            else
            {
                MessageBox.Show($"You don't have enough resources to build it!", "Not enough resources", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
