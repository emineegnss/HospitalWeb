using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace HospitalWeb
{
    public class Global : System.Web.HttpApplication
    {
        void Yonlendir(RouteCollection route) {
            route.MapPageRoute("Giriş", "GirisYap", "~/Default.aspx");
            route.MapPageRoute("Kayıt", "KayıtOl", "~/Register.aspx");
            route.MapPageRoute("Şifre", "SifreUnuttum", "~/ForgotPassword.aspx");
            route.MapPageRoute("Doktor", "Doktor", "~/DoktorMaster.aspx");
            route.MapPageRoute("Hasta", "Hasta", "~/PatientMaster.aspx");

        }
        protected void Application_Start(object sender, EventArgs e)
        {
            Yonlendir(RouteTable.Routes);
        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}