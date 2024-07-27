using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TinhHInhChuNhat1
{
    public partial class Form1 : Form

    {
        double dai;
        double rong;
        public Form1()
        {
            InitializeComponent();
        }

        private void btTinh_Click(object sender, EventArgs e)
        {
            if (LayThongTin())
            {
                lbKQ.Text = "Diện Tích: " + TinhChuVi(dai, rong) + Environment.NewLine;
                lbKQ.Text += "Chu Vi: " + TinhChuNhat(dai, rong);

            }
            else
            {

            }

        }

        private bool LayThongTin()
        {
            try
            {
                dai = Convert.ToDouble(txtCD.Text);
                rong = Convert.ToDouble(txtCR.Text);
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Phải Nhập Số Nguyên", "Thông Báo Lỗi" + MessageBoxIcon.Error, MessageBoxButtons.OK);
                return false;
            }
        }
        private double TinhChuVi(double dai, double rong)
        {
            return (dai + rong) * 2;
        }
        private double TinhChuNhat(double dai, double rong)
        {
            return dai * rong; 
        }

        private void bttinhnew_Click(object sender, EventArgs e)
        {
            if(LayThongTin())
            {
                if (CKCV.Checked)
                {
                    lbKQ.Text = "Chu Vi: " + TinhChuVi(dai, rong);
                }
                if (CKDT.Checked)
                {
                    lbKQ.Text = "Diện Tích: " + TinhChuNhat(dai, rong);
                }
                if(CKCV.Checked && CKDT.Checked)
                {
                    lbKQ.Text = "Chu Vi: " + TinhChuVi(dai, rong) + Environment.NewLine;
                    lbKQ.Text = "Diện Tích: " + TinhChuNhat(dai, rong);
                }
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            txtCD.Text = numericUpDown1.Value.ToString();
            txtCR.Text = numericUpDown1.Value.ToString();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
