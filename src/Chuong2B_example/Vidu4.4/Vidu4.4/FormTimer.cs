using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vidu4._4{
    public partial class FormTimer : Form{
        int i = 20;
        public FormTimer(){
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e){
            this.timer.Enabled = true;
        }

        private void timer_Tick(object sender, EventArgs e){
            this.lbTime.Text = i.ToString();
            i--;
            if(i < 0){
                this.timer.Enabled = false;
                this.lbTime.Text = "Hết giờ!";
            }
        }

        private void btnStop_Click(object sender, EventArgs e){
            this.timer.Enabled = false;
        }
    }
}
