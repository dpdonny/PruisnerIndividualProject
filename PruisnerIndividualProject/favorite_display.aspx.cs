using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PruisnerIndividualProject
{
    public partial class favorite_display : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String display = "";
            if (Session["favoritecounter"] != null)
            {
                String favoritescounter = Session["favoritecounter"].ToString();
                int fcounter = favoritescounter.Length;
                for (int i = 0; i < fcounter; i++)
                {
                    display += "<br>" + Session["Favorite" + (i + 1)].ToString() + "<br><br><hr>";
                }
            }
            else
            {
                display = "You have no favorites!";
            }

            lblresults.Text = display;
        }
    }
}