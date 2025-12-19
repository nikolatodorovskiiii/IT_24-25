using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace labs1
{
    public partial class Glasaj : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                string name = Request.QueryString["name"];
                displayName.Text = "Проф. д-р " + name;

                subjectBox.Items.Add("Интернет технологии");
                subjectBox.Items.Add("Интернет");
                subjectBox.Items.Add("Дигитална Електроника");

                creditBox.Items.Add("6");
                creditBox.Items.Add("5.5");
                creditBox.Items.Add("5.5");
            }
        }

        protected void subjectBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int itemIndex = subjectBox.SelectedIndex;
            creditBox.SelectedIndex = itemIndex;
        }

        protected void voteButton_Click(object sender, EventArgs e)
        {
            string getMail = Request.QueryString["email"];
            Response.Redirect("UspeshnoGlasanje.aspx?email="+getMail);
        }

        protected void addButton_Click(object sender, EventArgs e)
        {
            string getName = subjectInput.Text;
            string getCredits = creditInput.Text;

            subjectBox.Items.Add(getName);
            creditBox.Items.Add(getCredits);

            subjectInput.Text = "";
            creditInput.Text = "";
        }

        protected void deleteButton_Click(object sender, EventArgs e)
        {
            ListItem selectedSubject = subjectBox.SelectedItem;
            ListItem selectedCredit = creditBox.SelectedItem;

            subjectBox.Items.Remove(selectedSubject);
            creditBox.Items.Remove(selectedCredit);
        }
    }
}