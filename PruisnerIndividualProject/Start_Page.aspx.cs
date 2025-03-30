using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PruisnerIndividualProject
{
    public partial class Start_Page : System.Web.UI.Page
    {
        //Initiate the array that the session will use to save the vehicles
        String[] vehicles = new string[] { "2000 Chevrolet Malibu", "1989 Chevrolet Silverado 1500", "1984 GMC Rally STX", "1985 Pontiac Fiero 2m4", "1997 Buick Park Avenue" };
        protected void Page_Load(object sender, EventArgs e)
        {
            //Save the vehicles to the session to be used by other pages. 
            Session["vehiclecounter"] = "";
            for (int i = 0; i < vehicles.Length; i++)
            {
                Session["vehiclecounter"] += "1";
                Session["savedvehicles" + i] = vehicles[i];
            }
        }
    }
}