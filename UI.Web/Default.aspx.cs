using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UI.Web
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Panel header = (Panel)Master.FindControl("header");
                header.Visible = false;
            }
        }
        protected void ingresarLinkButton_Click(object sender, EventArgs e)
        {
            Panel header = (Panel)Master.FindControl("header");
            header.Visible = true;
            Response.Redirect("usuarios.aspx");
        }
    }
}