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

namespace UI
{
    public partial class frmHolder : Form
    {
        public frmHolder()
        {
            InitializeComponent();
        }

        #region function

        private void LoadData()
        {
            var holderBusiness = new HolderBusiness();
            var data = holderBusiness.GetAlls();
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
                    UpdateDate = holder.UpdateDate.HasValue ? holder.UpdateDate.Value.ToShortDateString() : string.Empty
                });
            }
            gridHolder.DataSource = lstHolder;
        }

        #endregion

        private void frmHolder_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
