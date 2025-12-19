using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace labs1
{
    public partial class UspeshnoGlasanje : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                string getMail = Request.QueryString["email"];
                finalMessage.Text = "Ви благодариме за учеството во акцијата за избор на најинтересен предмет на ФИНКИ. Резултатите од гласањето ќе ги добиете по електронска пошта, на Е-MAIL: " + getMail;
            }
        }
    }
}