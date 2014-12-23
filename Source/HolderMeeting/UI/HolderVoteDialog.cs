using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BLL;
using DevExpress.XtraEditors;

namespace UI
{
    public partial class HolderVoteDialog : Form
    {
        public HolderVoteDialog()
        {
            InitializeComponent();
        }

        #region variables

        public int _holderId;
        private decimal _currentShared;

        #endregion

        #region function

        void LoadDetail(int holderId)
        {
            var hb = new HolderBusiness();
            var detail = hb.Detail(holderId);

            if (detail != null && detail.Id > 0)
            {
                lblCode.Text = detail.Code;
                lblName.Text = detail.Name;
                lblAuthorizer.Text = detail.AuthorizerName;
                lblTotalShared.Text = detail.TotalShare.HasValue ? detail.TotalShare.Value > 0 ? string.Format("{0:#,###}", detail.TotalShare.Value) : "0" : "0";

                var hvb = new HolderVoteBusiness();
                var shareIsVote = hvb.TotalSharedIsVote(detail.Id);

                _currentShared = detail.TotalShare.HasValue ? detail.TotalShare.Value - shareIsVote : 0;
                lblCurrentShared.Text = _currentShared > 0 ? string.Format("{0:#,###}", _currentShared) : "0";
            }
        }

        void LoadForm()
        {
            var lblVote = new LabelControl
            {
                Location = new Point(10, 45),
                Name = "lblVote1",
                Size = new Size(44, 13),
                TabIndex = 3,
                Text = "1. Vote 1"
            };

            var rad = new RadioGroup { Location = new Point(lblVote.Location.X + 20, lblVote.Location.Y + 20), Name = "rad1" };
            rad.Properties.Items.AddRange(new[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(((short)(1)), "Đồng ý"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(((short)(0)), "Không đồng ý"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(((short)(2)), "Ý kiến khác")});
            rad.Size = new Size(396, 38);

            var mtb = new MaskedTextBox
            {
                Location = new Point(rad.Location.X + 120, rad.Location.Y + 60),
                Mask = "000,000,000,000",
                Name = "mtb1",
                Size = new Size(90, 20),
                TabIndex = 9
            };

            var labelControl = new LabelControl
            {
                Location = new Point(rad.Location.X, rad.Location.Y + 60),
                Name = "labelControl6",
                Size = new Size(113, 13),
                TabIndex = 7,
                Text = "Số cổ phiếu biểu quyết:"
            };


            groupControl2.Controls.Add(lblVote);
            groupControl2.Controls.Add(rad);
            groupControl2.Controls.Add(mtb);
            groupControl2.Controls.Add(labelControl);



        }

        #endregion

        private void HolderVoteDialog_Load(object sender, EventArgs e)
        {
            LoadDetail(_holderId);
            LoadForm();
        }
    }
}
