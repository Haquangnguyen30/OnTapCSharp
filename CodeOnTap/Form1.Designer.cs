namespace CodeOnTap
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSua = new System.Windows.Forms.Button();
            this.cbKH = new System.Windows.Forms.ComboBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.dvKH = new System.Windows.Forms.DataGridView();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.lbSDT = new System.Windows.Forms.Label();
            this.lbKH = new System.Windows.Forms.Label();
            this.txtTk = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvKH)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtTk);
            this.panel1.Controls.Add(this.txtMaKH);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.cbKH);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.dvKH);
            this.panel1.Controls.Add(this.txtSDT);
            this.panel1.Controls.Add(this.txtTenKH);
            this.panel1.Controls.Add(this.lbSDT);
            this.panel1.Controls.Add(this.lbKH);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(616, 587);
            this.panel1.TabIndex = 0;
            // 
            // txtMaKH
            // 
            this.txtMaKH.Enabled = false;
            this.txtMaKH.Location = new System.Drawing.Point(192, 86);
            this.txtMaKH.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(260, 20);
            this.txtMaKH.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 88);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Mã khách hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 180);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Danh sách Khách Hàng";
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(492, 88);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(115, 20);
            this.btnXoa.TabIndex = 9;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 118);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Cb Khách Hàng";
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(492, 56);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(115, 18);
            this.btnSua.TabIndex = 7;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // cbKH
            // 
            this.cbKH.FormattingEnabled = true;
            this.cbKH.Location = new System.Drawing.Point(192, 115);
            this.cbKH.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbKH.Name = "cbKH";
            this.cbKH.Size = new System.Drawing.Size(260, 21);
            this.cbKH.TabIndex = 6;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(492, 19);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(115, 19);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dvKH
            // 
            this.dvKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvKH.Location = new System.Drawing.Point(9, 208);
            this.dvKH.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dvKH.Name = "dvKH";
            this.dvKH.RowHeadersWidth = 51;
            this.dvKH.RowTemplate.Height = 24;
            this.dvKH.Size = new System.Drawing.Size(598, 354);
            this.dvKH.TabIndex = 4;
            this.dvKH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvKH_CellClick);
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(192, 56);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(260, 20);
            this.txtSDT.TabIndex = 3;
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(192, 19);
            this.txtTenKH.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(260, 20);
            this.txtTenKH.TabIndex = 2;
            // 
            // lbSDT
            // 
            this.lbSDT.AutoSize = true;
            this.lbSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSDT.Location = new System.Drawing.Point(20, 58);
            this.lbSDT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbSDT.Name = "lbSDT";
            this.lbSDT.Size = new System.Drawing.Size(95, 17);
            this.lbSDT.TabIndex = 1;
            this.lbSDT.Text = "Số điện thoại:";
            // 
            // lbKH
            // 
            this.lbKH.AutoSize = true;
            this.lbKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKH.Location = new System.Drawing.Point(18, 21);
            this.lbKH.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbKH.Name = "lbKH";
            this.lbKH.Size = new System.Drawing.Size(119, 17);
            this.lbKH.TabIndex = 0;
            this.lbKH.Text = "Tên Khách Hàng:";
            // 
            // txtTk
            // 
            this.txtTk.Location = new System.Drawing.Point(192, 140);
            this.txtTk.Margin = new System.Windows.Forms.Padding(2);
            this.txtTk.Name = "txtTk";
            this.txtTk.Size = new System.Drawing.Size(260, 20);
            this.txtTk.TabIndex = 13;
            this.txtTk.TextChanged += new System.EventHandler(this.txtTk_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 587);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvKH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbKH;
        private System.Windows.Forms.Label lbSDT;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.DataGridView dvKH;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ComboBox cbKH;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTk;
    }
}

