using GameLogic;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainMenuForm
{
    public partial class FortressMainDisplayForm : Form
    {
        Random rnd = new Random();
        public int DayCountShow { get; set; } = 0;
        public Form PreviousForm { get; set; }
        StarterOne Starter;
        Queue<Servant> servantsQueue = new Queue<Servant>();

        public FortressMainDisplayForm()
        {
            InitializeComponent();
        }
        public FortressMainDisplayForm(string name, Form mainform, bool isNewGame) : this()
        {
            Fortress.FortressName = name;
            FortressNameLabel.Text = name;
            PreviousForm = mainform;
            Starter = new StarterOne();
            if (isNewGame == true)
            {
                Starter.CreateRaces();
                Starter.CreateJobs();
                Starter.CreateProductTypes();
                Starter.StartingResources();
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            DaySkip();
            EndDayButton.Enabled = false;
            Task.Run(() =>
            {
                Thread.Sleep(1000);
                Invoke((Action)delegate
                {
                    EnableButton();
                });
            });

        }
        private void EnableButton()
        {
            EndDayButton.Enabled = true;
        }

        private void StoragePicture_Click(object sender, EventArgs e)
        {
            StorageViewForm SVForm = new StorageViewForm(Fortress.CompletedProductsStorage);
            SVForm.Show();
        }

        private void DownTownPicture_Click(object sender, EventArgs e)
        {
            ServantsShowForm SVForm = new ServantsShowForm(Fortress.Servants);
            SVForm.Show();
        }
        public void DaySkip()
        {
            Fortress.CurrentDay += 1;
            ServantDay();
            TreasuryViewUpdate();
            PricesUp();
            BuildingProc();
            NotificationsUpdate();
            CurrentDayLabel.Text = $"Current Day: {Fortress.CurrentDay}";
            ServantsCountLabel.Text = $"Servants: {Fortress.Servants.Count}";
            HousesLabel.Text = $"Houses: {Fortress.Servants.Count}/{Fortress.Houses}";
            Fortress.PortalUsed = false;
            Fortress.Rested = false;
        }

        public void TreasuryViewUpdate()
        {
            MoneyLabel.Text = $"Treasury: {Fortress.Treasury}";
        }

        public void NotificationsUpdate()
        {
            NotificationsBox.Items.Clear();
            foreach (var notification in Fortress.Notifications)
            {
                NotificationsBox.Items.Add(notification);
            }
            Fortress.Notifications.Clear();
        }

        public void PricesUp()
        {
            int chanceOfChanging = 0;
            foreach (var item in Fortress.ProductTypes)
            {
                chanceOfChanging = rnd.Next(1, 10);
                if (chanceOfChanging < 3)
                {
                    item.Price += 1;
                    Notification pricesUp = new Notification()
                    {
                        Name = $"{item.Name} prices up!(Price: {item.Price})"
                    };
                    Fortress.Notifications.Add(pricesUp);
                }
                if (chanceOfChanging == 3)
                {
                    if (item.Price > 1)
                    {
                        item.Price -= 1;
                        Notification pricesDown = new Notification()
                        {
                            Name = $"{item.Name} prices lowered!(Price: {item.Price})"
                        };
                        Fortress.Notifications.Add(pricesDown);
                    }
                }
                if (Fortress.CompletedProductsStorage.Any(p => p.Name == item.Name))
                {
                    Fortress.CompletedProductsStorage.First(p => p.Name == item.Name).Price = item.Price;
                }
            }
        }


        public void ServantDay()
        {
            if (Fortress.Servants != null)
            {
                foreach (var servant in Fortress.Servants)
                {
                    servantsQueue.Enqueue(servant);
                }
                for (int i = 0; i <= servantsQueue.Count; i++)
                {
                    Servant servant = servantsQueue.Dequeue();
                    servant.ServantIsEating();
                    servant.ServantDoJob();
                    servant.IsRestingToday = false;
                }
            }
        }

        private void BuildingProc()
        {
            if (Fortress.CurrentBuilding.DaysTillEnd != 0)
            {
                if (Fortress.CurrentBuilding.DaysTillEnd > 0)
                {
                    Fortress.CurrentBuilding.DaysTillEnd -= 1;

                }
                if (Fortress.CurrentBuilding.DaysTillEnd == 0)
                {
                    if (Fortress.CurrentBuilding.BelongsToOccup != Fortress.Jobs.First(o => o.Name == "Houses"))
                    {
                        Fortress.CurrentBuilding.BelongsToOccup.Level += 1;
                    }
                    else
                    {
                        Fortress.CurrentBuilding.BelongsToOccup.Level += 1;
                        Fortress.Houses = Fortress.CurrentBuilding.BelongsToOccup.Level * 5;
                    }
                    Notification buildingCompleted = new Notification()
                    {
                        Name = $"{Fortress.CurrentBuilding.BelongsToOccup} completed!"
                    };
                    Fortress.Notifications.Add(buildingCompleted);
                }
            }
        }

        private void TradingPortalPicture_Click(object sender, EventArgs e)
        {
            if (Fortress.PortalUsed == false)
            {
                TradeForm form = new TradeForm();
                form.ShowDialog();
                if (form.DialogResult == DialogResult.OK)
                {
                    MoneyLabel.Text = $"Treasury: {Fortress.Treasury}";
                    Fortress.PortalUsed = true;
                }
            }
            else
            {
                MessageBox.Show($"The Portal will not work today anymore. You should think twice about what do you sell and when. Or you can spend your power to activate the Portal again...", "The Portal is inactive", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void HallsOfCreationPictureBox_Click(object sender, EventArgs e)
        {
            CreationHalls form = new CreationHalls();
            form.ShowDialog();
            ServantsCountLabel.Text = $"Servants: {Fortress.Servants.Count}";

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (Fortress.Rested == false)
            {
                OverlordChambers form = new OverlordChambers();
                form.ShowDialog();
                if (form.DialogResult == DialogResult.OK)
                {
                    ManaLabel.Text = $"Mana: {Fortress.Mana}";
                    Fortress.Rested = true;
                }
            }
            else
            {
                MessageBox.Show($"M'lord, I understand that you like to spend time with us... But... You have duties! There is no time for resting today!", "No time to rest!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void ManufPicture_Click(object sender, EventArgs e)
        {
            if (Fortress.CurrentBuilding.DaysTillEnd == 0)
            {
                ManufactoryForm form = new ManufactoryForm();
                form.ShowDialog();
                if (form.DialogResult == DialogResult.OK)
                {
                    MessageBox.Show($"You've started to build/upgrade {Fortress.CurrentBuilding.BelongsToOccup}. Days remained {Fortress.CurrentBuilding.DaysTillEnd}", "Building started!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                TreasuryViewUpdate();
            }
            else
            {
                MessageBox.Show($"Manufactory is already building structure. Days until end: {Fortress.CurrentBuilding.DaysTillEnd}", "Manufactory is busy already", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveMenuStrip_Click(object sender, EventArgs e)
        {
            BinaryFormatter formatter = new BinaryFormatter();

            using (var file = new FileStream("FortressSavedGame.bin", FileMode.Create))
            {
                formatter.Serialize(file, Fortress.FortressName);
                formatter.Serialize(file, Fortress.Treasury);
                formatter.Serialize(file, Fortress.CurrentDay);
                formatter.Serialize(file, Fortress.Mana);
                formatter.Serialize(file, Fortress.Houses);
                formatter.Serialize(file, Fortress.PortalUsed);
                formatter.Serialize(file, Fortress.Rested);

                formatter.Serialize(file, Fortress.CurrentBuilding);
                formatter.Serialize(file, Fortress.CompletedProductsStorage);
                formatter.Serialize(file, Fortress.ProductTypes);
                formatter.Serialize(file, Fortress.SoldItems);
                formatter.Serialize(file, Fortress.Servants);
                formatter.Serialize(file, Fortress.Races);
                formatter.Serialize(file, Fortress.Jobs);
                formatter.Serialize(file, Fortress.Notifications);
            }
            MessageBox.Show($"The game was successfully saved.", "Game Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void FortressMainDisplayForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            PreviousForm.Visible = true;
        }
    }
}
