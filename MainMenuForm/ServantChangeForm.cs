using GameLogic;
using System.Windows.Forms;

namespace MainMenuForm
{
    public partial class ServantChangeForm : Form
    {
        public Occupation Occupation { get; set; }
        public ServantChangeForm()
        {
            InitializeComponent();
        }

        public ServantChangeForm(Servant servant) : this()
        {
            ServNameBox.Text = servant.Name;
            foreach (var item in Fortress.Jobs)
            {
                OccupComboBox.Items.Add(item);
            }

        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            Occupation = (Occupation)OccupComboBox.SelectedItem;
            DialogResult = DialogResult.OK;
        }
    }
}
