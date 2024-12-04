using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace btb5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public List<employees> employee;

        private void Form1_Load(object sender, EventArgs e)
        {
            employee = new List<employees>();
            employee.Add(new employees() { MSNV="011",Name = "Ngyen Van a", LuongCB = 15615});
            employee.Add(new employees() { MSNV = "022", Name = "Nguyen Van b", LuongCB = 5000000 });
            dtgNhanVien.DataSource = employee;
        }
        public void RefreshGridView()
        {
            dtgNhanVien.DataSource = null;
            dtgNhanVien.DataSource = employee;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frm_nhanVien form2 = new frm_nhanVien(this);
            form2.ShowDialog();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dtgNhanVien.SelectedRows.Count > 0)
            {
                // Lấy nhân viên được chọn
                int index = dtgNhanVien.SelectedRows[0].Index;
                employees selectedEmployee = employee[index];

                frm_nhanVien form2 = new frm_nhanVien(this, selectedEmployee);
                form2.ShowDialog();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần sửa!", "Thông báo");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dtgNhanVien.SelectedRows.Count > 0)
            {
                int index = dtgNhanVien.SelectedRows[0].Index;
                employee.RemoveAt(index);
                RefreshGridView();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần xóa!", "Thông báo");
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
