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
using DevExpress.XtraEditors;
using UI.Common;

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
        private int _loY;

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

        void RenderVote(int index, int id, string voteName)
        {
            if (_loY <= 0)
                _loY = 45;
            const int loX = 10;
            var loY = _loY;

            var lblVote = new LabelControl
            {
                Location = new Point(loX, loY),
                Size = new Size(44, 13),
                Text = index + ". " + voteName
            };

            var groupBox = new GroupBox();
            var radYes = new RadioButton();
            var radNo = new RadioButton();
            var radOther = new RadioButton();

            radYes.AutoSize = true;
            radYes.Location = new Point(loX + 30, 20);
            radYes.Name = "rad" + id + "Yes";
            radYes.Size = new Size(85, 17);
            radYes.TabIndex = id * 10 + 1;
            radYes.TabStop = true;
            radYes.Text = "Đồng ý";
            radYes.UseVisualStyleBackColor = true;
            radYes.CheckedChanged += rad_CheckedChanged;

            radNo.AutoSize = true;
            radNo.Location = new Point(loX + 100, 20);
            radNo.Name = "rad" + id + "No";
            radNo.Size = new Size(85, 17);
            radNo.TabIndex = id * 10 + 2;
            radNo.TabStop = true;
            radNo.Text = "Không đồng ý";
            radNo.UseVisualStyleBackColor = true;
            radNo.CheckedChanged += rad_CheckedChanged;

            radOther.AutoSize = true;
            radOther.Location = new Point(loX + 200, 20);
            radOther.Name = "rad" + id + "Other";
            radOther.Size = new Size(85, 17);
            radOther.TabIndex = id * 10 + 3;
            radOther.TabStop = true;
            radOther.Text = "Ý kiến khác";
            radOther.UseVisualStyleBackColor = true;
            radOther.CheckedChanged += radOther_CheckedChanged;

            var txt = new TextBox
            {
                Location = new Point(loX + 300, 20),
                Name = "txt" + id + "Other",
                Size = new Size(250, 20),
                TabIndex = id * 10 + 4,
                Enabled = false
            };

            groupBox.Controls.Add(radYes);
            groupBox.Controls.Add(radNo);
            groupBox.Controls.Add(radOther);
            groupBox.Controls.Add(txt);
            groupBox.Location = new Point(loX + 30, loY + 20);
            groupBox.Name = "gb" + id;
            groupBox.Size = new Size(600, 60);
            groupBox.TabIndex = 0;
            groupBox.TabStop = false;
            groupBox.Text = "";

            var labelControl = new LabelControl
            {
                Location = new Point(loX + 30, loY + groupBox.Size.Height + 40),
                Size = new Size(113, 13),
                Text = "Số cổ phiếu biểu quyết:"
            };

            var mtb = new MaskedTextBox
            {
                Location = new Point(loX + 140, loY + groupBox.Size.Height + 40),
                Mask = "000,000,000,000",
                Name = "mtb" + id,
                Size = new Size(90, 20),
                TabIndex = id * 10 + 5
            };

            _loY = mtb.Location.Y + 30;

            gcVote.Controls.Add(lblVote);
            gcVote.Controls.Add(groupBox);
            gcVote.Controls.Add(mtb);
            gcVote.Controls.Add(labelControl);
        }

        void rad_CheckedChanged(object sender, EventArgs e)
        {
            var rad = (RadioButton)sender;
            var txt = (TextBox)Controls.Find(rad.Name.Replace("rad", "txt").Replace("Yes", "Other").Replace("No", "Other"), true)[0];

            txt.Enabled = false;
            txt.Text = string.Empty;
        }

        void radOther_CheckedChanged(object sender, EventArgs e)
        {
            var rad = (RadioButton)sender;
            var txt = (TextBox)Controls.Find(rad.Name.Replace("rad", "txt"), true)[0];

            txt.Enabled = true;
        }

        #endregion

        private void HolderVoteDialog_Load(object sender, EventArgs e)
        {
            LoadDetail(_holderId);
            var vb = new VoteBusiness();
            var votes = vb.GetAlls(true);
            if (votes.Any())
                for (var i = 0; i < votes.Count; i++)
                    RenderVote(i + 1, votes[i].Id, votes[i].DisplayName);
        }

        private void btnVote_Click(object sender, EventArgs e)
        {
            var lstHolderVote = new List<Holder_Vote>();
            var vb = new VoteBusiness();
            var votes = vb.GetAlls(true);
            if (votes.Any())
                for (var i = 0; i < votes.Count; i++)
                {
                    var holderVote = new Holder_Vote();
                    var radYes = (RadioButton)Controls.Find("rad" + votes[i].Id + "Yes", true)[0];
                    if (radYes.Checked)
                        holderVote.AnswerType = (int)MyConstant.AnswerType.Yes;
                    var radNo = (RadioButton)Controls.Find("rad" + votes[i].Id + "No", true)[0];
                    if (radNo.Checked)
                        holderVote.AnswerType = (int)MyConstant.AnswerType.No;

                    var radOther = (RadioButton)Controls.Find("rad" + votes[i].Id + "Other", true)[0];
                    if (radOther.Checked)
                    {
                        holderVote.AnswerType = (int)MyConstant.AnswerType.Other;
                        var txt = (TextBox)Controls.Find("txt" + votes[i].Id + "Other", true)[0];

                        holderVote.AnswerName = txt.Text.Trim();
                    }

                    var mtb = (MaskedTextBox)Controls.Find("mtb" + votes[i].Id, true)[0];
                    holderVote.TotalShare = decimal.Parse(mtb.Text);

                    holderVote.VoteId = votes[i].Id;
                    holderVote.IsActive = true;
                    holderVote.CreateDate = DateTime.Now;

                    lstHolderVote.Add(holderVote);
                }
        }
    }
}
