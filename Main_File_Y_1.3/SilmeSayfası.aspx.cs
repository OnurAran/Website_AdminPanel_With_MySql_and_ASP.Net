using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace yazlab1_3.v._1
{
    public partial class AdminSil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(Request.QueryString["ID"].ToString());
            Data.DataSet1TableAdapters.kullaniciTableAdapter dt = new Data.DataSet1TableAdapters.kullaniciTableAdapter();
            dt.sil(x);
            Response.Redirect("yonetim.aspx");
        }
    }
}