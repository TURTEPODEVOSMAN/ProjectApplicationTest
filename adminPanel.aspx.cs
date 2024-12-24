using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OKucukkelesSQLinj
{
    public partial class adminPanel : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Deger"] != null )
            {
                lblBilgi.Text = "Yönetici Admin :"+ Session["Deger"].ToString();
            }
            else
            {
                Response.Redirect("http://localhost:60704/default");
            }


            // 
        }

        protected void btnLogOff_Click(object sender, EventArgs e)
        {
            Session.Add("Deger", null);            
            Response.Redirect("http://localhost:60704/default");
        }
    }
}