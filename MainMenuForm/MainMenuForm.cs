using GameLogic;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace MainMenuForm
{
    public partial class MainMenuForm : Form
    {
        public bool GameSaved { get; set; } = false;
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void MMNewGameButton_Click(object sender, EventArgs e)
        {
            FortressNameInputForm form = new FortressNameInputForm();
            form.ShowDialog();
            if (form.DialogResult == DialogResult.OK)
            {
                Visible = false;
                StartNewGame();
                FortressMainDisplayForm fortressDisplayForm = new FortressMainDisplayForm(form.FortressName, this, true);
                fortressDisplayForm.ShowDialog();
            }
        }

        private void MMLoadGameButton_Click(object sender, EventArgs e)
        {
            var formatter = new BinaryFormatter();

            using (var file = new FileStream("FortressSavedGame.bin", FileMode.OpenOrCreate))
            {
                if (file.Length > 0)
                {
                    GameSaved = true;
                    Fortress.FortressName = (string)formatter.Deserialize(file);
                    Fortress.Treasury = (decimal)formatter.Deserialize(file);
                    Fortress.CurrentDay = (int)formatter.Deserialize(file);
                    Fortress.Mana = (int)formatter.Deserialize(file);
                    Fortress.Houses = (int)formatter.Deserialize(file);
                    Fortress.PortalUsed = (bool)formatter.Deserialize(file);
                    Fortress.Rested = (bool)formatter.Deserialize(file);

                    Fortress.CurrentBuilding = (BuildingStructure)formatter.Deserialize(file);
                    Fortress.CompletedProductsStorage = formatter.Deserialize(file) as List<GeneratedProduct>;
                    Fortress.ProductTypes = formatter.Deserialize(file) as List<GeneratedProduct>;
                    Fortress.SoldItems = formatter.Deserialize(file) as List<GeneratedProduct>;
                    Fortress.Servants = formatter.Deserialize(file) as List<Servant>;
                    Fortress.Races = formatter.Deserialize(file) as List<Race>;
                    Fortress.Jobs = formatter.Deserialize(file) as List<Occupation>;
                    Fortress.Notifications = formatter.Deserialize(file) as List<Notification>;
                }
            }
            ;

            if (GameSaved == true)
            {
                Visible = false;
                FortressMainDisplayForm fortressDisplayForm = new FortressMainDisplayForm(Fortress.FortressName, this, false);
                fortressDisplayForm.ShowDialog();
            }
            else
            {
                MessageBox.Show($"There is no saved game yet.", "Load Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void StartNewGame()
        {
            Fortress.Treasury = 0;
            Fortress.CurrentDay = 1;
            Fortress.Mana = 0;
            Fortress.Houses = 5;
            Fortress.PortalUsed = false;
            Fortress.Rested = false;

            Fortress.CurrentBuilding = new BuildingStructure();
            Fortress.CompletedProductsStorage.Clear();
            Fortress.ProductTypes.Clear();
            Fortress.SoldItems.Clear();
            Fortress.Servants.Clear();
            Fortress.Races.Clear();
            Fortress.Jobs.Clear();
            Fortress.Notifications.Clear();

        }

        private void MMExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
