using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PruisnerIndividualProject
{

    public partial class entry : System.Web.UI.Page
    {
        /*string[] vehiclearray = new string[] {};*/
        int i = new int();
        

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btndescription_Click(object sender, EventArgs e)
        {
            //every time the button is clicked, add to the count and use count for session entry
            Session["counter"] += "1";
            string display = "";
            string count = Session["counter"].ToString();
            i = count.Length;
            Session["Vehicle" + i] = txtdescription.Text;
            for (int j = 0; j < count.Length; j++)
            {
               display += Session["Vehicle" + (j+1)].ToString() + "<br>";
            }
            Label2.Text = display;
        }

    }
}