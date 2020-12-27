<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="login" %>

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
                        <h1 class="title">My Login</h1>
                        <ul class="breadcrumb">
                            <li class="breadcrumb-item"><a href="Default.aspx">Home</a></li>
                            <li class="breadcrumb-item active">My Login</li>
                        </ul>
                    </div>

                </div>
            </div>
        </div>
    </div>
    <!-- Page Title/Header End -->

    <!-- Lost Password Section Start -->
    <div class="section section-padding">
        <div class="container">

            <div class="lost-password">
                
                <div>
                    <div class="row learts-mb-n30">
                        <div class="col-12 learts-mb-30">
                            
                            <asp:TextBox runat="server" ID="txtusername" placeholder="User Name" CssClass="form-control"></asp:TextBox>
                            <br />
                                
                            <asp:TextBox runat="server" ID="txtpassword" placeholder="User Password" CssClass="form-control" TextMode="Password"></asp:TextBox>
                        
                        </div>

                        <div class="col-12 text-center learts-mb-30">
                            <center><asp:Button runat="server" ID="txtlogin" CssClass="btn btn-dark btn-outline-hover-dark" BackColor="Black" ForeColor="White" Text="Login" Width="150" OnClick="txtlogin_Click"></asp:Button></center>
                            
                        </div>
                    </div>
                </div>
            </div>

        </div>

    </div>
    <!-- Lost Password Section End -->
</asp:Content>

