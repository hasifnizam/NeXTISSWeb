<%@ Page Language="C#" AutoEventWireup="true" CodeFile="FindIss.aspx.cs" MasterPageFile="MasterPage.master" Inherits="FindIss" %>

<asp:Content ID="Content" ContentPlaceHolderID="BodyContent" runat="Server">

    <section id="features" class="features">

      <div class="container" data-aos="fade-up">

        <!-- Feature Tabs -->
        <div class="row feture-tabs" data-aos="fade-up">
          <div class="col-lg-6">
            <h3>First, when do you want to know the location of ISS?</h3>

            <!-- Tab Content -->
            <div class="tab-content">

              <div class="contact">
                <div class="col-lg-12">
                <form class="designform" runat="server">
                  <div class="row gy-4">

                    <div class="col-md-12">
                        <h4>Date and Time: </h4><br />
                        <asp:TextBox ID="dateChoosen" TextMode="DateTimeLocal" runat="server" CssClass="form-control m-input" ></asp:TextBox>
                    </div>

                    <div class="col-md-12 text-center">
                      <asp:Button ID="btnAdd" CssClass="btn btn-primary" runat="server" Text="Let's Go!" OnClick="BtnSearchISS" />
                    </div>

                  </div>
                </form>

                </div>
              </div><!-- End Tab 1 Content -->

            </div>

          </div>

          <div class="col-lg-6">
            <img src="assets/img/values-2.png" class="img-fluid" alt="">
          </div>

        </div><!-- End Feature Tabs -->

      </div>

    </section><!-- End Features Section -->

    <%--<section id="features" class="features">

      <div class="container" data-aos="fade-up">

        <!-- Feature Tabs -->
        <div class="row feture-tabs" data-aos="fade-up">

          <div class="col-lg-6">
            <img src="assets/img/values-1.png" class="img-fluid" alt="">
          </div>

            <div class="col-lg-6">
            <h3>Here some more information about the weather today</h3>

            <!-- Tab Content -->
            <div class="tab-content">

              <div class="contact">
                <div class="col-lg-12">
                <div class="designform">
                  <div class="row gy-4">

                    <div class="col-md-12">
                        <table>
                            <tr>
                                <th><h4>Weather Information</h4></th>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="lblCity_Country" runat="server"></asp:Label>
                                    <asp:Image ID="imgCountryFlag" runat="server"></asp:Image>
                                    <asp:Label ID="lblDescription" runat="server"></asp:Label>
                                    Humidity: <asp:Label ID="lblHumidity" runat="server"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    Temperature: (Min: 
                                    <asp:Label ID="lblTempMin" runat="server"></asp:Label>
                                    Max: 
                                    <asp:Label ID="lblTempMax" runat="server"></asp:Label>
                                    Day: 
                                    <asp:Label ID="lblTempDay" runat="server"></asp:Label>
                                    Night: 
                                    <asp:Label ID="lblTempNight" runat="server"></asp:Label>
                                </td>
                            </tr>
                        </table>
                       
                    </div>

                    <div class="col-md-12 text-center">
                      
                    </div>

                  </div>
                </div>

                </div>
              </div><!-- End Tab 1 Content -->

            </div>

          </div>

        </div><!-- End Feature Tabs -->

      </div>

    </section><!-- End Features Section -->--%>

</asp:Content>