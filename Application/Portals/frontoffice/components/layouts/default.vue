<template>
  <section class="airudi-layout layout-auth">
    <div class="spinner-wrapper">
      <div class="centercenter">
        <!-- <div class="spinner-grow2 logocolor" role="status">
          <span class="sr-only">Loading...</span>
        </div> -->
      </div>
    </div>
    <div class="background-header">
      <div class="topbar">
        <div class="container">
          <div class="row">
            <div class="col-xl-12">
              <div class="row">
                <div class="col-lg-6 col-md-6 col-sm-12">
                  <div
                    class="icon-top text-center text-sm-center text-md-left text-lg-left text-xl-left"
                  >
                    <div class="icons">
                      <a href="#"> <i class="fa fa-facebook"></i> </a>
                    </div>
                    <div class="icons">
                      <a href="#"> <i class="fa fa-twitter"></i> </a>
                    </div>
                    <div class="icons">
                      <a href="#"> <i class="fa fa-youtube-play"></i></a>
                    </div>
                    <div class="icons">
                      <a href="#"> <i class="fa fa-pinterest"></i></a>
                    </div>
                    <div class="icons">
                      <a href="#"> <i class="fa fa-instagram"></i></a>
                    </div>
                    <div class="icons">
                      <a href="#"> <i class="fa fa-whatsapp"></i></a>
                    </div>
                  </div>
                </div>
                <div class="col-lg-6 col-md-6 col-sm-12">
                  <div
                    class="text-center text-sm-center text-md-right text-lg-right text-xl-right"
                  >
                    <div class="toplocation text-white">
                      <i class="fa fa-map-marker" aria-hidden="true"></i>
                      <span class="locaitonfont">Location</span>

                      <select id="openonarrow">
                        <option>United States of America</option>
                        <option>United Arab Emirates</option>
                        <option>United Kingdom</option>
                        <option>Australia</option>
                        <option>Japan</option>
                        <option>India</option>
                        <option>Pakistan</option>
                        <option>Oman</option>
                      </select>

                      <span class="arrowdonwing">
                        <i class="fa fa-angle-down"></i>
                      </span>
                    </div>
                  </div>
                </div>
              </div>
            </div>
          </div>
        </div>
      </div>
      <div class="container">
        <div class="navigation">
          <nav
            class="navbar navbar-expand-lg justify-content-between nav-color zeropadd"
          >
            <div class="navbar-header">
              <a class="navbar-brand zeropadd" href="index.html">
                <img
                  src="~/assets/images/logo_200x200.png"
                  alt="logo"
                  class="max-width-60px"
                />
              </a>
              <button
                class="navbar-toggler"
                type="button"
                data-toggle="collapse"
                data-target="#navbarSupportedContent"
                aria-controls="navbarSupportedContent"
                aria-expanded="false"
                aria-label="Toggle navigation"
              >
                <span class="navbar-toggler-icon"></span>
                <span class="navbar-toggler-icon"></span>
                <span class="navbar-toggler-icon"></span>
              </button>
            </div>
            <div class="collapse navbar-collapse" id="navbarSupportedContent">
              <ul class="nav navbar-nav ml-auto">
                <li class="nav-item">
                  <a class="nav-link" href="index.html"
                    >Home
                    <span class="sr-only">(current)</span>
                  </a>
                </li>
                <li class="nav-item">
                  <a class="nav-link" href="category.html">Advance Search</a>
                </li>
                <li class="nav-item dropdown">
                  <a
                    href="#"
                    data-toggle="dropdown"
                    aria-haspopup="true"
                    aria-expanded="false"
                    class="nav-link dropdown-toggle"
                    >Categories <i class="fa fa-angle-down"></i
                  ></a>
                  <ul class="dropdown-menu border-0 shadow">
                    <li>
                      <a href="category.html" class="dropdown-item">Jobs </a>
                    </li>
                    <li>
                      <a href="category.html" class="dropdown-item"
                        >Properties</a
                      >
                    </li>
                    <!-- Level two dropdown-->
                    <li class="dropdown-submenu">
                      <a
                        href="category.html"
                        role="button"
                        data-toggle="dropdown"
                        aria-haspopup="true"
                        aria-expanded="false"
                        class="dropdown-item dropdown-toggle"
                        >Phones</a
                      >
                      <ul class="dropdown-menu border-0 shadow">
                        <li>
                          <a
                            tabindex="-1"
                            href="category.html"
                            class="dropdown-item"
                            >Apple</a
                          >
                        </li>
                        <li>
                          <a href="category.html" class="dropdown-item"
                            >Samsung</a
                          >
                        </li>
                        <li>
                          <a href="category.html" class="dropdown-item">LG</a>
                        </li>
                      </ul>
                    </li>
                    <li class="dropdown-submenu">
                      <a
                        href="category.html"
                        role="button"
                        data-toggle="dropdown"
                        aria-haspopup="true"
                        aria-expanded="false"
                        class="dropdown-item dropdown-toggle"
                        >Cars</a
                      >
                      <ul class="dropdown-menu border-0 shadow">
                        <li>
                          <a
                            tabindex="-1"
                            href="category.html"
                            class="dropdown-item"
                            >Toyota</a
                          >
                        </li>
                        <li>
                          <a href="category.html" class="dropdown-item"
                            >Suzuki</a
                          >
                        </li>
                        <li>
                          <a href="category.html" class="dropdown-item"
                            >Honda</a
                          >
                        </li>
                      </ul>
                    </li>
                    <li>
                      <a href="category.html" class="dropdown-item">Rent</a>
                    </li>
                    <li>
                      <a href="category.html" class="dropdown-item">Serviecs</a>
                    </li>
                  </ul>
                </li>

                <li class="nav-item dropdown">
                  <a
                    href="#"
                    data-toggle="dropdown"
                    aria-haspopup="true"
                    aria-expanded="false"
                    class="nav-link dropdown-toggle"
                    >Pages <i class="fa fa-angle-down"></i
                  ></a>
                  <ul class="dropdown-menu border-0 shadow">
                    <li>
                      <a href="aboutus.html" class="dropdown-item">About</a>
                    </li>
                    <li><a href="blog.html" class="dropdown-item">Blog</a></li>
                    <li>
                      <a href="contactus.html" class="dropdown-item"
                        >Contact Us</a
                      >
                    </li>
                    <li><a href="faq.html" class="dropdown-item">Faq</a></li>
                  </ul>
                </li>

                <li class="nav-item">
                  <a class="nav-link" href="contactus.html">Contact Us</a>
                </li>
                <li class="nav-item">
                  <a class="nav-link" href="loginRegister.html"
                    ><i class="fa fa-user" aria-hidden="true"></i>Login /
                    Register</a
                  >
                </li>
                <li class="nav-item bordering">
                  <a class="nav-link" href="postad.html">Post Free Ad</a>
                </li>
              </ul>
            </div>
          </nav>
        </div>
      </div>
    </div>
    <div class="content">
      <!--hero banner section-->
      <div class="hero-homepage">
        <div class="container wrapping-content">
          <div class="row">
            <div class="col-12 text-center"></div>
          </div>
        </div>
      </div>
      <!--Category section-->

      <!--Post section-->
    </div>
    <!--footer-->
    <!--footer-->
    <div>
      <!--Newsletter section-->
      <div class="newsletter">
        <div class="container">
          <div class="row">
            <div class="col-lg-3 col-md-12">
              <h2>Newsletter</h2>
            </div>
            <div class="col-lg-4 col-md-12">
              <p>Sign up to receive email updates on new recipes.</p>
            </div>
            <div class="col-lg-5 col-md-12">
              <form>
                <div class="col-sm-12">
                  <div class="row zeromargin zeromargin_form_group">
                    <div class="form-group col-lg-8 col-sm-12">
                      <input
                        type="email"
                        class="form-control"
                        placeholder="Your email address here..."
                      />
                    </div>
                    <div class="form-group col-lg-4 col-sm-12">
                      <button type="submit" class="whitehover custom-button">
                        Subscribe
                      </button>
                    </div>
                  </div>
                </div>
              </form>
            </div>
          </div>
        </div>
      </div>
      <div class="background-header footer_padding">
        <div class="container">
          <div class="navigation_footer">
            <div class="row">
              <div class="col-lg-3 col-md-6 col-sm-12">
                <div class="about-us-info">
                  <p>
                    <img
                      src="img/logo_200x200.png"
                      class="max-width-100px"
                      alt="logo"
                    />
                  </p>
                  <p><i class="fa fa-phone"></i> 123-456-987</p>
                  <p>
                    <i class="fa fa-map-marker"></i> 123 Street Infront of
                    Macdonald, <br />
                    Kingsman, United States
                  </p>
                </div>
              </div>
              <div class="col-lg-3 col-md-6 col-sm-12">
                <h3>Popular Categories</h3>
                <ul>
                  <li><a href="category.html">Properties</a></li>
                  <li><a href="category.html">Jobs</a></li>
                  <li><a href="category.html">Phones</a></li>
                  <li><a href="category.html">Cars</a></li>
                  <li><a href="category.html">Rent</a></li>
                  <li><a href="category.html">Electronics</a></li>
                </ul>
              </div>
              <div class="col-lg-3 col-md-6 col-sm-12">
                <h3>Location</h3>
                <ul>
                  <li><a href="#">London</a></li>
                  <li><a href="#">Barcelona</a></li>
                  <li><a href="#">New York</a></li>
                  <li><a href="#">France</a></li>
                  <li><a href="#">Lahore</a></li>
                  <li><a href="#">Mumbai</a></li>
                </ul>
              </div>
              <div class="col-lg-3 col-md-6 col-sm-12">
                <h3>Important Links</h3>
                <ul>
                  <li><a href="index.html">Home</a></li>
                  <li><a href="aboutus.html">About</a></li>
                  <li><a href="contactus.html">Contact Us</a></li>
                  <li><a href="#">Login</a></li>
                  <li><a href="blog.html">Blog</a></li>
                  <li><a href="faq.html">Faqs</a></li>
                </ul>
              </div>
            </div>
            <div class="footer-bottom">
              <div class="container">
                <div class="row">
                  <div class="col-md-6 zeropadd">
                    <p>
                      2019 Maida Themes. copyright @ 2016 - 2019 Powered By
                      <i class="fa fa-heart"></i>
                      <a href="#" class="greens">Maida</a>
                    </p>
                  </div>
                  <div class="col-md-6 zeropaddon768">
                    <ul class="pages-links zeropadd">
                      <li><a href="#">Terms &amp; Condition</a></li>
                      <li><a href="dashboard.html">Dashboard</a></li>
                      <li><a href="#">Privacy Policy </a></li>
                      <li><a href="#">About Us</a></li>
                    </ul>
                  </div>
                </div>
              </div>
            </div>
          </div>
        </div>
      </div>
    </div>
  </section>
</template>
<style lang="sass" scoped>
@import '~/assets/sass/main.sass'
</style>

<script>
import { library } from '@fortawesome/fontawesome-svg-core'
export default {
  name: "default",
};
</script>
