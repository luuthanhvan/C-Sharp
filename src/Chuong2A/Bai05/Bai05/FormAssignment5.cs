using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai05
{
    public partial class FormAssignment5 : Form{
        public FormAssignment5(){
            InitializeComponent();
        }

        private void btnAssignment1_Click(object sender, EventArgs e){
            Form form = new Bai01.FormMathOperator();
            form.ShowDialog();
        }

        private void btnAssignment2_Click(object sender, EventArgs e){
            Form form = new Bai02.FormFirstDegreeEquation();
            form.ShowDialog();
        }

        private void btnAssignment3_Click(object sender, EventArgs e){
            Form form = new Bai03.FormQuadratic();
            form.ShowDialog();
        }

        private void btnAssignment4_Click(object sender, EventArgs e){
            Form form = new Bai04.FormCalculatingScore();
            form.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e){
            DialogResult reply = MessageBox.Show("Bạn muốn thoát chương trình?", "Chương trình ứng dụng",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (reply == DialogResult.Yes)
                Application.Exit();
        }
    }
}
