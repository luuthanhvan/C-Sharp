using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vidu4._3{
    public partial class FormTextTransform : Form{
        public FormTextTransform(){
            InitializeComponent();
        }

        private void btnResult_Click(object sender, EventArgs e){
            string fullname = this.txtFullname.Text.Trim();
            if (this.radLowercase.Checked == true)
                this.txtResult.Text = fullname.ToLower();
            if (this.radUppercase.Checked == true)
                this.txtResult.Text = fullname.ToUpper();
        }

        private void button1_Click(object sender, EventArgs e){
            this.txtFullname.Clear();
            this.txtResult.Clear();
            this.radLowercase.Checked = true;
            this.txtFullname.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e){
            Application.Exit();
        }
    }
}
