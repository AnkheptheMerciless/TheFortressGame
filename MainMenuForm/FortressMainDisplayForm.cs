using GameLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainMenuForm
{
    public partial class FortressMainDisplayForm: Form
    {
        Fortress Fortress;
        public int DaySpeed { get; set; } = 1;
        public int CurrentDay { get; set; } = 0;
        public Task TimerTask { get; set; }

        public delegate void ChangeTimeDelegate();

        public event ChangeTimeDelegate ChangeTimeEvent;
        public FortressMainDisplayForm()
        {
            InitializeComponent();
        }
        public FortressMainDisplayForm(string name) : this()
        {
            Fortress = new Fortress
            {
                FortressName = name
            };
            FortressNameLabel.Text = name;
            ChangeTimeEvent += ChangeDayTime;
            StartTimerTask();

        }

        public void ChangeDayTime()
        {
            if (DayProgressBar.Value == 24)
            {
                DayProgressBar.Value = 0;
                CurrentDay += 1;
                CurrentDayLabel.Text = $"Current Day: {CurrentDay}";
            }
            DayProgressBar.Value += DaySpeed;
        }




        private void DSpeedDownButton_Click(object sender, EventArgs e)
        {
            if (DaySpeed !=0)
            {
                DaySpeed -= 1;
            }
        }

        private void DSpeedUpButton_Click(object sender, EventArgs e)
        {
            if (DaySpeed != 3)
            {
                DaySpeed += 1;
            }
        }

        private void DaySpeedStop_Click(object sender, EventArgs e)
        {
            DaySpeed = 0;
        }

        private void StartTimerTask()
        {
            TimerTask = new Task(() =>
            {
                while (true)
                {
                    ChangeTimeEvent?.Invoke();
                    Thread.Sleep(1000);
                }
            });
            TimerTask.Start();
        }
    }
}
