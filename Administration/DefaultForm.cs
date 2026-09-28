using Common.Database;
using Common.Model;
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
        if (form.ShowDialog() == DialogResult.OK)
        {
            ListProducts(sender, e);
        }
    }

    private void ListProducts(object sender, EventArgs e)
    {
        var db = _serviceProvider.GetRequiredService<IDatabase>();
        var products = db.GetAllProducts();
        dataGridView.DataSource = null;
        dataGridView.DataSource = products;
        dataGridView.Columns["Id"].Visible = false;
        dataGridView.Columns["Image"].Visible = false;
    }

    private void ModifyOrder(object sender, DataGridViewCellMouseEventArgs e)
    {
        // Event: CellMouseClick

        if (dataGridView.CurrentRow?.DataBoundItem is not Product product)
        {
            return;
        }

        var form = _serviceProvider.GetRequiredService<AddProductsForm>();
        form.Product = product;
        if (form.ShowDialog() == DialogResult.OK)
        {
            ListProducts(sender, e);
        }

        //if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
        //{
        //    var product = dataGridView.Rows[e.RowIndex].DataBoundItem as Common.Model.Product;
        //    if (product is not null)
        //    {
        //        using var form = _serviceProvider.GetRequiredService<ModifyProductsForm>();
        //        form.SetProduct(product);
        //        if (form.ShowDialog() == DialogResult.OK)
        //        {
        //            ListProducts(sender, e);
        //        }
        //    }
        //}
    }
}