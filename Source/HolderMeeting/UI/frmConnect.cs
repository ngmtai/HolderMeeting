using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BLL.Common;

namespace UI
{
    public partial class frmConnect : Form
    {
        public frmConnect()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIp.Text.Trim()))
            {
                MessageBox.Show("Phải nhập đỉa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtIp.Focus();
                return;
            }

            if (!string.IsNullOrEmpty(txtUser.Text.Trim()) && !string.IsNullOrEmpty(txtPass.Text.Trim()))
                BoConstant.Config.ConnectionString = string.Format(BoConstant.Config.ConnectionString, txtIp.Text, string.Format(BoConstant.Config.ConnectionAuthorize, txtUser.Text.Trim(), txtPass.Text.Trim()));
            else
                BoConstant.Config.ConnectionString = string.Format(BoConstant.Config.ConnectionString, txtIp.Text, BoConstant.Config.ConnectionNonAuthor);

            MessageBox.Show(BoCommon.IsConnect() ? "Kết nối thành công" : "Không kết nối được. Thử lại sau", "Thông báo",
                MessageBoxButtons.OK);
        }
    }
}
