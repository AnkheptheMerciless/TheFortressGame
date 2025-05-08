using System;
using System.Windows.Forms;

namespace MainMenuForm
{
    public partial class MainMenuForm : Form
    {
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
                FortressMainDisplayForm fortressDisplayForm = new FortressMainDisplayForm(form.FortressName);
                fortressDisplayForm.ShowDialog();
            }
        }
    }
}
