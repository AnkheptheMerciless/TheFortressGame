using GameLogic;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MainMenuForm
{
    public partial class ServantsShowForm : Form
    {
        public ServantsShowForm()
        {
            InitializeComponent();
        }
        public ServantsShowForm(List<Servant> Servants) : this()
        {
            ServantsGridView.DataSource = Servants;
            ServantsGridView.Columns["ProccesingProduct"].Visible = false;
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            var chosen = ServantsGridView.SelectedRows[0].Cells[0];
            var servant = Fortress.Servants.Find(s => s.Name == (string)chosen.Value);
            ServantChangeForm form = new ServantChangeForm(servant);
            form.ShowDialog();
            if (form.DialogResult == DialogResult.OK)
            {
                servant.Occupation = form.Occupation;
            }
            this.Update();
        }
    }
}
