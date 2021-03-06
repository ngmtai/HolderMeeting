﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BLL;
using BLL.Common;
using BLL.Model;
using DAL;
using UI.HolderMeetingDataSetTableAdapters;

namespace UI
{
    public partial class frmHolder_Vote : Form
    {
        public frmHolder_Vote()
        {
            InitializeComponent();
        }

        #region function

        void LoadStatusStrip()
        {
            var hb = new HolderBusiness();
            var hvb = new HolderVoteBusiness();
            var totalIsConfirm = hb.TotalConfirm(true);
            var totalShareIsConfirm = hb.TotalShareIsConfirm(true);
            var totalHolderVote = hvb.TotalHolderVote();
            var totalHolderShare = hvb.TotalShareIsVote();

            var str = totalHolderVote > 0 ?
                                        "Số cổ đông biểu quyết: " + string.Format("{0:#,###}", totalHolderVote) + "/" + string.Format("{0:#,###}", totalIsConfirm) + " =  " + Math.Round((decimal)totalHolderVote * 100 / totalIsConfirm, 2) + "%"
                                        : "Chưa có cổ đông biểu quyết";
            str += " | ";
            str += totalHolderShare > 0 ?
                                    "Số cổ phiếu biểu quyết: " + string.Format("{0:#,###}", totalHolderShare) + "/" + string.Format("{0:#,###}", totalShareIsConfirm) + " =  " + Math.Round((decimal)totalHolderShare * 100 / totalShareIsConfirm, 2) + "%"
                                    : "Chưa có cổ phiếu tham gia biểu quyết";
            tstt.Text = str;
        }

        void LoadData(string name, string code)
        {
            var holderBusiness = new HolderBusiness();
            var data = holderBusiness.GetAlls(name, code, true);
            var lstHolder = new List<HolderDto>();
            var vb = new VoteBusiness();
            var hvb = new HolderVoteBusiness();

            var countVote = vb.CountVoteIsActive();
            foreach (var holder in data)
            {
                var holderVote = hvb.CountVoteByHolder(holder.Id);
                lstHolder.Add(new HolderDto
                {
                    Id = holder.Id,
                    Code = holder.Code,
                    AuthorizerName = holder.AuthorizerName,
                    Name = holder.Name,
                    TotalShare = holder.TotalShare.HasValue ? string.Format("{0:#,###}", holder.TotalShare.Value) : "0",
                    UpdateDate = holder.UpdateDate.HasValue ? holder.UpdateDate.Value.ToShortDateString() : string.Empty,
                    CreateDate = holder.CreateDate.HasValue ? holder.CreateDate.Value.ToShortDateString() : string.Empty,
                    IsVote = holderVote >= countVote
                });
            }


            gridHolderVote.DataSource = lstHolder.OrderBy(t => t.IsVote);

            var lst = new List<HolderVoteDto>()
            {
                new HolderVoteDto()
                {
                    AnswerName = "aBc",
                    CreateDate = DateTime.Now,
                    TotalShared = 10,
                    VoteName = "def"
                },
                new HolderVoteDto()
                {
                    AnswerName = "aBc",
                    CreateDate = DateTime.Now,
                    TotalShared = 10,
                    VoteName = "def"
                }
            };

        }

        #endregion

        #region protected

        private void frmHolder_Vote_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(BoConstant.Config.ConnectionString))
            {
                MessageBox.Show("Chưa kết nối máy chủ", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            holderTableAdapter.Connection.ConnectionString = BoConstant.Config.ConnectionString;
            holder_VoteTableAdapter.Connection.ConnectionString = BoConstant.Config.ConnectionString;

            holderTableAdapter.Fill(holderMeetingDataSet.Holder);
            holder_VoteTableAdapter.Fill(holderMeetingDataSet.Holder_Vote);

            //LoadData(string.Empty, string.Empty);

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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(BoConstant.Config.ConnectionString))
            {
                MessageBox.Show("Chưa kết nối máy chủ", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            LoadData(txtSName.Text.Trim(), txtSCode.Text.Trim());
        }

        private void btnRowVote_Click(object sender, EventArgs e)
        {
            var dataRowView = (DataRowView)gvHolderVote.GetRow(gvHolderVote.FocusedRowHandle);
            var holder = dataRowView.Row.Table.Rows.Cast<HolderMeetingDataSet.HolderRow>().ToList()[0];

            var vb = new VoteBusiness();
            var hvb = new HolderVoteBusiness();

            if (holder != null && holder.Id > 0)
                if (hvb.CountVoteByHolder(holder.Id) < vb.CountVoteIsActive())
                {
                    var frmDialog = new HolderVoteDialog { _holderId = holder.Id };
                    var result = frmDialog.ShowDialog();
                    if (result == DialogResult.OK)
                        LoadData(txtSName.Text.Trim(), txtSCode.Text.Trim());
                }
                else
                    MessageBox.Show("Cổ đông \"" + holder.Name + "\" đã biểu quyết hoàn tất.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtSCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnSearch.PerformClick();
        }

        #endregion

    }
}