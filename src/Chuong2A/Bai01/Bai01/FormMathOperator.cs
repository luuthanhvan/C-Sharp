using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai01
{
    public partial class FormMathOperator : Form
    {
        public FormMathOperator(){
            InitializeComponent();
        }

        private void btnPlus_Click(object sender, EventArgs e){
            string str1 = this.txtNum1.Text;
            string str2 = this.txtNum2.Text;
            float num1 = Convert.ToSingle(str1);
            float num2 = Convert.ToSingle(str2);

            float result = num1 + num2;

            this.txtResult.Text = result.ToString();
        }

        private void btnSub_Click(object sender, EventArgs e){
            string str1 = this.txtNum1.Text;
            string str2 = this.txtNum2.Text;
            float num1 = Convert.ToSingle(str1);
            float num2 = Convert.ToSingle(str2);

            float result = num1 - num2;

            this.txtResult.Text = result.ToString();
        }

        private void btnMul_Click(object sender, EventArgs e){
            string str1 = this.txtNum1.Text;
            string str2 = this.txtNum2.Text;
            float num1 = Convert.ToSingle(str1);
            float num2 = Convert.ToSingle(str2);

            float result = num1 * num2;

            this.txtResult.Text = result.ToString();
        }

        private void btnDiv_Click(object sender, EventArgs e){
            float num1 = Convert.ToSingle(this.txtNum1.Text);
            float num2 = Convert.ToSingle(this.txtNum2.Text);
            string result = "";
            if (num2 == 0){
                MessageBox.Show("Số bị chia phải khác 0", "Thông báo");
                this.txtNum2.Focus();
            }
            else {
                result = (num1 / num2).ToString(); 
            }

            this.txtResult.Text = result;
        }

        private void btnClear_Click(object sender, EventArgs e){
            this.txtNum1.Clear();
            this.txtNum2.Clear();
            this.txtResult.Clear();
            this.txtNum1.Focus();
        }

        private void btnStop_Click(object sender, EventArgs e){
            DialogResult reply = MessageBox.Show("Bạn muốn thoát chương trình?", "Các phép toán số học", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (reply == DialogResult.Yes)
                Application.Exit();
        }

        private void btnGoBack_Click(object sender, EventArgs e){
            this.Close();
        }
    }
}
