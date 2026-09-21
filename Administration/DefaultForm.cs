using Common.Database;
using Microsoft.Extensions.DependencyInjection;

namespace Administration;

public partial class DefaultForm : Form
{
    private readonly IServiceProvider _serviceProvider;

    public DefaultForm(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
        InitializeComponent();
    }

    private void újTermékToolStripMenuItem_Click(object sender, EventArgs e)
    {
        using var form = _serviceProvider.GetRequiredService<AddProductsForm>();
        form.ShowDialog();
    }

    // Listázás később
    //private void listTermékToolStripMenuItem_Click(object sender, EventArgs e)
    //{
    //    var db = _serviceProvider.GetRequiredService<IDatabase>();
    //    var products = db.Get();
    //    dataGridView.DataSource = null;
    //    dataGridView.DataSource = products;
    //}
}