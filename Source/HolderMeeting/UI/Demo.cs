using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BLL;
using DAL;

namespace UI
{
    public partial class Demo : Form
    {
        public Demo()
        {
            InitializeComponent();
        }

        private void Demo_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            decimal totalShare;
            decimal.TryParse(txtTotalShare.Text, out totalShare);

            if (string.IsNullOrEmpty(txtCode.Text) || string.IsNullOrEmpty(txtName.Text) ||
                string.IsNullOrEmpty(txtAuthorizerName.Text) || totalShare <= 0)
            {
                MessageBox.Show("Error", "Chưa nhập đủ thông tin.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var holder = new Holder()
            {
                Code = txtCode.Text.Trim(),
                Name = txtName.Text.Trim(),
                TotalShare = totalShare,
                AuthorizerName = txtAuthorizerName.Text.Trim(),
                IsActive = true,
                CreateDate = DateTime.Now,
                CreateUser = "Admin"
            };

            var holderBusiness = new HolderBusiness();
            var id = holderBusiness.Save(holder);
            if (id > 0)
            {
                MessageBox.Show("Thông báo", "Lưu thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
            }
        }

        #region function

        void ClearForm()
        {
            txtTotalShare.Clear();
            txtName.Clear();
            txtCode.Clear();
            txtAuthorizerName.Clear();

            txtCode.Focus();
        }

        private void LoadData()
        {
            dgvHolder.Rows.Clear();
            var holderBusiness = new HolderBusiness();
            var data = holderBusiness.GetAlls(string.Empty, string.Empty);

            if (data.Any())
                for (var i = 0; i < data.Count; i++)
                    dgvHolder.Rows.Add(i + 1, data[i].Code, data[i].Name, data[i].TotalShare, data[i].AuthorizerName);
        }

        #endregion

    }
}
