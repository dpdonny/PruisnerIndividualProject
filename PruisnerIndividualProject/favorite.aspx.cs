using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace PruisnerIndividualProject
{
    public partial class favorite : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int listcounter = DropDownList1.Items.Count;
            int q = 0;
            String display = "";
            //Check to see if initiated vehicles exist. If so, display them. If not, there is a problem
            if (Session["vehiclecounter"] != null)
            {
            string vehiclecounter = Session["vehiclecounter"].ToString();
                if (DropDownList1.Items.Count == 0)
                {
                    for (int j = 0; j < vehiclecounter.Length; j++)
                    {
                        DropDownList1.Items.Insert(j, Session["savedvehicles" + (j)].ToString());
                    }
                }
                
            }else
            {
                display += "There are not currently any saved vehicles from the creator";
            }
            lblform.Text = display;
            
            //Check to see if user entered vehicles exist. If so, display them
            if (Session["counter"] != null)
            {
                string counter = Session["counter"].ToString();
                    for (int i = listcounter; i < (counter.Length + listcounter); i++)
                    {
                        //DropDownList1.Items.Add(Session["Vehicle" + (i + 1)].ToString());
                        DropDownList1.Items.Insert(i, Session["Vehicle" + (q + 1)].ToString());
                    q++;
                    }
                

            }
            else
            {
                display += "You have no saved vehicles!<br>";
            }


            
        }

        protected void btnform_Click(object sender, EventArgs e)
        {
            Session["favoritecounter"] += "1";
            String favoritecounter = Session["favoritecounter"].ToString();
            int fcounter = favoritecounter.Length;
            Session["Favorite" + fcounter] = DropDownList1.SelectedItem;
        }
    }
}
