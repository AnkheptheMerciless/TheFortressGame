using GameLogic;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MainMenuForm
{
    public partial class StorageViewForm : Form
    {
        public StorageViewForm()
        {
            InitializeComponent();
        }

        public StorageViewForm(List<GeneratedProduct> Products) : this()
        {
            StorageGridView.DataSource = Products;
            StorageGridView.Columns["ObtainDifficulty"].Visible = false;
            StorageGridView.Columns["BelongsToOccup"].Visible = false;
            StorageGridView.Columns["AmountOfWorkNeed"].Visible = false;
            StorageGridView.Columns["CurrentWorkProgress"].Visible = false;
        }
    }
}
