using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Vidu10._3{
    public partial class FormShowDataGridViewComboBox : Form{
        string strConnectionString = "Data Source=P17M02;Initial Catalog=QuanLyBanHang;Integrated Security=True";
        SqlConnection conn = null;
        SqlDataAdapter daCustomer = null;
        SqlDataAdapter daCity = null;
        DataTable dtCustomer = null;
        DataTable dtCity = null;

        public FormShowDataGridViewComboBox(){
            InitializeComponent();
        }

        void LoadData(){
            try{
                conn = new SqlConnection(strConnectionString);
                daCity = new SqlDataAdapter("SELECT * FROM THANHPHO", conn);
                dtCity = new DataTable();
                dtCity.Clear();
                daCity.Fill(dtCity);
                // đưa dữ liệu lên ComboBox trong DataGridView
                (this.dgvCustomer.Columns["ThanhPho"] as DataGridViewComboBoxColumn).DataSource = dtCity;
                (this.dgvCustomer.Columns["ThanhPho"] as DataGridViewComboBoxColumn).DisplayMember = "TenThanhPho";
                (this.dgvCustomer.Columns["ThanhPho"] as DataGridViewComboBoxColumn).ValueMember = "ThanhPho";

                daCustomer = new SqlDataAdapter("SELECT * FROM KHACHHANG", conn);
                dtCustomer = new DataTable();
                dtCustomer.Clear();
                daCustomer.Fill(dtCustomer);
                // đưa dữ liệu vào các TextBox trong DataGridView
                this.dgvCustomer.DataSource = dtCustomer;
            }
            catch (SqlException){
                MessageBox.Show("Lỗi kết nối đến CSDL: Không lấy được nội dung trong bảng KHACHHANG");
            }
        }

        private void FormShowDataGridViewComboBox_Load(object sender, EventArgs e){
            //LoadData();
        }

        private void btnReload_Click(object sender, EventArgs e){
            LoadData();
        }

        private void btnExit_Click(object sender, EventArgs e){
            // khai báo biến trả lời
            DialogResult reply;
            // hiển trị hộp thoại hỏi đáp
            reply = MessageBox.Show("Bạn muốn thoát chương trình?", "Trả lời", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            // kiểm tra có nhấn Yes hay không
            if (reply == DialogResult.Yes)
                Application.Exit();
        }

        private void FormShowDataGridViewComboBox_FormClosing(object sender, FormClosingEventArgs e){
            // giải phóng tài nguyên
            dtCustomer.Dispose();
            dtCustomer = null;
            // hủy kết nối
            conn = null;
        }
    }
}
