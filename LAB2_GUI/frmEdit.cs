using LAB2_CORE;
using LAB2_SERVICE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB2_GUI
{
    public partial class frmEdit : Form
    {
        int productID;
        public frmEdit()
        {
            InitializeComponent();
        }
        public frmEdit(int id)
        {
            InitializeComponent();
            productID = id;
        }

        private void frmEdit_Load(object sender, EventArgs e)
        {
            Product product = ServiceProduct.GetProductByID(productID);

            txtProID.Text = product.ProductID.ToString();
            txtProName.Text = product.ProductName;
            txtPrice.Text = product.Price.ToString();

            ccbSup.DisplayMember = "CompanyName";
            ccbSup.ValueMember = "SupplierID";
            ccbSup.DataSource = ServiceSupplier.GetSuppliers();
            ccbSup.SelectedValue = product.SupplierID;

            ccbCat.DisplayMember = "CategoryName";
            ccbCat.ValueMember = "CategoryID";
            ccbCat.DataSource = ServiceCategory.GetCategories();
            ccbCat.SelectedValue = product.CategoryID;

            if (product.Discontinue)
            {
                cbDis.Checked = true;
            }
            else
            {
                cbDis.Checked = false;
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            bool isValid = true;
            string message = "";
            double price = 0;
            string productName = txtProName.Text.Trim();
            if (productName == "")
            {
                isValid = false;
                message = "Product name is required";
            }
            try
            {
                price = Convert.ToDouble(txtPrice.Text.Trim());
            }
            catch
            {
                isValid = false;
                message = "Price is not correct";
            }
            int catID = Convert.ToInt32(ccbCat.SelectedValue);
            int supID = Convert.ToInt32(ccbSup.SelectedValue);
            bool discontinued = Convert.ToBoolean(cbDis.Checked);
            if (isValid)
            {
                int result = ServiceProduct.UpdateProduct(productID, productName, catID, supID, price, discontinued);
                MessageBox.Show("Number rows effect: " + result.ToString());
            }
            else
            {
                MessageBox.Show(message);
            }

        }
    }
}
