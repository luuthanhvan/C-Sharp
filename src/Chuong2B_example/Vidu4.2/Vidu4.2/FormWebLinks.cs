using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vidu4._2{
    public partial class FormWebLinks : Form{
        public FormWebLinks(){
            InitializeComponent();
        }

        private void FormWebLinks_Load(object sender, EventArgs e){
            this.cbWebs.Items.Add("Tuổi trẻ");
            this.cbWebs.Items.Add("Thanh niên");
            this.cbWebs.Items.Add("VNExpress");
            this.cbWebs.Items.Add("Dân trí");
            this.cbWebs.Items.Add("Công an");
            this.cbWebs.SelectedItem = "Tuổi trẻ";
        }

        private void btnOk_Click(object sender, EventArgs e){
            this.txtResult.Text = "Bạn đã chọn website ";
            this.txtResult.Text += this.cbWebs.SelectedItem;
        }

        private void btnReset_Click(object sender, EventArgs e){
            this.txtResult.ResetText();
        }
    }
}
