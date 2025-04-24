using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PruisnerIndividualProject
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //display all initiated vehicles
            if (Session["vehiclecounter"] != null)
            {
                string display = "";
                string vehiclecounter = Session["vehiclecounter"].ToString();
                for (int i = 0; i < vehiclecounter.Length; i++)
                {
                    display += Session["savedvehicles" + (i)].ToString() + "<hr>";
                }
                lbldisplay.Text = display;
            }
        }
        protected void randvehiclebtn_Click(object sender, EventArgs e)
        {
            //display a random vehicle with an image from the initiated vehicles in the session
            string vehiclecounter = Session["vehiclecounter"].ToString();
            Random rand = new Random();
            randvehiclelbl.Text = Session["savedvehicles" + (rand.Next(vehiclecounter.Length))].ToString();
            switch (randvehiclelbl.Text)
            {
                case "2000 Chevrolet Malibu":
                    randvehicleimg.Text = "<img class = \"img\" src=\"https://donnypruisner.com/pictures/malibu2000.jpg\" alt = \"Tan 2000 Chevy Malibu\">";
                    break;
                case "1989 Chevrolet Silverado 1500":
                    randvehicleimg.Text = "<img class = \"img\" src=\"https://donnypruisner.com/pictures/car-wash-truck.jpg\" alt = \"Gray Chevy 1500\">";
                    break;
                case "1984 GMC Rally STX":
                    randvehicleimg.Text = "<img class = \"img\" src=\"https://donnypruisner.com/pictures/van.jpg\" alt = \"Red GMC Van\">";
                    break;
                case "1985 Pontiac Fiero 2m4":
                    randvehicleimg.Text = "<img class = \"img\" src=\"https://donnypruisner.com/pictures/fiero1985.jpg\" alt = \"Silver 1985 Pontiac Fiero 2m4\">";
                    break;
                case "1997 Buick Park Avenue":
                    randvehicleimg.Text = "<img class = \"img\" src=\"https://donnypruisner.com/pictures/parkavenue1997.jpg\" alt = \"Snow covered 1997 Buick Park Avenue\">";
                    break;

            }
        }
    }
}