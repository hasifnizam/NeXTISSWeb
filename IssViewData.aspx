<%@ Page Language="C#" AutoEventWireup="true" CodeFile="IssViewData.aspx.cs" MasterPageFile="MasterPage.master" Inherits="IssViewData" %>

<asp:Content ID="Content" ContentPlaceHolderID="BodyContent" runat="Server">

    <section id="features" class="features">

      <div class="container" data-aos="fade-up">

        <!-- Feature Icons -->
        <div class="row feature-icons" data-aos="fade-up">
          <h3>Here is the result!<br /><br /></h3>

          <div class="row">

            <div class="col-xl-4 text-center" data-aos="fade-right" data-aos-delay="100">
              <img src="assets/img/footer-bg.png" class="img-fluid p-4" alt="">
            </div>

            <div class="col-xl-8 d-flex content">
              <div class="row align-self-center gy-4">

                <div class="col-md-6 icon-box" data-aos="fade-up">
                  <i class="ri-radar-line"></i>
                  <div>
                      
                    <h4><asp:Label ID="firstDateData" runat="server"></asp:Label></h4>
                    <p>
                        <table>
                            <tr>
                                <th>ISS City Name</th>
                                <td>:</td>
                                <td><asp:Label ID="firstCityName" runat="server"></asp:Label></td>
                            </tr>
                            <tr>
                                <th>ISS Latitude</th>
                                <td>:</td>
                                <td><asp:Label ID="firstLatitude" runat="server"></asp:Label></td>
                            </tr>
                            <tr>
                                <th>ISS Longitude</th>
                                <td>:</td>
                                <td><asp:Label ID="firstLongitude" runat="server"></asp:Label></td>
                            </tr>
                            <tr>
                                <th>ISS Altitude</th>
                                <td>:</td>
                                <td><asp:Label ID="firstAltitude" runat="server"></asp:Label></td>
                            </tr>
                            <tr>
                                <td colspan="3"><center><br /><asp:Label ID="firstLocationMaps" runat="server"></asp:Label></center></td>
                            </tr>
                        </table>
                    </p>
                  </div>
                </div>

                <div class="col-md-6 icon-box" data-aos="fade-up">
                  <i class="ri-radar-line"></i>
                  <div>
                    <h4><asp:Label ID="secondDateData" runat="server"></asp:Label></h4>
                    <p>
                        <table>
                            <tr>
                                <th>ISS City Name</th>
                                <td>:</td>
                                <td><asp:Label ID="secondCityName" runat="server"></asp:Label></td>
                            </tr>
                            <tr>
                                <th>ISS Latitude</th>
                                <td>:</td>
                                <td><asp:Label ID="secondLatitude" runat="server"></asp:Label></td>
                            </tr>
                            <tr>
                                <th>ISS Longitude</th>
                                <td>:</td>
                                <td><asp:Label ID="secondLongitude" runat="server"></asp:Label></td>
                            </tr>
                            <tr>
                                <th>ISS Altitude</th>
                                <td>:</td>
                                <td><asp:Label ID="secondAltitude" runat="server"></asp:Label></td>
                            </tr>
                            <tr>
                                <td colspan="3"><center><br /><asp:Label ID="secondLocationMaps" runat="server"></asp:Label></center></td>
                            </tr>
                        </table>
                    </p>
                  </div>
                </div>

                  <div class="col-md-6 icon-box" data-aos="fade-up">
                  <i class="ri-radar-line"></i>
                  <div>
                    <h4><asp:Label ID="thirdDateData" runat="server"></asp:Label></h4>
                    <p>
                        <table>
                            <tr>
                                <th>ISS City Name</th>
                                <td>:</td>
                                <td><asp:Label ID="thirdCityName" runat="server"></asp:Label></td>
                            </tr>
                            <tr>
                                <th>ISS Latitude</th>
                                <td>:</td>
                                <td><asp:Label ID="thirdLatitude" runat="server"></asp:Label></td>
                            </tr>
                            <tr>
                                <th>ISS Longitude</th>
                                <td>:</td>
                                <td><asp:Label ID="thirdLongitude" runat="server"></asp:Label></td>
                            </tr>
                            <tr>
                                <th>ISS Altitude</th>
                                <td>:</td>
                                <td><asp:Label ID="thirdAltitude" runat="server"></asp:Label></td>
                            </tr>
                            <tr>
                                <td colspan="3"><center><br /><asp:Label ID="thirdLocationMaps" runat="server"></asp:Label></center></td>
                            </tr>
                        </table>
                    </p>
                  </div>
                </div>

                  <div class="col-md-6 icon-box" data-aos="fade-up">
                  <i class="ri-radar-line"></i>
                  <div>
                    <h4><asp:Label ID="forthDateData" runat="server"></asp:Label></h4>
                    <p>
                        <table>
                            <tr>
                                <th>ISS City Name</th>
                                <td>:</td>
                                <td><asp:Label ID="forthCityName" runat="server"></asp:Label></td>
                            </tr>
                            <tr>
                                <th>ISS Latitude</th>
                                <td>:</td>
                                <td><asp:Label ID="forthLatitude" runat="server"></asp:Label></td>
                            </tr>
                            <tr>
                                <th>ISS Longitude</th>
                                <td>:</td>
                                <td><asp:Label ID="forthLongitude" runat="server"></asp:Label></td>
                            </tr>
                            <tr>
                                <th>ISS Altitude</th>
                                <td>:</td>
                                <td><asp:Label ID="forthAltitude" runat="server"></asp:Label></td>
                            </tr>
                            <tr>
                                <td colspan="3"><center><br /><asp:Label ID="forthLocationMaps" runat="server"></asp:Label></center></td>
                            </tr>
                        </table>
                    </p>
                  </div>
                </div>

                  <div class="col-md-6 icon-box" data-aos="fade-up">
                  <i class="ri-radar-line"></i>
                  <div>
                    <h4><asp:Label ID="fifthDateData" runat="server"></asp:Label></h4>
                    <p>
                        <table>
                            <tr>
                                <th>ISS City Name</th>
                                <td>:</td>
                                <td><asp:Label ID="fifthCityName" runat="server"></asp:Label></td>
                            </tr>
                            <tr>
                                <th>ISS Latitude</th>
                                <td>:</td>
                                <td><asp:Label ID="fifthLatitude" runat="server"></asp:Label></td>
                            </tr>
                            <tr>
                                <th>ISS Longitude</th>
                                <td>:</td>
                                <td><asp:Label ID="fifthLongitude" runat="server"></asp:Label></td>
                            </tr>
                            <tr>
                                <th>ISS Altitude</th>
                                <td>:</td>
                                <td><asp:Label ID="fifthAltitude" runat="server"></asp:Label></td>
                            </tr>
                            <tr>
                                <td colspan="3"><center><br /><asp:Label ID="fifthLocationMaps" runat="server"></asp:Label></center></td>
                            </tr>
                        </table>
                    </p>
                  </div>
                </div>

                  <div class="col-md-6 icon-box" data-aos="fade-up">
                  <i class="ri-radar-line"></i>
                  <div>
                    <h4><asp:Label ID="sixDateData" runat="server"></asp:Label></h4>
                    <p>
                        <table>
                            <tr>
                                <th>ISS City Name</th>
                                <td>:</td>
                                <td><asp:Label ID="sixCityName" runat="server"></asp:Label></td>
                            </tr>
                            <tr>
                                <th>ISS Latitude</th>
                                <td>:</td>
                                <td><asp:Label ID="sixLatitude" runat="server"></asp:Label></td>
                            </tr>
                            <tr>
                                <th>ISS Longitude</th>
                                <td>:</td>
                                <td><asp:Label ID="sixLongitude" runat="server"></asp:Label></td>
                            </tr>
                            <tr>
                                <th>ISS Altitude</th>
                                <td>:</td>
                                <td><asp:Label ID="sixAltitude" runat="server"></asp:Label></td>
                            </tr>
                            <tr>
                                <td colspan="3"><center><br /><asp:Label ID="sixLocationMaps" runat="server"></asp:Label></center></td>
                            </tr>
                        </table>
                    </p>
                  </div>
                </div>

                  <div class="col-md-6 icon-box" data-aos="fade-up">
                  <i class="ri-radar-line"></i>
                  <div>
                    <h4><asp:Label ID="sevenDateData" runat="server"></asp:Label></h4>
                    <p>
                        <table>
                            <tr>
                                <th>ISS City Name</th>
                                <td>:</td>
                                <td><asp:Label ID="sevenCityName" runat="server"></asp:Label></td>
                            </tr>
                            <tr>
                                <th>ISS Latitude</th>
                                <td>:</td>
                                <td><asp:Label ID="sevenLatitude" runat="server"></asp:Label></td>
                            </tr>
                            <tr>
                                <th>ISS Longitude</th>
                                <td>:</td>
                                <td><asp:Label ID="sevenLongitude" runat="server"></asp:Label></td>
                            </tr>
                            <tr>
                                <th>ISS Altitude</th>
                                <td>:</td>
                                <td><asp:Label ID="sevenAltitude" runat="server"></asp:Label></td>
                            </tr>
                            <tr>
                                <td colspan="3"><center><br /><asp:Label ID="sevenLocationMaps" runat="server"></asp:Label></center></td>
                            </tr>
                        </table>
                    </p>
                  </div>
                </div>

                  <div class="col-md-6 icon-box" data-aos="fade-up">
                  <i class="ri-radar-line"></i>
                  <div>
                    <h4><asp:Label ID="eightDateData" runat="server"></asp:Label></h4>
                    <p>
                        <table>
                            <tr>
                                <th>ISS City Name</th>
                                <td>:</td>
                                <td><asp:Label ID="eightCityName" runat="server"></asp:Label></td>
                            </tr>
                            <tr>
                                <th>ISS Latitude</th>
                                <td>:</td>
                                <td><asp:Label ID="eightLatitude" runat="server"></asp:Label></td>
                            </tr>
                            <tr>
                                <th>ISS Longitude</th>
                                <td>:</td>
                                <td><asp:Label ID="eightLongitude" runat="server"></asp:Label></td>
                            </tr>
                            <tr>
                                <th>ISS Altitude</th>
                                <td>:</td>
                                <td><asp:Label ID="eightAltitude" runat="server"></asp:Label></td>
                            </tr>
                            <tr>
                                <td colspan="3"><center><br /><asp:Label ID="eightLocationMaps" runat="server"></asp:Label></center></td>
                            </tr>
                        </table>
                    </p>
                  </div>
                </div>

                  <div class="col-md-6 icon-box" data-aos="fade-up">
                  <i class="ri-radar-line"></i>
                  <div>
                    <h4><asp:Label ID="nineDateData" runat="server"></asp:Label></h4>
                    <p>
                        <table>
                            <tr>
                                <th>ISS City Name</th>
                                <td>:</td>
                                <td><asp:Label ID="nineCityName" runat="server"></asp:Label></td>
                            </tr>
                            <tr>
                                <th>ISS Latitude</th>
                                <td>:</td>
                                <td><asp:Label ID="nineLatitude" runat="server"></asp:Label></td>
                            </tr>
                            <tr>
                                <th>ISS Longitude</th>
                                <td>:</td>
                                <td><asp:Label ID="nineLongitude" runat="server"></asp:Label></td>
                            </tr>
                            <tr>
                                <th>ISS Altitude</th>
                                <td>:</td>
                                <td><asp:Label ID="nineAltitude" runat="server"></asp:Label></td>
                            </tr>
                            <tr>
                                <td colspan="3"><center><br /><asp:Label ID="nineLocationMaps" runat="server"></asp:Label></center></td>
                            </tr>
                        </table>
                    </p>
                  </div>
                </div>

                  <div class="col-md-6 icon-box" data-aos="fade-up">
                  <i class="ri-radar-line"></i>
                  <div>
                    <h4><asp:Label ID="tenDateData" runat="server"></asp:Label></h4>
                    <p>
                        <table>
                            <tr>
                                <th>ISS City Name</th>
                                <td>:</td>
                                <td><asp:Label ID="tenCityName" runat="server"></asp:Label></td>
                            </tr>
                            <tr>
                                <th>ISS Latitude</th>
                                <td>:</td>
                                <td><asp:Label ID="tenLatitude" runat="server"></asp:Label></td>
                            </tr>
                            <tr>
                                <th>ISS Longitude</th>
                                <td>:</td>
                                <td><asp:Label ID="tenLongitude" runat="server"></asp:Label></td>
                            </tr>
                            <tr>
                                <th>ISS Altitude</th>
                                <td>:</td>
                                <td><asp:Label ID="tenAltitude" runat="server"></asp:Label></td>
                            </tr>
                            <tr>
                                <td colspan="3"><center><br /><asp:Label ID="tenLocationMaps" runat="server"></asp:Label></center></td>
                            </tr>
                        </table>
                    </p>
                  </div>
                </div>

                  <div class="col-md-6 icon-box" data-aos="fade-up">
                  <i class="ri-radar-line"></i>
                  <div>
                    <h4><asp:Label ID="elevenDateData" runat="server"></asp:Label></h4>
                    <p>
                        <table>
                            <tr>
                                <th>ISS City Name</th>
                                <td>:</td>
                                <td><asp:Label ID="elevenCityName" runat="server"></asp:Label></td>
                            </tr>
                            <tr>
                                <th>ISS Latitude</th>
                                <td>:</td>
                                <td><asp:Label ID="elevenLatitude" runat="server"></asp:Label></td>
                            </tr>
                            <tr>
                                <th>ISS Longitude</th>
                                <td>:</td>
                                <td><asp:Label ID="elevenLongitude" runat="server"></asp:Label></td>
                            </tr>
                            <tr>
                                <th>ISS Altitude</th>
                                <td>:</td>
                                <td><asp:Label ID="elevenAltitude" runat="server"></asp:Label></td>
                            </tr>
                            <tr>
                                <td colspan="3"><center><br /><asp:Label ID="elevenLocationMaps" runat="server"></asp:Label></center></td>
                            </tr>
                        </table>
                    </p>
                  </div>
                </div>

                  <div class="col-md-6 icon-box" data-aos="fade-up">
                  <i class="ri-radar-line"></i>
                  <div>
                    <h4><asp:Label ID="twelveDateData" runat="server"></asp:Label></h4>
                    <p>
                        <table>
                            <tr>
                                <th>ISS City Name</th>
                                <td>:</td>
                                <td><asp:Label ID="twelveCityName" runat="server"></asp:Label></td>
                            </tr>
                            <tr>
                                <th>ISS Latitude</th>
                                <td>:</td>
                                <td><asp:Label ID="twelveLatitude" runat="server"></asp:Label></td>
                            </tr>
                            <tr>
                                <th>ISS Longitude</th>
                                <td>:</td>
                                <td><asp:Label ID="twelveLongitude" runat="server"></asp:Label></td>
                            </tr>
                            <tr>
                                <th>ISS Altitude</th>
                                <td>:</td>
                                <td><asp:Label ID="twelveAltitude" runat="server"></asp:Label></td>
                            </tr>
                            <tr>
                                <td colspan="3"><center><br /><asp:Label ID="twelveLocationMaps" runat="server"></asp:Label></center></td>
                            </tr>
                        </table>
                    </p>
                  </div>
                </div>

                  <div class="col-md-6 icon-box" data-aos="fade-up">
                  <i class="ri-radar-line"></i>
                  <div>
                    <h4><asp:Label ID="thirteenDateData" runat="server"></asp:Label></h4>
                    <p>
                        <table>
                            <tr>
                                <th>ISS City Name</th>
                                <td>:</td>
                                <td><asp:Label ID="thirteenCityName" runat="server"></asp:Label></td>
                            </tr>
                            <tr>
                                <th>ISS Latitude</th>
                                <td>:</td>
                                <td><asp:Label ID="thirteenLatitude" runat="server"></asp:Label></td>
                            </tr>
                            <tr>
                                <th>ISS Longitude</th>
                                <td>:</td>
                                <td><asp:Label ID="thirteenLongitude" runat="server"></asp:Label></td>
                            </tr>
                            <tr>
                                <th>ISS Altitude</th>
                                <td>:</td>
                                <td><asp:Label ID="thirteenAltitude" runat="server"></asp:Label></td>
                            </tr>
                            <tr>
                                <td colspan="3"><center><br /><asp:Label ID="thirteenLocationMaps" runat="server"></asp:Label></center></td>
                            </tr>
                        </table>
                    </p>
                  </div>
                </div>

              </div>
            </div>

          </div>

        </div><!-- End Feature Icons -->

      </div>

    </section><!-- End Features Section -->

</asp:Content>
