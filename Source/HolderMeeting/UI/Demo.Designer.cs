namespace UI
{
    partial class Demo
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTotalShare = new System.Windows.Forms.MaskedTextBox();
            this.txtAuthorizerName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvHolder = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHolder)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Số:";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(92, 12);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(176, 20);
            this.txtCode.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(92, 62);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(176, 20);
            this.txtName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(322, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số cổ phần:";
            // 
            // txtTotalShare
            // 
            this.txtTotalShare.Location = new System.Drawing.Point(418, 12);
            this.txtTotalShare.Mask = "00000";
            this.txtTotalShare.Name = "txtTotalShare";
            this.txtTotalShare.Size = new System.Drawing.Size(87, 20);
            this.txtTotalShare.TabIndex = 3;
            this.txtTotalShare.ValidatingType = typeof(int);
            // 
            // txtAuthorizerName
            // 
            this.txtAuthorizerName.Location = new System.Drawing.Point(418, 62);
            this.txtAuthorizerName.Name = "txtAuthorizerName";
            this.txtAuthorizerName.Size = new System.Drawing.Size(139, 20);
            this.txtAuthorizerName.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(322, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Người ủy quyền:";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(14, 101);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 6;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(120, 101);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(180, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Danh sách cổ đông tham gia đại hội";
            // 
            // dgvHolder
            // 
            this.dgvHolder.AllowUserToAddRows = false;
            this.dgvHolder.ColumnHeadersHeight = 30;
            this.dgvHolder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvHolder.Location = new System.Drawing.Point(12, 177);
            this.dgvHolder.Name = "dgvHolder";
            this.dgvHolder.Size = new System.Drawing.Size(545, 211);
            this.dgvHolder.TabIndex = 9;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "STT";
            this.Column5.Name = "Column5";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã số";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tên";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Số cổ phần";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Người đại diện";
            this.Column4.Name = "Column4";
            // 
            // Demo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 400);
            this.Controls.Add(this.dgvHolder);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.txtAuthorizerName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTotalShare);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.label1);
            this.Name = "Demo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "demo";
            this.Load += new System.EventHandler(this.Demo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHolder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox txtTotalShare;
        private System.Windows.Forms.TextBox txtAuthorizerName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvHolder;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}