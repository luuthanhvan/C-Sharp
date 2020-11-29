using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai04{
    public partial class FormCalculatingScore : Form{
        public FormCalculatingScore(){
            InitializeComponent();
        }

        private float min(float num1, float num2, float num3){
            float minVal = num1;
            if (num2 < minVal)
                minVal = num2;
            if (num3 < minVal)
                minVal = num3;
            return minVal;
        }

        private void btnCal_Click(object sender, EventArgs e){
            float mathScore = Convert.ToSingle(this.txtMathScore.Text);
            float literatureScore = Convert.ToSingle(this.txtLiteratureScore.Text);
            float engScore = Convert.ToSingle(this.txtEngScore.Text);
            
            // calculating min score
            float minScore = min(mathScore, literatureScore, engScore);

            // calculating bonus score
            float bonusScore = 0.0F;
            if (this.chkFemale.Checked)
                bonusScore = 0.5F;

            // calculating academic performance score
            float academicPerformanceScore = (mathScore * 2) + (literatureScore * 2) + engScore + bonusScore;

            // calculating achievement
            string achievement;
            if (academicPerformanceScore >= 40 && minScore >= 7)
                achievement = "Giỏi";
            else
                if (academicPerformanceScore >= 35 && minScore >= 6)
                    achievement = "Khá";
                else
                    if (academicPerformanceScore >= 25 && minScore >= 5)
                        achievement = "Trung bình";
                    else
                        achievement = "Yếu";

            // show the results
            this.txtLowScore.Text = minScore.ToString();
            this.txtBonusScore.Text = bonusScore.ToString();
            this.txtAcademicPerformance.Text = academicPerformanceScore.ToString();
            this.txtAchievement.Text = achievement;
        }

        private void btnClear_Click(object sender, EventArgs e){
            this.txtFullname.Clear();
            if (this.chkFemale.Checked)
                this.chkFemale.Checked = false;
            else
                this.chkMale.Checked = false;
            this.txtMathScore.Clear();
            this.txtLiteratureScore.Clear();
            this.txtEngScore.Clear();
            this.txtLowScore.Clear();
            this.txtBonusScore.Clear();
            this.txtAcademicPerformance.Clear();
            this.txtAchievement.Clear();
            this.txtFullname.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e){
            DialogResult reply = MessageBox.Show("Bạn muốn thoát chương trình?", "Chương trình tính điểm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (reply == DialogResult.Yes)
                Application.Exit();
        }

        private void btnGoBack_Click(object sender, EventArgs e){
            this.Close();
        }
    }
}
