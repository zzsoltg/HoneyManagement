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
            openImageButton = new Button();
            pictureBox = new PictureBox();
            openFileDialog = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(171, 119);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(78, 32);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(119, 175);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(135, 32);
            label2.TabIndex = 1;
            label2.Text = "Description";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(176, 367);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(70, 32);
            label3.TabIndex = 2;
            label3.Text = "Price:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(92, 427);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new Size(157, 32);
            label4.TabIndex = 3;
            label4.Text = "Packing Date:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(61, 484);
            label5.Margin = new Padding(6, 0, 6, 0);
            label5.Name = "label5";
            label5.Size = new Size(181, 32);
            label5.TabIndex = 4;
            label5.Text = "Expiration Date:";
            // 
            // productNameTextBox
            // 
            productNameTextBox.Location = new Point(254, 119);
            productNameTextBox.Margin = new Padding(6, 6, 6, 6);
            productNameTextBox.Name = "productNameTextBox";
            productNameTextBox.Size = new Size(457, 39);
            productNameTextBox.TabIndex = 5;
            // 
            // productDescriptionTextBox
            // 
            productDescriptionTextBox.Location = new Point(255, 175);
            productDescriptionTextBox.Margin = new Padding(6, 6, 6, 6);
            productDescriptionTextBox.Multiline = true;
            productDescriptionTextBox.Name = "productDescriptionTextBox";
            productDescriptionTextBox.Size = new Size(457, 158);
            productDescriptionTextBox.TabIndex = 6;
            // 
            // productPriceTextBox
            // 
            productPriceTextBox.Location = new Point(254, 360);
            productPriceTextBox.Margin = new Padding(6, 6, 6, 6);
            productPriceTextBox.Name = "productPriceTextBox";
            productPriceTextBox.Size = new Size(457, 39);
            productPriceTextBox.TabIndex = 7;
            productPriceTextBox.TextChanged += ValidatePrice;
            // 
            // productPackingDateTimePicker
            // 
            productPackingDateTimePicker.Location = new Point(254, 422);
            productPackingDateTimePicker.Margin = new Padding(6, 6, 6, 6);
            productPackingDateTimePicker.Name = "productPackingDateTimePicker";
            productPackingDateTimePicker.Size = new Size(457, 39);
            productPackingDateTimePicker.TabIndex = 8;
            // 
            // productExpirationDateTimePicker
            // 
            productExpirationDateTimePicker.Location = new Point(254, 484);
            productExpirationDateTimePicker.Margin = new Padding(6, 6, 6, 6);
            productExpirationDateTimePicker.Name = "productExpirationDateTimePicker";
            productExpirationDateTimePicker.Size = new Size(457, 39);
            productExpirationDateTimePicker.TabIndex = 9;
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.Cancel;
            button1.Location = new Point(206, 836);
            button1.Margin = new Padding(6, 6, 6, 6);
            button1.Name = "button1";
            button1.Size = new Size(139, 49);
            button1.TabIndex = 10;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(474, 836);
            button2.Margin = new Padding(6, 6, 6, 6);
            button2.Name = "button2";
            button2.Size = new Size(139, 49);
            button2.TabIndex = 11;
            button2.Text = "Save";
            button2.UseVisualStyleBackColor = true;
            // 
            // openImageButton
            // 
            openImageButton.Location = new Point(66, 555);
            openImageButton.Name = "openImageButton";
            openImageButton.Size = new Size(183, 46);
            openImageButton.TabIndex = 12;
            openImageButton.Text = "Open image";
            openImageButton.UseVisualStyleBackColor = true;
            openImageButton.Click += openImageButton_Click;
            // 
            // pictureBox
            // 
            pictureBox.Location = new Point(255, 555);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(456, 235);
            pictureBox.TabIndex = 13;
            pictureBox.TabStop = false;
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog";
            // 
            // AddProductsForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(797, 960);
            Controls.Add(pictureBox);
            Controls.Add(openImageButton);
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
            Margin = new Padding(6, 6, 6, 6);
            Name = "AddProductsForm";
            Text = "AddProductsForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
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
        private Button openImageButton;
        private PictureBox pictureBox;
        private OpenFileDialog openFileDialog;
    }
}