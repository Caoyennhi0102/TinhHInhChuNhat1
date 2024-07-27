namespace TinhHInhChuNhat1
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
            this.lbCR = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.llbCD = new System.Windows.Forms.Label();
            this.lbKQ = new System.Windows.Forms.Label();
            this.txtCD = new System.Windows.Forms.TextBox();
            this.txtCR = new System.Windows.Forms.TextBox();
            this.btTinh = new System.Windows.Forms.Button();
            this.gbCcn = new System.Windows.Forms.GroupBox();
            this.btThoat = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.bttinhnew = new System.Windows.Forms.Button();
            this.CKDT = new System.Windows.Forms.CheckBox();
            this.CKCV = new System.Windows.Forms.CheckBox();
            this.gbCcn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbCR
            // 
            this.lbCR.AutoSize = true;
            this.lbCR.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCR.Location = new System.Drawing.Point(20, 62);
            this.lbCR.Margin = new System.Windows.Forms.Padding(11, 0, 11, 0);
            this.lbCR.Name = "lbCR";
            this.lbCR.Size = new System.Drawing.Size(155, 31);
            this.lbCR.TabIndex = 0;
            this.lbCR.Text = "Chiều Rộng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1189, 407);
            this.label1.Margin = new System.Windows.Forms.Padding(11, 0, 11, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chiều Rộng";
            // 
            // llbCD
            // 
            this.llbCD.AutoSize = true;
            this.llbCD.Location = new System.Drawing.Point(14, 110);
            this.llbCD.Name = "llbCD";
            this.llbCD.Size = new System.Drawing.Size(161, 39);
            this.llbCD.TabIndex = 2;
            this.llbCD.Text = "Chiều Dài";
            // 
            // lbKQ
            // 
            this.lbKQ.AutoSize = true;
            this.lbKQ.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKQ.Location = new System.Drawing.Point(19, 161);
            this.lbKQ.Name = "lbKQ";
            this.lbKQ.Size = new System.Drawing.Size(139, 39);
            this.lbKQ.TabIndex = 3;
            this.lbKQ.Text = "Kết Quả";
            // 
            // txtCD
            // 
            this.txtCD.Location = new System.Drawing.Point(206, 53);
            this.txtCD.Name = "txtCD";
            this.txtCD.Size = new System.Drawing.Size(100, 46);
            this.txtCD.TabIndex = 4;
            // 
            // txtCR
            // 
            this.txtCR.Location = new System.Drawing.Point(206, 110);
            this.txtCR.Name = "txtCR";
            this.txtCR.Size = new System.Drawing.Size(100, 46);
            this.txtCR.TabIndex = 5;
            // 
            // btTinh
            // 
            this.btTinh.Location = new System.Drawing.Point(12, 460);
            this.btTinh.Name = "btTinh";
            this.btTinh.Size = new System.Drawing.Size(160, 41);
            this.btTinh.TabIndex = 8;
            this.btTinh.Text = "Tính";
            this.btTinh.UseVisualStyleBackColor = true;
            this.btTinh.Click += new System.EventHandler(this.btTinh_Click);
            // 
            // gbCcn
            // 
            this.gbCcn.Controls.Add(this.CKCV);
            this.gbCcn.Controls.Add(this.CKDT);
            this.gbCcn.Location = new System.Drawing.Point(21, 251);
            this.gbCcn.Name = "gbCcn";
            this.gbCcn.Size = new System.Drawing.Size(327, 158);
            this.gbCcn.TabIndex = 9;
            this.gbCcn.TabStop = false;
            this.gbCcn.Text = "Chọn Chức Năng ";
            // 
            // btThoat
            // 
            this.btThoat.Location = new System.Drawing.Point(195, 460);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(153, 41);
            this.btThoat.TabIndex = 10;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(333, 54);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 46);
            this.numericUpDown1.TabIndex = 11;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1186, 402);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 41);
            this.button1.TabIndex = 12;
            this.button1.Text = "Tính";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // bttinhnew
            // 
            this.bttinhnew.Location = new System.Drawing.Point(354, 460);
            this.bttinhnew.Name = "bttinhnew";
            this.bttinhnew.Size = new System.Drawing.Size(195, 49);
            this.bttinhnew.TabIndex = 13;
            this.bttinhnew.Text = "New";
            this.bttinhnew.UseVisualStyleBackColor = true;
            this.bttinhnew.Click += new System.EventHandler(this.bttinhnew_Click);
            // 
            // CKDT
            // 
            this.CKDT.AutoSize = true;
            this.CKDT.Location = new System.Drawing.Point(21, 56);
            this.CKDT.Name = "CKDT";
            this.CKDT.Size = new System.Drawing.Size(176, 43);
            this.CKDT.TabIndex = 0;
            this.CKDT.Text = "Diện Tích";
            this.CKDT.UseVisualStyleBackColor = true;
            // 
            // CKCV
            // 
            this.CKCV.AutoSize = true;
            this.CKCV.Location = new System.Drawing.Point(21, 105);
            this.CKCV.Name = "CKCV";
            this.CKCV.Size = new System.Drawing.Size(133, 43);
            this.CKCV.TabIndex = 1;
            this.CKCV.Text = "Chu Vi";
            this.CKCV.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 39F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2532, 845);
            this.Controls.Add(this.bttinhnew);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.gbCcn);
            this.Controls.Add(this.btTinh);
            this.Controls.Add(this.txtCR);
            this.Controls.Add(this.txtCD);
            this.Controls.Add(this.lbKQ);
            this.Controls.Add(this.llbCD);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbCR);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Purple;
            this.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbCcn.ResumeLayout(false);
            this.gbCcn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label llbCD;
        private System.Windows.Forms.Label lbKQ;
        private System.Windows.Forms.TextBox txtCD;
        private System.Windows.Forms.TextBox txtCR;
        private System.Windows.Forms.Button btTinh;
        private System.Windows.Forms.GroupBox gbCcn;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bttinhnew;
        private System.Windows.Forms.CheckBox CKDT;
        private System.Windows.Forms.CheckBox CKCV;
    }
}

