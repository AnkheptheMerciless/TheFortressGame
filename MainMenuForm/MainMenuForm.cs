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
    public partial class MainMenuForm: Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void MMNewGameButton_Click(object sender, EventArgs e)
        {
            FortressNameInputForm form = new FortressNameInputForm();
            form.ShowDialog();
            if(form.DialogResult == DialogResult.OK)
            {
                FortressMainDisplayForm fortressDisplayForm = new FortressMainDisplayForm(form.FortressName);
                fortressDisplayForm.ShowDialog();
            }
        }
    }
}
