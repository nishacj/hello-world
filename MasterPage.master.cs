using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack) 
        {

            fetchcontactus();
            fetchcategroy();
            fetchcategroy1();
            fetchcategroy2();
        }
    }
    void fetchcontactus()
    {
        DataSet ds = myclass.fetchdata("select * from dbo.tblprofile");
        int count = Convert.ToInt32(ds.Tables[0].Rows.Count);
        if (count > 0)
        {

            lblcompanyname.Text = ds.Tables[0].Rows[0]["companyname"].ToString();
            lblphone.Text = ds.Tables[0].Rows[0]["Mobile"].ToString();
            lbladdress.Text = ds.Tables[0].Rows[0]["address"].ToString();

        }
    }

    //<li><a href = "about-us.html" >< span class="menu-text">About us</span></a></li>

    string str; int i;
    void fetchcategroy()
    {


        DataSet ds = myclass.fetchdata("select DISTINCT  category  from dbo.tblproducts  ");
        int count = ds.Tables[0].Rows.Count;
        if (count > 0)
        {
            str += "";
            while (count > i)

            {


                str += " <li><a href='gallery.aspx?c=" + ds.Tables[0].Rows[i]["category"] + "' title='" + ds.Tables[0].Rows[i]["category"] + "'>" + ds.Tables[0].Rows[i]["category"] + "</a></li>";

                i++;
            }


            str += "";
            lblcategory.Text = str;

        }
    }

    string str1; int j;
    void fetchcategroy1()
    {


        DataSet ds = myclass.fetchdata("select DISTINCT  category  from dbo.tblproducts  ");
        int count = ds.Tables[0].Rows.Count;
        if (count > 0)
        {
            str1 += "";
            while (count > j)

            {


                str1 += " <li><a href='gallery.aspx?c=" + ds.Tables[0].Rows[j]["category"] + "' title='" + ds.Tables[0].Rows[j]["category"] + "'>" + ds.Tables[0].Rows[j]["category"] + "</a></li>";

                j++;
            }


            str1 += "";
            lblcategory1.Text = str1;

        }
    }
    string str2; int k;
    void fetchcategroy2()
    {


        DataSet ds = myclass.fetchdata("select DISTINCT  category  from dbo.tblproducts  ");
        int count = ds.Tables[0].Rows.Count;
        if (count > 0)
        {
            str2 += "";
            while (count > k)

            {


                str2 += " <li><a href='gallery.aspx?c=" + ds.Tables[0].Rows[k]["category"] + "' title='" + ds.Tables[0].Rows[k]["category"] + "'>" + ds.Tables[0].Rows[k]["category"] + "</a></li>";

                k++;
            }


            str2 += "";
            lblcategory2.Text = str2;

        }
    }
}
