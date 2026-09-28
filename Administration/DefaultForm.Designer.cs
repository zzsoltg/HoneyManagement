namespace Administration
{
    partial class DefaultForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            productsToolStripMenuItem = new ToolStripMenuItem();
            newProductToolStripMenuItem = new ToolStripMenuItem();
            listProductsToolStripMenuItem = new ToolStripMenuItem();
            ordersToolStripMenuItem = new ToolStripMenuItem();
            dataGridView = new DataGridView();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Items.AddRange(new ToolStripItem[] { productsToolStripMenuItem, ordersToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(11, 4, 0, 4);
            menuStrip1.Size = new Size(1361, 44);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // productsToolStripMenuItem
            // 
            productsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newProductToolStripMenuItem, listProductsToolStripMenuItem });
            productsToolStripMenuItem.Name = "productsToolStripMenuItem";
            productsToolStripMenuItem.Size = new Size(126, 36);
            productsToolStripMenuItem.Text = "Products";
            // 
            // newProductToolStripMenuItem
            // 
            newProductToolStripMenuItem.Name = "newProductToolStripMenuItem";
            newProductToolStripMenuItem.Size = new Size(285, 44);
            newProductToolStripMenuItem.Text = "New product";
            newProductToolStripMenuItem.Click += újTermékToolStripMenuItem_Click;
            // 
            // listProductsToolStripMenuItem
            // 
            listProductsToolStripMenuItem.Name = "listProductsToolStripMenuItem";
            listProductsToolStripMenuItem.Size = new Size(285, 44);
            listProductsToolStripMenuItem.Text = "List products";
            listProductsToolStripMenuItem.Click += ListProducts;
            // 
            // ordersToolStripMenuItem
            // 
            ordersToolStripMenuItem.Name = "ordersToolStripMenuItem";
            ordersToolStripMenuItem.Size = new Size(105, 36);
            ordersToolStripMenuItem.Text = "Orders";
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(0, 47);
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersWidth = 82;
            dataGridView.Size = new Size(1486, 912);
            dataGridView.TabIndex = 1;
            dataGridView.CellMouseClick += ModifyOrder;
            // 
            // DefaultForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1361, 960);
            Controls.Add(dataGridView);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(6);
            Name = "DefaultForm";
            Text = "HoneyManagementAdministraion";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem productsToolStripMenuItem;
        private ToolStripMenuItem ordersToolStripMenuItem;
        private ToolStripMenuItem newProductToolStripMenuItem;
        private DataGridView dataGridView;
        private ToolStripMenuItem listProductsToolStripMenuItem;
    }
}
