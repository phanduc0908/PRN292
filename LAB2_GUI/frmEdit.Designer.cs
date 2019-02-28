namespace LAB2_GUI
{
    partial class frmEdit
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
            this.lbProID = new System.Windows.Forms.Label();
            this.txtProID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtProName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ccbSup = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ccbCat = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.cbDis = new System.Windows.Forms.CheckBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbProID
            // 
            this.lbProID.AutoSize = true;
            this.lbProID.Location = new System.Drawing.Point(22, 38);
            this.lbProID.Name = "lbProID";
            this.lbProID.Size = new System.Drawing.Size(58, 13);
            this.lbProID.TabIndex = 0;
            this.lbProID.Text = "Product ID";
            // 
            // txtProID
            // 
            this.txtProID.Enabled = false;
            this.txtProID.Location = new System.Drawing.Point(128, 35);
            this.txtProID.Name = "txtProID";
            this.txtProID.ReadOnly = true;
            this.txtProID.Size = new System.Drawing.Size(61, 20);
            this.txtProID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Product Name";
            // 
            // txtProName
            // 
            this.txtProName.Location = new System.Drawing.Point(128, 78);
            this.txtProName.Name = "txtProName";
            this.txtProName.Size = new System.Drawing.Size(185, 20);
            this.txtProName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Supplier";
            // 
            // ccbSup
            // 
            this.ccbSup.FormattingEnabled = true;
            this.ccbSup.Location = new System.Drawing.Point(128, 128);
            this.ccbSup.Name = "ccbSup";
            this.ccbSup.Size = new System.Drawing.Size(158, 21);
            this.ccbSup.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Category";
            // 
            // ccbCat
            // 
            this.ccbCat.FormattingEnabled = true;
            this.ccbCat.Location = new System.Drawing.Point(128, 183);
            this.ccbCat.Name = "ccbCat";
            this.ccbCat.Size = new System.Drawing.Size(158, 21);
            this.ccbCat.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Price";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(128, 235);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(99, 20);
            this.txtPrice.TabIndex = 9;
            // 
            // cbDis
            // 
            this.cbDis.AutoSize = true;
            this.cbDis.Location = new System.Drawing.Point(128, 289);
            this.cbDis.Name = "cbDis";
            this.cbDis.Size = new System.Drawing.Size(88, 17);
            this.cbDis.TabIndex = 11;
            this.cbDis.Text = "Discontinued";
            this.cbDis.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(114, 381);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(102, 29);
            this.btnEdit.TabIndex = 12;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // frmEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 488);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.cbDis);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ccbCat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ccbSup);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtProName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtProID);
            this.Controls.Add(this.lbProID);
            this.Name = "frmEdit";
            this.Text = "frmEdit";
            this.Load += new System.EventHandler(this.frmEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbProID;
        private System.Windows.Forms.TextBox txtProID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ccbSup;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ccbCat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.CheckBox cbDis;
        private System.Windows.Forms.Button btnEdit;
    }
}