using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NewTestCK
{
    public partial class Main : System.Web.UI.MasterPage
    {
        LopKetNoi ketnoi = new LopKetNoi();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) return;
            string sql = "select * from HangSX";

            DataList1.DataSource = ketnoi.laydulieu(sql);
            DataList1.DataBind();
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            string madanhmuc = ((LinkButton)sender).CommandArgument;
            Response.Redirect("Default.aspx?mdm='" + madanhmuc + "'");
        }
    }
}