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
    public partial class frmCreate : Form
    {
        public frmCreate()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string productName = txtProName.Text.Trim();
            double price = Convert.ToDouble(txtPrice.Text.Trim());
            int catID = Convert.ToInt32(ccbCat.SelectedValue);
            int supID = Convert.ToInt32(ccbSup.SelectedValue);
            bool discontinued = Convert.ToBoolean(cbDis.Checked);

            int result = ServiceProduct.CreateProduct(productName, catID, supID, price, discontinued);
            MessageBox.Show("Row effect(s): " + result.ToString());
        }

        private void frmCreate_Load(object sender, EventArgs e)
        {
            ccbSup.DisplayMember = "CompanyName";
            ccbSup.ValueMember = "SupplierID";
            ccbSup.DataSource = ServiceSupplier.GetSuppliers();

            ccbCat.DisplayMember = "CategoryName";
            ccbCat.ValueMember = "CategoryID";
            ccbCat.DataSource = ServiceCategory.GetCategories();
        }
    }
}
