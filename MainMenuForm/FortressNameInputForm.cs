using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GameLogic;

namespace MainMenuForm
{
    public partial class FortressNameInputForm: Form
    {
        public string FortressName { get; set; }
        public FortressNameInputForm()
        {
            InitializeComponent();
        }

        private void DoneButton_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "")
            {
                FortressName = textBox1.Text;
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("You should come up with a name for your Fortress, m'lord!", "Fortress Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
