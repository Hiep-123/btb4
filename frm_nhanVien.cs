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
    public partial class frm_nhanVien : Form
    {
        private Form1 form1s;
        private employees employees;
        public frm_nhanVien(Form1 form1, employees employee = null)
        {
            InitializeComponent();
            form1s = form1;
            employees = employee;

            if (employees != null)
            {          
                txtMSNV.Text = employee.MSNV;
                txtTen.Text = employee.Name;
                txtLuong.Text = employee.LuongCB.ToString();
            }
        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            if (employees == null) 
            {
                employees newEmployee = new employees
                {
                    MSNV = txtMSNV.Text,
                    Name = txtTen.Text,
                    LuongCB = double.Parse(txtLuong.Text)
                };

                form1s.employee.Add(newEmployee); 
            }
            else // Trường hợp sửa
            {
                employees.MSNV = txtMSNV.Text;
                employees.Name = txtTen.Text;
                employees.LuongCB = double.Parse(txtLuong.Text);
            }

            form1s.RefreshGridView(); 
            this.Close(); 
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

    }
}
