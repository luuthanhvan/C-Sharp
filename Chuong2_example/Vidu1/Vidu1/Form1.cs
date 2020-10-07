using System;
using System.Windows.Forms;

namespace Vidu1
{
    public partial class Form1 : Form{
        public Form1(){
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e){
            string thongbao;
            thongbao = "Tên đăng nhập là: ";
            thongbao += this.txtUser.Text;
            thongbao += "\n\rMật khẩu là: ";
            thongbao += this.txtPass.Text;
            if(this.chkNho.Checked == true){
                thongbao += "\n\rBạn có ghi nhớ.";
            }

            MessageBox.Show(thongbao, "Thông báo");
        }

        private void btnDelete_Click(object sender, EventArgs e){
            //this.txtUser.Clear();
            //this.txtPass.Clear();
            this.txtUser.ResetText();
            this.txtPass.ResetText();
            if (this.chkNho.Checked == true)
                this.chkNho.Checked = false;
            this.txtUser.Focus();
        }

        private void btnStop_Click(object sender, EventArgs e){
            DialogResult traloi;
            traloi = MessageBox.Show("Chắc không?", "Trả lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(traloi == DialogResult.OK)
                Application.Exit();
        }
    }
}
