using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Vidu10._1{
    public partial class FormShowDataListBox : Form{
        // chuỗi kết nối
        string strConnectionString = "Data Source=P17M02;Initial Catalog=QuanLyBanHang;Integrated Security=True";
        SqlConnection conn = null; // đối tượng kết nối
        SqlDataAdapter daCity = null; // đối tượng đưa dữ liệu vào data table
        DataTable dtCity = null; // đối tượng hiển thị dữ liệu lên ListBox

        public FormShowDataListBox(){
            InitializeComponent();
        }

        private void FormShowDataListBox_Load(object sender, EventArgs e){
            try{
                // khởi tạo kết nối đến CSDL
                conn = new SqlConnection(strConnectionString);
                // vận chuyển dữ liệu lên data table
                daCity = new SqlDataAdapter("SELECT * FROM THANHPHO", conn);
                dtCity = new DataTable();
                dtCity.Clear();
                daCity.Fill(dtCity);
                // hiển thị dữ liệu lên ListBox
                this.lstCity.DataSource = dtCity;
                this.lstCity.DisplayMember = "TenThanhPho";
                this.lstCity.ValueMember = "ThanhPho";
            }
            catch (SqlException){
                MessageBox.Show("Lỗi kết nối đến CSDL: Không lấy được nội dung trong bảng THANHPHO");
            }
        }

        private void FormShowDataListBox_FormClosing(object sender, FormClosingEventArgs e){
            // giải phóng tài nguyên
            dtCity.Dispose();
            dtCity = null;
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
