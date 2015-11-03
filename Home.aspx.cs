using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JiraMetrics
{
    public partial class Home : System.Web.UI.Page
    {
        string path;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {										
            if (FileUpload1.HasFile)
            {
                path = string.Concat(Server.MapPath("~/Content/" + FileUpload1.FileName)); // add
                FileUpload1.SaveAs(path); //DefaultConnection has been placed
            }
        }
    }
}