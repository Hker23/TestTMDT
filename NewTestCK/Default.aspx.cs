using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NewTestCK
{
    public partial class Default : System.Web.UI.Page
    {
        LopKetNoi ketnoi=new LopKetNoi();
        protected void Page_Load(object sender, EventArgs e)
        {
            ValidationSettings.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
            if (IsPostBack) return;
            string madanhmuc = Request.QueryString["mdm"] + "";
            string sql = "";
            if (madanhmuc == "")
            {
                sql = "select * from SanPham";
            }
            else
            {
                sql = "select * from SanPham where MANSX =" + madanhmuc;
            }
            DDL_default.DataSource = ketnoi.laydulieu(sql);
            DDL_default.DataBind();
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            string matuixach = ((ImageButton)sender).CommandArgument;
            Response.Redirect("Chitiet.aspx?mtx='" + matuixach + "'");
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            string matuixach = ((LinkButton)sender).CommandArgument;
            Response.Redirect("Chitiet.aspx?mtx='" + matuixach + "'");
        }
    }
}