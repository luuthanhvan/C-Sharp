using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai02
{
    public partial class FormFirstDegreeEquation : Form
    {
        public FormFirstDegreeEquation()
        {
            InitializeComponent();
        }

        private void FirstDegreeEquation_Load(object sender, EventArgs e)
        {

        }

        private void btnSolve_Click(object sender, EventArgs e)
        {
            float b = Convert.ToSingle(this.txt_b.Text);
            float c = Convert.ToSingle(this.txt_c.Text);
            string result;
            if (b == 0 && c == 0)
            {
                this.txtResult.Text = "Phương trình có vô số nghiệm";
            }
            else
                if (b == 0 && c != 0)
            {
                this.txtResult.Text = "Phương trình vô nghiệm";
            }
            else
            {
                result = (-c / b).ToString();
                this.txtResult.Text = result;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.txt_b.Clear();
            this.txt_c.Clear();
            this.txtResult.Clear();
            this.txt_b.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult reply = MessageBox.Show("Bạn muốn thoát chương trình?", "Giải phương trình bậc nhất: bx + c = 0", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (reply == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
