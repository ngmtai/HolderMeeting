namespace UI
{
    partial class HolderVoteDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.lblCode = new DevExpress.XtraEditors.LabelControl();
            this.lblName = new DevExpress.XtraEditors.LabelControl();
            this.lblAuthorizer = new DevExpress.XtraEditors.LabelControl();
            this.lblTotalShared = new DevExpress.XtraEditors.LabelControl();
            this.lblCurrentShared = new DevExpress.XtraEditors.LabelControl();
            this.btnVote = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.groupControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(866, 136);
            this.panelControl1.TabIndex = 0;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.groupControl2);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 136);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(866, 361);
            this.panelControl2.TabIndex = 1;
            // 
            // groupControl1
            // 
            this.groupControl1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.groupControl1.Appearance.Options.UseBackColor = true;
            this.groupControl1.Controls.Add(this.btnCancel);
            this.groupControl1.Controls.Add(this.btnVote);
            this.groupControl1.Controls.Add(this.lblCurrentShared);
            this.groupControl1.Controls.Add(this.lblTotalShared);
            this.groupControl1.Controls.Add(this.lblAuthorizer);
            this.groupControl1.Controls.Add(this.lblName);
            this.groupControl1.Controls.Add(this.lblCode);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(2, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(862, 132);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Chi tiết";
            // 
            // groupControl2
            // 
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(2, 2);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(862, 357);
            this.groupControl2.TabIndex = 0;
            this.groupControl2.Text = "Biểu quyết";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(10, 34);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(62, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Mã cổ đông: ";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(10, 64);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(66, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Tên cổ đông: ";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(10, 97);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(80, 13);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Người ủy quyền:";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(349, 34);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(85, 13);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "Tổng số cổ phiếu:";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(349, 64);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(92, 13);
            this.labelControl5.TabIndex = 4;
            this.labelControl5.Text = "Số cổ phiếu còn lại:";
            // 
            // lblCode
            // 
            this.lblCode.Location = new System.Drawing.Point(102, 34);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(25, 13);
            this.lblCode.TabIndex = 5;
            this.lblCode.Text = "Code";
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(102, 64);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(27, 13);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "Name";
            // 
            // lblAuthorizer
            // 
            this.lblAuthorizer.Location = new System.Drawing.Point(102, 97);
            this.lblAuthorizer.Name = "lblAuthorizer";
            this.lblAuthorizer.Size = new System.Drawing.Size(50, 13);
            this.lblAuthorizer.TabIndex = 7;
            this.lblAuthorizer.Text = "Authorizer";
            // 
            // lblTotalShared
            // 
            this.lblTotalShared.Location = new System.Drawing.Point(464, 34);
            this.lblTotalShared.Name = "lblTotalShared";
            this.lblTotalShared.Size = new System.Drawing.Size(58, 13);
            this.lblTotalShared.TabIndex = 8;
            this.lblTotalShared.Text = "TotalShared";
            // 
            // lblCurrentShared
            // 
            this.lblCurrentShared.Location = new System.Drawing.Point(464, 64);
            this.lblCurrentShared.Name = "lblCurrentShared";
            this.lblCurrentShared.Size = new System.Drawing.Size(71, 13);
            this.lblCurrentShared.TabIndex = 9;
            this.lblCurrentShared.Text = "CurrentShared";
            // 
            // btnVote
            // 
            this.btnVote.Location = new System.Drawing.Point(664, 34);
            this.btnVote.Name = "btnVote";
            this.btnVote.Size = new System.Drawing.Size(99, 32);
            this.btnVote.TabIndex = 10;
            this.btnVote.Text = "Biểu quyết";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(664, 78);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(99, 32);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Hủy";
            // 
            // HolderVoteDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 497);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "HolderVoteDialog";
            this.Text = "Biểu quyết";
            this.Load += new System.EventHandler(this.HolderVoteDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnVote;
        private DevExpress.XtraEditors.LabelControl lblCurrentShared;
        private DevExpress.XtraEditors.LabelControl lblTotalShared;
        private DevExpress.XtraEditors.LabelControl lblAuthorizer;
        private DevExpress.XtraEditors.LabelControl lblName;
        private DevExpress.XtraEditors.LabelControl lblCode;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.GroupControl groupControl2;
    }
}