using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString.HasKeys())
        {
            foreach (String key in Request.QueryString.AllKeys)
            {
                Label_Info.Text += "Key: " + key + " Value: " + Request.QueryString[key] + "<br />";
            }
        }
    }
}