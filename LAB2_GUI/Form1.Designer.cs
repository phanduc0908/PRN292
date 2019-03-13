namespace LAB2_GUI
{
    partial class Home
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
            this.llbCat = new System.Windows.Forms.LinkLabel();
            this.llbSup = new System.Windows.Forms.LinkLabel();
            this.llbPro = new System.Windows.Forms.LinkLabel();
            this.llbOrd = new System.Windows.Forms.LinkLabel();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.btnAddPro = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // llbCat
            // 
            this.llbCat.AutoSize = true;
            this.llbCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbCat.Location = new System.Drawing.Point(60, 13);
            this.llbCat.Name = "llbCat";
            this.llbCat.Size = new System.Drawing.Size(92, 25);
            this.llbCat.TabIndex = 0;
            this.llbCat.TabStop = true;
            this.llbCat.Text = "Category";
            this.llbCat.Click += new System.EventHandler(this.llbCat_Click);
            // 
            // llbSup
            // 
            this.llbSup.AutoSize = true;
            this.llbSup.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbSup.Location = new System.Drawing.Point(280, 13);
            this.llbSup.Name = "llbSup";
            this.llbSup.Size = new System.Drawing.Size(84, 25);
            this.llbSup.TabIndex = 1;
            this.llbSup.TabStop = true;
            this.llbSup.Text = "Supplier";
            this.llbSup.Click += new System.EventHandler(this.llbSup_Click);
            // 
            // llbPro
            // 
            this.llbPro.AutoSize = true;
            this.llbPro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbPro.Location = new System.Drawing.Point(540, 13);
            this.llbPro.Name = "llbPro";
            this.llbPro.Size = new System.Drawing.Size(79, 25);
            this.llbPro.TabIndex = 2;
            this.llbPro.TabStop = true;
            this.llbPro.Text = "Product";
            this.llbPro.Click += new System.EventHandler(this.llbPro_Click);
            // 
            // llbOrd
            // 
            this.llbOrd.AutoSize = true;
            this.llbOrd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbOrd.Location = new System.Drawing.Point(833, 13);
            this.llbOrd.Name = "llbOrd";
            this.llbOrd.Size = new System.Drawing.Size(62, 25);
            this.llbOrd.TabIndex = 3;
            this.llbOrd.TabStop = true;
            this.llbOrd.Text = "Order";
            this.llbOrd.Click += new System.EventHandler(this.llbOrd_Click);
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(29, 82);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(938, 415);
            this.dgv.TabIndex = 4;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            // 
            // btnAddPro
            // 
            this.btnAddPro.Location = new System.Drawing.Point(29, 535);
            this.btnAddPro.Name = "btnAddPro";
            this.btnAddPro.Size = new System.Drawing.Size(96, 30);
            this.btnAddPro.TabIndex = 5;
            this.btnAddPro.Text = "Add product";
            this.btnAddPro.UseVisualStyleBackColor = true;
            this.btnAddPro.Click += new System.EventHandler(this.btnAddPro_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 631);
            this.Controls.Add(this.btnAddPro);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.llbOrd);
            this.Controls.Add(this.llbPro);
            this.Controls.Add(this.llbSup);
            this.Controls.Add(this.llbCat);
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel llbCat;
        private System.Windows.Forms.LinkLabel llbSup;
        private System.Windows.Forms.LinkLabel llbPro;
        private System.Windows.Forms.LinkLabel llbOrd;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btnAddPro;
    }
}

