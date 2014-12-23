namespace UI
{
    partial class frmHolder_Vote
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
            this.gridHolderVote = new DevExpress.XtraGrid.GridControl();
            this.gvHolderVote = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.stTotal = new System.Windows.Forms.StatusStrip();
            this.tstt = new System.Windows.Forms.ToolStripStatusLabel();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.txtSName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtSCode = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridHolderVote)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvHolderVote)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.stTotal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSCode.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridHolderVote
            // 
            this.gridHolderVote.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridHolderVote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridHolderVote.Location = new System.Drawing.Point(2, 2);
            this.gridHolderVote.MainView = this.gvHolderVote;
            this.gridHolderVote.Name = "gridHolderVote";
            this.gridHolderVote.Size = new System.Drawing.Size(788, 374);
            this.gridHolderVote.TabIndex = 0;
            this.gridHolderVote.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvHolderVote});
            // 
            // gvHolderVote
            // 
            this.gvHolderVote.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn9});
            this.gvHolderVote.GridControl = this.gridHolderVote;
            this.gvHolderVote.Name = "gvHolderVote";
            this.gvHolderVote.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvHolderVote.OptionsBehavior.Editable = false;
            this.gvHolderVote.OptionsCustomization.AllowGroup = false;
            this.gvHolderVote.OptionsView.ShowGroupPanel = false;
            this.gvHolderVote.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gvHolder_RowClick);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Mã cổ đông";
            this.gridColumn1.FieldName = "Code";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Tên";
            this.gridColumn2.FieldName = "Name";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Số lượng cổ phiếu";
            this.gridColumn3.FieldName = "TotalShare";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Người ủy quyền";
            this.gridColumn4.FieldName = "AuthorizerName";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Tham dự?";
            this.gridColumn5.FieldName = "IsConfirm";
            this.gridColumn5.Name = "gridColumn5";
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Ngày cập nhật";
            this.gridColumn6.FieldName = "UpdateDate";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 5;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Id";
            this.gridColumn7.FieldName = "Id";
            this.gridColumn7.Name = "gridColumn7";
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "CreateDate";
            this.gridColumn8.FieldName = "CreateDate";
            this.gridColumn8.Name = "gridColumn8";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.stTotal);
            this.panelControl1.Controls.Add(this.gridHolderVote);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 114);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(792, 378);
            this.panelControl1.TabIndex = 1;
            // 
            // stTotal
            // 
            this.stTotal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tstt});
            this.stTotal.Location = new System.Drawing.Point(2, 354);
            this.stTotal.Name = "stTotal";
            this.stTotal.Size = new System.Drawing.Size(788, 22);
            this.stTotal.TabIndex = 1;
            this.stTotal.Text = "aBc";
            // 
            // tstt
            // 
            this.tstt.Name = "tstt";
            this.tstt.Size = new System.Drawing.Size(26, 17);
            this.tstt.Text = "aBc";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.groupControl1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(792, 108);
            this.panelControl2.TabIndex = 2;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnSearch);
            this.groupControl1.Controls.Add(this.txtSName);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.txtSCode);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(2, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(788, 104);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Tìm kiếm";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(676, 34);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(82, 38);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Tìm";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSName
            // 
            this.txtSName.Location = new System.Drawing.Point(431, 43);
            this.txtSName.Name = "txtSName";
            this.txtSName.Size = new System.Drawing.Size(194, 20);
            this.txtSName.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(353, 46);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(63, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Tên cổ đông:";
            // 
            // txtSCode
            // 
            this.txtSCode.Location = new System.Drawing.Point(99, 43);
            this.txtSCode.Name = "txtSCode";
            this.txtSCode.Size = new System.Drawing.Size(204, 20);
            this.txtSCode.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(11, 46);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(59, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Mã cổ đông:";
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "Biểu quyết?";
            this.gridColumn9.FieldName = "IsVote";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 4;
            // 
            // frmHolder_Vote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 492);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "frmHolder_Vote";
            this.Text = "Danh sách cổ đông biểu quyết";
            this.Load += new System.EventHandler(this.frmHolder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridHolderVote)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvHolderVote)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.stTotal.ResumeLayout(false);
            this.stTotal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSCode.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridHolderVote;
        private DevExpress.XtraGrid.Views.Grid.GridView gvHolderVote;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private DevExpress.XtraEditors.TextEdit txtSName;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtSCode;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private System.Windows.Forms.StatusStrip stTotal;
        private System.Windows.Forms.ToolStripStatusLabel tstt;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;

    }
}