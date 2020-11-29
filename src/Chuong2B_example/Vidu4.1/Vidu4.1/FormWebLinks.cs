using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vidu4._1{
    public partial class FormWebLinks : Form{
        public FormWebLinks(){
            InitializeComponent();
        }

        private void FormWebLinks_Load(object sender, EventArgs e){
            this.lstWebs.Items.Add("Tuổi trẻ");
            this.lstWebs.Items.Add("Thanh niên");
            this.lstWebs.Items.Add("VNExpress");
            this.lstWebs.Items.Add("Dân trí");
            this.lstWebs.Items.Add("Công an");
            this.lstWebs.SelectedItem = "Tuổi trẻ";
        }

        private void btnOk_Click(object sender, EventArgs e){
            this.txtResult.Text = "Bạn đã chọn website ";
            this.txtResult.Text += this.lstWebs.SelectedItem.ToString();
        }

        private void btnReset_Click(object sender, EventArgs e){
            this.txtResult.ResetText();
        }
    }
}
