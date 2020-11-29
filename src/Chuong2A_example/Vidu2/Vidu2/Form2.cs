using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vidu2
{
    public partial class Form2 : Form
    {
        public Form2(){
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e){
            if ((this.txtUser.Text == "admin") && (this.txtPass.Text == "admin")){
                // form load
                Form form = new Form1();
                form.ShowDialog();
            }
            else{
                MessageBox.Show("Không đúng tên người dùng/mật khẩu!!!", "Thông báo");
                this.txtUser.Focus();
            }
        }

        private void btnExit_Click(object sender, EventArgs e){
            DialogResult traloi;
            traloi = MessageBox.Show("Chắc không?", "Trả lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
                Application.Exit();
        }
    }
}
