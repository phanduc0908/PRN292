namespace LAB2_GUI
{
    partial class frmCreate
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtProName = new System.Windows.Forms.TextBox();
            this.cbDis = new System.Windows.Forms.CheckBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ccbCat = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ccbSup = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product Name";
            // 
            // txtProName
            // 
            this.txtProName.Location = new System.Drawing.Point(125, 53);
            this.txtProName.Name = "txtProName";
            this.txtProName.Size = new System.Drawing.Size(139, 20);
            this.txtProName.TabIndex = 1;
            // 
            // cbDis
            // 
            this.cbDis.AutoSize = true;
            this.cbDis.Location = new System.Drawing.Point(125, 300);
            this.cbDis.Name = "cbDis";
            this.cbDis.Size = new System.Drawing.Size(88, 17);
            this.cbDis.TabIndex = 18;
            this.cbDis.Text = "Discontinued";
            this.cbDis.UseVisualStyleBackColor = true;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(125, 243);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(99, 20);
            this.txtPrice.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Price";
            // 
            // ccbCat
            // 
            this.ccbCat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ccbCat.FormattingEnabled = true;
            this.ccbCat.Location = new System.Drawing.Point(125, 175);
            this.ccbCat.Name = "ccbCat";
            this.ccbCat.Size = new System.Drawing.Size(158, 21);
            this.ccbCat.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Category";
            // 
            // ccbSup
            // 
            this.ccbSup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ccbSup.FormattingEnabled = true;
            this.ccbSup.Location = new System.Drawing.Point(125, 107);
            this.ccbSup.Name = "ccbSup";
            this.ccbSup.Size = new System.Drawing.Size(158, 21);
            this.ccbSup.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Supplier";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(83, 353);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 19;
            this.btnAdd.Text = "Create";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // frmCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 456);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cbDis);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ccbCat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ccbSup);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtProName);
            this.Controls.Add(this.label1);
            this.Name = "frmCreate";
            this.Text = "frmCreate";
            this.Load += new System.EventHandler(this.frmCreate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProName;
        private System.Windows.Forms.CheckBox cbDis;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ccbCat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ccbSup;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAdd;
    }
}