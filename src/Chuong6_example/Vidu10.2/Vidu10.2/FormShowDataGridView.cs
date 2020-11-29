using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Vidu10._2{
    public partial class FormShowDataGridView : Form{
        string strConnectionString = "Data Source=P17M02;Initial Catalog=QuanLyBanHang;Integrated Security=True";
        SqlConnection conn = null;
        SqlDataAdapter daCustomer = null;
        DataTable dtCustomer = null;
                
        public FormShowDataGridView(){
            InitializeComponent();
        }

        private void FormShowDataGridView_Load(object sender, EventArgs e){
            try{
                conn = new SqlConnection(strConnectionString);
                daCustomer = new SqlDataAdapter("SELECT * FROM KHACHHANG", conn);
                dtCustomer = new DataTable();
                dtCustomer.Clear();
                daCustomer.Fill(dtCustomer);
                // đưa dữ liệu lên DataGridView
                this.dgvCustomer.DataSource = dtCustomer;
            }
            catch (SqlException){
                MessageBox.Show("Lỗi kết nối đến CSDL: Không lấy được nội dung trong bảng KHACHHANG");
            }

        }

        private void FormShowDataGridView_FormClosing(object sender, FormClosingEventArgs e){
            // giải phóng tài nguyên
            dtCustomer.Dispose();
            dtCustomer = null;
            // hủy kết nối
            conn = null;
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
    }
}
