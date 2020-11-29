using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai03{
    public partial class FormQuadratic : Form{
        public FormQuadratic(){
            InitializeComponent();
        }

        private void btnSolve_Click(object sender, EventArgs e){
            float a = Convert.ToSingle(this.txt_a.Text);
            float b = Convert.ToSingle(this.txt_b.Text);
            float c = Convert.ToSingle(this.txt_c.Text);
            string result;
            if (a == 0){
                if (b == 0 && c == 0){
                    this.txtResult.Text = "Phương trình có vô số nghiệm";
                }
                else{
                    if (b == 0 && c != 0){
                        this.txtResult.Text = "Phương trình vô nghiệm";
                    }
                    else{
                        result = (-c / b).ToString();
                        this.txtResult.Text = result;
                    }
                }
            }
            else {
                float delta = (b * b) - (4 * a * c);
                if (delta < 0)
                    this.txtResult.Text = "Phuong trinh vo nghiem";
                else {
                    if (delta == 0){
                        result = (-b / (2 * a)).ToString();
                        this.txtResult.Text = "x1 = x2 = " + result;
                    }
                    else{
                        double x1 = (-b - Math.Sqrt(delta)) / (2 * a);
                        double x2 = (-b + Math.Sqrt(delta)) / (2 * a);
                        result = "x1 = " + x1.ToString() + ", x2 = " + x2.ToString();
                        this.txtResult.Text = result;
                    }
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e){
            this.txt_a.Clear();
            this.txt_b.Clear();
            this.txt_c.Clear();
            this.txtResult.Clear();
            this.txt_a.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e){
            DialogResult reply = MessageBox.Show("Bạn muốn thoát chương trình?", "Giải phương trình bậc nhất: bx + c = 0", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (reply == DialogResult.Yes){
                Application.Exit();
            }
        }

        private void btnGoBack_Click(object sender, EventArgs e){
            this.Close();
        }
    }
}
