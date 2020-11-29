using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai02{
    public partial class FormLoop : Form{
        public FormLoop(){
            InitializeComponent();
        }
        int maxNumber(int num1, int num2){
            return num1 > num2 ? num1 : num2;
        }

        int[] findCommonDivisors(int n, int m){
            int maxVal = maxNumber(n, m);
            int[] commonDivisors = new int[maxVal];
            int cnt = 0;
            for(int i = 1; i <= maxVal; i++){
                if ((n % i == 0) && (m % i == 0)){
                    commonDivisors[cnt++] = i;
                }
            }
            return commonDivisors;
        }
        // greatest common divisor
        int gcd(int a, int b){
            if (b == 0)
                return a;
            else
                return gcd(b, a % b);
        }
        private void btnCal_Click(object sender, EventArgs e){
            int n = Convert.ToInt32(this.txtn.Text);
            int m = Convert.ToInt32(this.txtm.Text);
            if (this.radCD.Checked == true){
                int[] commondDivisors = findCommonDivisors(n, m);
                string result = "";
                foreach (int i in commondDivisors){
                    if (i != 0)
                        result += (i.ToString() + ", ");
                }
                result = result.Remove(result.Length-2, 2); // remove ", " of the last string
                this.txtResult.Text = result;
            }
            if(this.radGCD.Checked == true){
                int gcdVal = gcd(n, m);
                this.txtResult.Text = gcdVal.ToString();
            }
        }

        private void btnClear_Click(object sender, EventArgs e){
            this.txtm.Clear();
            this.txtn.Clear();
            this.txtResult.Clear();
            this.radCD.Checked = true;
            this.txtn.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e){
            Application.Exit();
        }
    }
}
