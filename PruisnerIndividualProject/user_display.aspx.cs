using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PruisnerIndividualProject
{
    public partial class user_display : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           //display all vehicles that the user has saved
            if (Session["counter"] != null)
            {
                string counter = Session["counter"].ToString();
                for (int i = 0; i < counter.Length; i++)
                {
                    lblresults.Text += Session["Vehicle" + (i+1)] + "<hr>";
                }
            }
            else
            {
                lblresults.Text = "There are no saved vehicles<br>";
            }
            if (Session["imagecounter"] != null)
            {
                string imgcounter = Session["imagecounter"].ToString();
                for (int j = 0; j < imgcounter.Length; j++)
                {
                    lblresults.Text += "<img class='img1' src = '" + Session["image" + (j + 1)].ToString() + "'>";
                }
            }




        }
    }
}