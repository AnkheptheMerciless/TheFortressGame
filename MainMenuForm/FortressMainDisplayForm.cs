using GameLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainMenuForm
{
    public partial class FortressMainDisplayForm : Form
    {
        Random rnd = new Random();
        StarterOne Starter;
        public int DayCountShow { get; set; } = 0;
        Queue<Servant> servantsQueue = new Queue<Servant>();

        public FortressMainDisplayForm()
        {
            InitializeComponent();
        }
        public FortressMainDisplayForm(string name) : this()
        {
            Fortress.FortressName = name;
            FortressNameLabel.Text = name;
            Starter = new StarterOne();
            Starter.CreateRaces();
            Starter.CreateJobs();
            Starter.CreateProductTypes();
            Starter.StartingResources();

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
            CurrentDayLabel.Text = $"Current Day: {Fortress.CurrentDay}";
            ServantDay();
            DayIncome();
            PricesUp();
            NotificationsUpdate();
            Fortress.PortalUsed = false;
        }

        public void DayIncome()
        {
            Fortress.Treasury += 10;
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
                if (chanceOfChanging == 1)
                {
                    item.Price += 1;
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
    }
}
