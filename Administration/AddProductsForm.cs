using Common.Database;
using Common.Model;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Text;
using System.Windows.Forms;

namespace Administration
{
    public partial class AddProductsForm : Form
    {
        private ErrorProvider _errorProvider = new();
        private IServiceProvider _serviceProvider;
        public AddProductsForm(IServiceProvider serviceProvider)
        {
            InitializeComponent();

            productPackingDateTimePicker.MaxDate = DateTime.Now;
            productExpirationDateTimePicker.MinDate = productPackingDateTimePicker.Value;

            productPackingDateTimePicker.ValueChanged +=
                (sender, e) =>
            {
                productPackingDateTimePicker.MaxDate = DateTime.Now;
                productExpirationDateTimePicker.MinDate = productPackingDateTimePicker.Value;
            };

            string separator = string.Empty;
            var codecs = ImageCodecInfo.GetImageEncoders();
            foreach (var c in codecs)
            {
                string codecName = c.CodecName[8..].Replace("Codec", "Files").Trim();
                openFileDialog.Filter = String.Format("{0}{1}{2} ({3})|{3}", openFileDialog.Filter, separator, codecName, c.FilenameExtension);
                separator = "|";
            }

            _serviceProvider = serviceProvider;
        }

        private void ValidatePrice(object sender, EventArgs e)
        {
            if (productPriceTextBox.Text.Length > 0 && !float.TryParse(productPriceTextBox.Text, out float _))
            {
                _errorProvider.SetError(productPriceTextBox, $"Invalid value {productPriceTextBox.Text} for price!");
            }
        }

        private void SaveProduct(object sender, EventArgs e)
        {
            _errorProvider.Clear();

            string name = productNameTextBox.Text;

            if (string.IsNullOrEmpty(name))
            {
                _errorProvider.SetError(productNameTextBox, "Name field cannot be empty");
            }

            string description = productDescriptionTextBox.Text;

            if (string.IsNullOrEmpty(description))
            {
                _errorProvider.SetError(productDescriptionTextBox, "Description field cannot be empty");
            }

            string priceText = productPriceTextBox.Text;

            if (string.IsNullOrEmpty(description))
            {
                _errorProvider.SetError(productPriceTextBox, "Price field cannot be empty");
            }

            if (!float.TryParse(productPriceTextBox.Text, out float price))
            {
                _errorProvider.SetError(productPriceTextBox, $"Invalid value {productPriceTextBox.Text} for price!");
            }

            DateTime pacakged = productPackingDateTimePicker.Value;
            DateTime expired = productExpirationDateTimePicker.Value;

            if (_errorProvider.HasErrors)
            {
                return;
            }

            var product = new Product()
            {
                Id = 0,
                Name = name,
                Description = description,
                Price = price,
                PackingDate = pacakged,
                ExpirationDate = expired,
                Image = pictureBox.Image,
            };
            var db = _serviceProvider.GetRequiredService<IDatabase>();
            db.Create(product);
        }

        private void openImageButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox.Image = Image.FromFile(openFileDialog.FileName);
            }
        }
    }
}
