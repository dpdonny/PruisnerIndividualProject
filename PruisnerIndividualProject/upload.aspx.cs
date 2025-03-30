using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PruisnerIndividualProject
{
    public partial class upload : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (file.HasFile)
            {
                Session["imagecounter"] += "1";
                String imgcount = Session["imagecounter"].ToString();
                int imagecounter = imgcount.Length;
                String filename = file.FileName;
                String strPath = Request.PhysicalApplicationPath + file.FileName;
                file.SaveAs(strPath);
                Session["image" + imagecounter] = filename;
                lblresults.Text = "File was successfully uploaded at: <br>" + strPath + "<br><br>Copy this file path if you want to delete the image after you see the display page on Saved Vehicles";
            }

            else
            {
                lblresults.Text = "No file selected. Please try again.";
            }
        }
    }
}