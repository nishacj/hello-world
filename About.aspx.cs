using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class About : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            fetchaboutdata();
        }
    }



    void fetchaboutdata()
    {
        DataSet ds = myclass.fetchdata("select * from dbo.tblabout");
        int count = Convert.ToInt32(ds.Tables[0].Rows.Count);
        if (count > 0)
        {
            lblabouttitle.Text = ds.Tables[0].Rows[0]["abouttitle"].ToString();
            lblaboutdescripation.Text = ds.Tables[0].Rows[0]["description"].ToString();
        }
    }
}