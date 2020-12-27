using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class gallery : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            fetchproducts();
        }
    }
    int i; string str;
    void fetchproducts()
    {
        {

            DataSet ds = myclass.fetchdata("select * from dbo.tblproducts where category='" + Request.QueryString["c"] + "' order by id desc ");

            int count = ds.Tables[0].Rows.Count;
            if (count > 0)
            {
                str += "<div class='row row-cols-xl-5 row-cols-lg-3 row -cols-sm-2 row-cols-1 learts-mb-n30'>";
                while (count > i)
                {



                    //str += "  <div class='col-lg-3 col-md-4'><div class='hm_news_box'><div class='hm_news_img'><img src='admin/gallery/" + ds.Tables[0].Rows[i]["image"] + "' alt='" + ds.Tables[0].Rows[i]["name"] + "' style='height:280px;width:100%'onerror=this.src='1.gif' title='" + ds.Tables[0].Rows[i]["name"] + "' class='img-responsive'><div class='news_img_overlay'></div><div class='overlay_buttons'><a class='popup-news-gallery' href='admin/gallery/" + ds.Tables[0].Rows[i]["image"] + "' title='" + ds.Tables[0].Rows[i]["name"] + "'><i class='fa fa-search' aria-hidden='true'></i></a></div></div><div class='hm_news_data'><center><h3><a>" + ds.Tables[0].Rows[i]["name"] + "</a></h3></center></div></div></div>";

                    str += "<div class='col learts-mb-30'><div class='portfolio'><div class='thumbnail'><img src='admin/gallery/" + ds.Tables[0].Rows[i]["image"] + "' alt='" + ds.Tables[0].Rows[i]["name"] + "' style='height:280px;width:100%'onerror=this.src='1.gif' title='" + ds.Tables[0].Rows[i]["name"] + "'></div><div class='content'><h4 class='title'><a>" + ds.Tables[0].Rows[i]["name"] + "</center></a></h4><div class='link'><a href='admin/gallery/" + ds.Tables[0].Rows[i]["image"] + "' target='_blank'>Zoom</a></div></div></div></div>";
                    this.Page.Title = Request.QueryString["c"].ToString();

                    i++;
                }
                str += "</div>";

                lblgallery.Text = str;
                lblname.Text = Request.QueryString["c"].ToString();
                lblname1.Text = Request.QueryString["c"].ToString();

            }
        }

    }




      
}