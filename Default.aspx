<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">


     <div class="offcanvas-overlay"></div>

    <!-- Slider main container Start -->
    <div class="home1-slider swiper-container">
        <div class="swiper-wrapper">
            <div class="home1-slide-item swiper-slide" data-swiper-autoplay="5000" data-bg-image="admin/logoimges/banner1/1.jpg">
                <div class="home1-slide1-content">
                    
                    <span class="slide-border"></span>
                    <span class="icon"><img src="assets/images/slider/home1/slide-2-1.fw.png" alt="Slide Icon"></span>
              
                 
                </div>
            </div>
            <div class="home1-slide-item swiper-slide" data-swiper-autoplay="5000" data-bg-image="admin/logoimges/banner2/1.jpg">
             
            </div>
            <div class="home1-slide-item swiper-slide" data-swiper-autoplay="5000" data-bg-image="admin/logoimges/banner3/1.jpg">
                <div class="home1-slide3-content">
                  
                </div>
            </div>
        </div>
        <div class="home1-slider-prev swiper-button-prev"><i class="ti-angle-left"></i></div>
        <div class="home1-slider-next swiper-button-next"><i class="ti-angle-right"></i></div>
    </div>
    <!-- Slider main container End -->

    <!-- Sale Banner Section Start -->
    <div class="section section-padding">
        <div class="container">

            <!-- Section Title Start -->
            <div class="section-title text-center">
              
                <h2 class="title title-icon-both">Our Products</h2>
            </div>
            <!-- Section Title End -->

            
        </div>
    </div>
    <!-- Sale Banner Section End -->

    <!-- Category Banner Section Start -->
    <div class="section section-fluid section-padding pt-0">
        <div class="container">
           

             <asp:Label runat="server" ID="lblcategoryimages"></asp:Label>

              

            </div>
    </div>
    <!-- Category Banner Section End -->
      <!-- About Section Start -->
    <div class="section section-padding pb-0">
        <div class="container">
            <div class="row learts-mb-n30">

                <div class="col-md-6 col-12 align-self-center learts-mb-30">
                    <div class="about-us3">
                        <span class="sub-title"><asp:Label runat="server" ID="lblhometitle"></asp:Label></span>
                        <div class="desc">
                            <p><asp:Label runat="server" ID="lblhomedescripation"></asp:Label></p>
                        </div>
                        <a href="About.aspx" class="link">Read More</a>
                    </div>
                </div>
                <div class="col-md-6 col-12 text-center learts-mb-30">
                    <img src="homeimg/1.jpg" style="height:400px;width:400px">
                </div>

            </div>
        </div>

    </div>
    <!-- About Section End -->
 <!-- Feature Section Start -->
    <div class="section section-padding">
        <div class="container">
            <div class="row row-cols-md-3 row-cols-1 learts-mb-n30">

            
            </div>
        </div>
    </div>
    <!-- Feature Section End -->
    
</asp:Content>

