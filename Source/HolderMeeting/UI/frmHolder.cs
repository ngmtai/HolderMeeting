﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BLL;
using BLL.Model;
using DAL;

namespace UI
{
    public partial class frmHolder : Form
    {
        private int _id;

        public frmHolder()
        {
            InitializeComponent();
        }

        #region function

        void ClearForm()
        {
            txtAuthorizerName.Text = lblTotalShare.Text = lblCreateDate.Text = lblName.Text = lblCode.Text = string.Empty;
            chkIsConfirm.Checked = false;
            btnChange.Enabled = false;
        }

        void LoadStatusStrip()
        {
            var hb = new HolderBusiness();
            var totalIsConfirm = hb.TotalConfirm(true);
            var totalConfirm = hb.TotalConfirm(null);
            var totalShareIsConfirm = hb.TotalShareIsConfirm(true);
            var totalShare = hb.TotalShareIsConfirm(null);

            var str = "Số cổ đông tham gia: " + string.Format("{0:#,###}", totalIsConfirm) + "/" + string.Format("{0:#,###}", totalConfirm) + " =  " + Math.Round((decimal)totalIsConfirm * 100 / totalConfirm, 2) + "% | Tổng số cổ phiếu tham gia: " +
                       string.Format("{0:#,###}", totalShareIsConfirm) + "/" + string.Format("{0:#,###}", totalShare) + " =  " + Math.Round((decimal)totalShareIsConfirm * 100 / totalShare, 2) + "%";
            tstt.Text = str;
        }

        void LoadData(string name, string code)
        {
            var holderBusiness = new HolderBusiness();
            var data = holderBusiness.GetAlls(name, code);
            var lstHolder = new List<HolderDto>();
            foreach (var holder in data)
            {
                lstHolder.Add(new HolderDto
                {
                    Id = holder.Id,
                    Code = holder.Code,
                    AuthorizerName = holder.AuthorizerName,
                    Name = holder.Name,
                    TotalShare = holder.TotalShare.HasValue ? string.Format("{0:#,###}", holder.TotalShare.Value) : "0",
                    UpdateDate = holder.UpdateDate.HasValue ? holder.UpdateDate.Value.ToShortDateString() : string.Empty,
                    CreateDate = holder.CreateDate.HasValue ? holder.CreateDate.Value.ToShortDateString() : string.Empty,
                    IsConfirm = holder.IsConfirm != null && holder.IsConfirm.Value
                });
            }
            gridHolder.DataSource = lstHolder;

            ClearForm();
        }

        #endregion

        #region protected

        private void frmHolder_Load(object sender, EventArgs e)
        {
            LoadData(string.Empty, string.Empty);

            #region autocomplete

            var txtCode = txtSCode.MaskBox;

            var hb = new HolderBusiness();

            var customSourceCode = new AutoCompleteStringCollection();
            customSourceCode.AddRange(hb.GetAllsCode().ToArray());

            txtCode.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtCode.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtCode.AutoCompleteCustomSource = customSourceCode;


            var txtName = txtSName.MaskBox;

            var customSourceName = new AutoCompleteStringCollection();
            customSourceName.AddRange(hb.GetAllsName().ToArray());

            txtName.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtName.AutoCompleteCustomSource = customSourceName;

            #endregion

            LoadStatusStrip();
        }

        private void gvHolder_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (e.RowHandle >= 0)
            {
                var holder = (HolderDto)gvHolder.GetRow(e.RowHandle);

                if (holder != null && holder.Id > 0)
                {
                    _id = holder.Id;

                    lblCode.Text = holder.Code;
                    lblName.Text = holder.Name;
                    lblTotalShare.Text = holder.TotalShare;
                    lblCreateDate.Text = holder.CreateDate;
                    chkIsConfirm.Checked = holder.IsConfirm;
                    txtAuthorizerName.Text = holder.AuthorizerName;

                    if (_id > 0)
                        btnChange.Enabled = true;
                }
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (_id > 0)
            {
                if (
                    MessageBox.Show("Bạn có chắc không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                    DialogResult.Yes)
                {
                    var model = new Holder
                    {
                        Id = _id,
                        IsConfirm = chkIsConfirm.Checked,
                        AuthorizerName = txtAuthorizerName.Text.Trim()
                    };

                    var hb = new HolderBusiness();
                    if (hb.UpdateHolder(model))
                    {
                        MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK);
                        LoadData(txtSName.Text.Trim(), txtSCode.Text.Trim());

                        LoadStatusStrip();
                    }
                    else
                        MessageBox.Show("Lỗi. Thử lại sau", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else MessageBox.Show("Chưa chọn item", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadData(txtSName.Text.Trim(), txtSCode.Text.Trim());
        }

        #endregion

    }
}