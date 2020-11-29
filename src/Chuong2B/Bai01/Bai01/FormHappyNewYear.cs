using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai01{
    public partial class FormHappyNewYear : Form{
        string message = "Chúc mừng năm mới - Happy new year";
        int i = 0;
        public FormHappyNewYear(){
            InitializeComponent();
        }
        private void btnToggle_Click(object sender, EventArgs e){
            if(this.btnToggle.Text == "Chạy"){
                this.timer.Enabled = true;
                this.btnToggle.Text = "Dừng";
            }
            else{
                this.timer.Enabled = false;
                this.btnToggle.Text = "Chạy";
            }
        }

        private void timer_Tick(object sender, EventArgs e){
            this.lbMessage.Text += message[i].ToString();
            i++;
            if (i == message.Length)
                this.timer.Enabled = false;
        }

        private void btnExit_Click(object sender, EventArgs e){
            Application.Exit();
        }
    }
}
