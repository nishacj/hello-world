using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack) 
        {
        
        }
    }

    protected void txtlogin_Click(object sender, EventArgs e)
    {
        if (txtusername.Text == "admin")
        {
            int exis1 = myclass.checkexistence("select count(*) from tblprofile where password='" + txtpassword.Text + "'");
            if (exis1 > 0)
            {
                Session["adminid"] = txtusername.Text;
                Session["adminpassword"] = txtpassword.Text;
                Response.Redirect("admin/profile.aspx");
            }
            else
            { ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "string", "alert('Invalid User Id/Password!');", true); }
        }
    }
}