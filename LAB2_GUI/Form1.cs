using LAB2_DATA;
using LAB2_SERVICE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LAB2_GUI
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }
        public static int count = 0;
        public void GennerateButton()
        {
            DataGridViewButtonColumn editCol = new DataGridViewButtonColumn();
            editCol.Name = "editcol";
            editCol.Text = "Edit";
            editCol.UseColumnTextForButtonValue = true;
            dgv.Columns.Add(editCol);

            DataGridViewButtonColumn delCol = new DataGridViewButtonColumn();
            delCol.Name = "delcol";
            delCol.Text = "Delete";
            delCol.UseColumnTextForButtonValue = true;
            dgv.Columns.Add(delCol);
        }
        public void RemoveCol()
        {
            dgv.Columns.Remove(dgv.Columns["editcol"]);
            dgv.Columns.Remove(dgv.Columns["delcol"]);
        }
        void GetDataForDataGridView()
        {
            if (dgv.Columns["editcol"] != null)
            {
                RemoveCol();
            }

            dgv.DataSource = ServiceProduct.GetAllProducts();
            GennerateButton();
            btnAddPro.Enabled = true;
            llbPro.Enabled = false;

            llbSup.Enabled = true;
            llbOrd.Enabled = true;
            llbCat.Enabled = true;
        }
        void frmEdit_Closed(object sender, EventArgs e)
        {
            GetDataForDataGridView();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            dgv.DataSource = ServiceCategory.GetCategories();

            llbCat.Enabled = false;
            btnAddPro.Enabled = false;
        }

        private void llbSup_Click(object sender, EventArgs e)
        {
            if (dgv.Columns["editcol"] != null)
            {
                RemoveCol();
            }

            dgv.DataSource = ServiceSupplier.GetSuppliers();
            btnAddPro.Enabled = false;
            llbSup.Enabled = false;

            llbPro.Enabled = true;
            llbOrd.Enabled = true;
            llbCat.Enabled = true;
        }

        private void llbPro_Click(object sender, EventArgs e)
        {
            GetDataForDataGridView();
        }

        private void llbOrd_Click(object sender, EventArgs e)
        {
            if (dgv.Columns["editcol"] != null)
            {
                RemoveCol();
            }

            dgv.DataSource = ServiceOrder.GetAllOrders();
            btnAddPro.Enabled = false;
            llbOrd.Enabled = false;

            llbPro.Enabled = true;
            llbSup.Enabled = true;
            llbCat.Enabled = true;
        }

        private void llbCat_Click(object sender, EventArgs e)
        {
            if (dgv.Columns["editcol"] != null)
            {
                RemoveCol();
            }

            dgv.DataSource = ServiceCategory.GetCategories();
            btnAddPro.Enabled = false;
            llbCat.Enabled = false;

            llbPro.Enabled = true;
            llbOrd.Enabled = true;
            llbSup.Enabled = true;
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv.Columns[e.ColumnIndex].Name == "delcol")
            {
                int productID = Convert.ToInt32(dgv.Rows[e.RowIndex].Cells[0].Value);
                DialogResult result = MessageBox.Show("Do you want to delete ?", "Confirm delete", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    int count = DataProduct.DeleteProduct(productID);
                    MessageBox.Show(count.ToString() + " products were deleted.");
                    GetDataForDataGridView();
                }
            }
            if (dgv.Columns[e.ColumnIndex].Name == "editcol")
            {
                int productID = Convert.ToInt32(dgv.Rows[e.RowIndex].Cells[0].Value);

                frmEdit editForm = new frmEdit(productID);
                editForm.FormClosed += frmEdit_Closed;
                editForm.Show();
            }
        }

        private void btnAddPro_Click(object sender, EventArgs e)
        {
            frmCreate addForm = new frmCreate();
            addForm.FormClosed += frmEdit_Closed;
            addForm.Show();
        }
    }
}
