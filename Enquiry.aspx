<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Enquiry.aspx.cs" Inherits="Contactus" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

      <div class="offcanvas-overlay"></div>

    <!-- Page Title/Header Start -->
    <div class="page-title-section section" data-bg-image="assets/images/bg/page-title-1.jpg">
        <div class="container">
            <div class="row">
                <div class="col">

                    <div class="page-title">
                        <h1 class="title">Enquiry</h1>
                        <ul class="breadcrumb">
                            <li class="breadcrumb-item"><a href="Default.aspx">Home</a></li>
                             <li class="breadcrumb-item active">Enquiry</li>
                        </ul>
                    </div>

                </div>
            </div>
        </div>
    </div>
    <!-- Page Title/Header End -->

      <!-- Contact Form Section Start -->
    <div class="section section-padding pt-0">
        <div class="container">
            <!-- Section Title Start -->
            <div class="section-title2 text-center">
    <br /><br />
       
                <h2 class="title">Enquiry Now</h2>
            </div>
            <!-- Section Title End -->

            <div class="row">
                <div class="col-lg-8 col-12 mx-auto">
                    <div class="contact-form">
                        <form>
                            <div class="row learts-mb-n30">
                                <div class="col-md-6 col-12 learts-mb-30"><asp:TextBox runat="server" placeholder="Your Name *" ID="txtname" ></asp:TextBox></div>
                                <div class="col-md-6 col-12 learts-mb-30"><asp:TextBox runat="server" placeholder="Your Email*" ID="txtemail" ></asp:TextBox></div>
                                <div class="col-md-12 col-12 learts-mb-30"><asp:TextBox runat="server" placeholder="Your Phone*" ID="txtPhone" ></asp:TextBox></div>
                                <div class="col-12 learts-mb-30"><asp:TextBox runat="server" placeholder="Message" ID="txtMessage" Height="50" ></asp:TextBox></div>
                                <div class="col-12 text-center learts-mb-30"><center><asp:Button CssClass="btn btn-dark btn-outline-hover-dark" Text="SUBMIT" runat="server" BackColor="Black" Width="150px" ForeColor="White" OnClick="Unnamed_Click"></asp:Button></center></div>
                            </div>
                        </form>
                        <p class="form-messege"></p>
                    </div>
                </div>
            </div>

        </div>
    </div>
    <!-- Contact Form Section End -->






  
</asp:Content>

