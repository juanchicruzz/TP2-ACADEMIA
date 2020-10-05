using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Business.Logic;

namespace UI.Web
{
    public partial class Default : System.Web.UI.Page
    {
        UsuarioLogic usuarioLogic;

        
        protected void Page_Load(object sender, EventArgs e)
        {
<<<<<<< Updated upstream

=======
            if (!IsPostBack)
            {
                Panel header = (Panel)Master.FindControl("header");
                header.Visible = false;
            }
        }
        protected void ingresarLinkButton_Click(object sender, EventArgs e)
        {
            usuarioLogic = new UsuarioLogic();
            string user = Request.Form["Usuario"];
            string pass = Request.Form["Pass"];
            Console.WriteLine(user + pass);
            if (usuarioLogic.Login(user,pass)) 
            { 

            Panel header = (Panel)Master.FindControl("header");
            header.Visible = true;
            Response.Redirect("usuarios.aspx");
            }
>>>>>>> Stashed changes
        }
    }
}