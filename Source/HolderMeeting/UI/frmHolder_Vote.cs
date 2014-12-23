using System;
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
            var data = holderBusiness.GetAlls(name, code);
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
                var holder = (HolderDto)gvHolderVote.GetRow(e.RowHandle);

                if (holder != null && holder.Id > 0)
                {
                    var hvb = new HolderVoteBusiness();
                    var vb = new VoteBusiness();

                    if (hvb.CountVoteByHolder(holder.Id) <= vb.CountVoteIsActive())
                    {
                        var frmDialog = new HolderVoteDialog {_holderId = holder.Id};
                        var result = frmDialog.ShowDialog();
                        if (result == DialogResult.OK)
                        {
                            
                        }
                    }
                    else
                        MessageBox.Show("Cổ đông \"" + holder.Name + "\" đã biểu quyết hoàn tất.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadData(txtSName.Text.Trim(), txtSCode.Text.Trim());
        }

        #endregion

    }
}