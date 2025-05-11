using GameLogic;
using System.Linq;
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
                if (item != Fortress.Jobs.First(o => o.Name == "Houses"))
                {
                    OccupComboBox.Items.Add(item);
                }
            }
            OccupComboBox.SelectedItem = servant.Occupation;

        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            Occupation = (Occupation)OccupComboBox.SelectedItem;
            DialogResult = DialogResult.OK;
        }
    }
}
