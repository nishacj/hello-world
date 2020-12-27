using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            fetchaboutdata();
            fetchproducts();
        }
    }



    void fetchaboutdata()
    {
        DataSet ds = myclass.fetchdata("select * from tblmanagehome");
        int count = Convert.ToInt32(ds.Tables[0].Rows.Count);
        if (count > 0)
        {
            lblhometitle.Text = ds.Tables[0].Rows[0]["hometitle"].ToString();
            lblhomedescripation.Text = ds.Tables[0].Rows[0]["home"].ToString();
        }
    }






    int i; string str;
    void fetchproducts()
    {
        {
            DataSet ds = myclass.fetchdata("select  * from dbo.tblproducts  order by id desc ");
            int count = ds.Tables[0].Rows.Count;
            if (count > 0)
            {
                str += "<div class='category-banner1-carousel'>";
                while (count > i)
                {


                 

                    str += "<div class='col'><div class='category-banner1'><div class='inner'><a href='gallery.aspx?c=" + ds.Tables[0].Rows[i]["category"] + "' class='image'><img src='admin/gallery/" + ds.Tables[0].Rows[i]["image"] + "' style='height:250px;width:100%'onerror=this.src='1.gif'></a><div class='content'><h3 class='title'><a href= 'gallery.aspx?c=" + ds.Tables[0].Rows[i]["category"] + "''>" + ds.Tables[0].Rows[i]["name"] + "</a></h3></div></div></div></div>";


                  

                    i++;
                }
                str += "</div>";
                lblcategoryimages.Text = str;
            }
        }
    }
}
    