namespace Administration
{
    public partial class DefaultForm : Form
    {
        public DefaultForm()
        {
            InitializeComponent();
        }

        private void újTermékToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddProductsForm form = new AddProductsForm();
            form.ShowDialog();
        }
    }
}
