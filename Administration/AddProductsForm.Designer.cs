namespace Administration
{
    partial class AddProductsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            productNameTextBox = new TextBox();
            productDescriptionTextBox = new TextBox();
            productPriceTextBox = new TextBox();
            productPackingDateTimePicker = new DateTimePicker();
            productExpirationDateTimePicker = new DateTimePicker();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(92, 56);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(64, 82);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 1;
            label2.Text = "Description";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(95, 172);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 2;
            label3.Text = "Price:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(52, 200);
            label4.Name = "label4";
            label4.Size = new Size(79, 15);
            label4.TabIndex = 3;
            label4.Text = "Packing Date:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(42, 229);
            label5.Name = "label5";
            label5.Size = new Size(89, 15);
            label5.TabIndex = 4;
            label5.Text = "Expiration Date:";
            // 
            // addProductNameTextBox
            // 
            productNameTextBox.Location = new Point(137, 53);
            productNameTextBox.Name = "addProductNameTextBox";
            productNameTextBox.Size = new Size(248, 23);
            productNameTextBox.TabIndex = 5;
            // 
            // addProductDescriptionTextBox
            // 
            productDescriptionTextBox.Location = new Point(137, 82);
            productDescriptionTextBox.Multiline = true;
            productDescriptionTextBox.Name = "addProductDescriptionTextBox";
            productDescriptionTextBox.Size = new Size(248, 76);
            productDescriptionTextBox.TabIndex = 6;
            // 
            // addProductPriceTextBox
            // 
            productPriceTextBox.Location = new Point(137, 164);
            productPriceTextBox.Name = "addProductPriceTextBox";
            productPriceTextBox.Size = new Size(248, 23);
            productPriceTextBox.TabIndex = 7;
            productPriceTextBox.TextChanged += ValidatePrice;
            // 
            // addProductPackingDateTimePicker
            // 
            productPackingDateTimePicker.Location = new Point(137, 194);
            productPackingDateTimePicker.Name = "addProductPackingDateTimePicker";
            productPackingDateTimePicker.Size = new Size(248, 23);
            productPackingDateTimePicker.TabIndex = 8;
            // 
            // addProductExpirationDateTimePicker
            // 
            productExpirationDateTimePicker.Location = new Point(137, 223);
            productExpirationDateTimePicker.Name = "addProductExpirationDateTimePicker";
            productExpirationDateTimePicker.Size = new Size(248, 23);
            productExpirationDateTimePicker.TabIndex = 9;
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.Cancel;
            button1.Location = new Point(111, 392);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 10;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(255, 392);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 11;
            button2.Text = "Save";
            button2.UseVisualStyleBackColor = true;
            // 
            // AddProductsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(429, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(productExpirationDateTimePicker);
            Controls.Add(productPackingDateTimePicker);
            Controls.Add(productPriceTextBox);
            Controls.Add(productDescriptionTextBox);
            Controls.Add(productNameTextBox);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddProductsForm";
            Text = "AddProductsForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox productNameTextBox;
        private TextBox productDescriptionTextBox;
        private TextBox productPriceTextBox;
        private DateTimePicker productPackingDateTimePicker;
        private DateTimePicker productExpirationDateTimePicker;
        private Button button1;
        private Button button2;
    }
}