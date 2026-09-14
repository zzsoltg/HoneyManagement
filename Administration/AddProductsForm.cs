using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Administration
{
    public partial class AddProductsForm : Form
    {
        private ErrorProvider _errorProvider = new(); 

        public AddProductsForm()
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
            if (!float.TryParse(productPriceTextBox.Text, out float _))
            {
                _errorProvider.SetError(productPriceTextBox, $"Invalid value {productPriceTextBox.Text} for price!");
            }

            DateTime pacakged = productPackingDateTimePicker.Value;
            DateTime expired = productExpirationDateTimePicker.Value;

            if (_errorProvider.HasErrors)
            {
                return;
            }
        }
    }
}
