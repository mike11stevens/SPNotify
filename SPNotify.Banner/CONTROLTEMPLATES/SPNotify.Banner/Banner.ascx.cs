using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using Microsoft.SharePoint;
using Microsoft.SharePoint.Administration;


namespace SPNotify.Banner.CONTROLTEMPLATES.SPNotify.Banner
{
    public partial class Banner : UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                SPWebApplication spWebApp = SPContext.Current.Site.WebApplication;
                if (spWebApp.Properties["BannerHtml"].ToString() != "")
                {
                    string strHTML = @"<style type=text/css>#Banner {" + spWebApp.Properties["BannerStyle"].ToString() + @" }</style>";
                    litBannerStyle.Text = strHTML;
                    litBannerHtml.Visible = true;

                    strHTML = String.Format("<div id='Banner'>" + spWebApp.Properties["BannerHtml"].ToString() + "</div>");
                    litBannerHtml.Text = strHTML;
                }

            }
            catch (Exception ex)
            {
                SPDiagnosticsService.Local.WriteTrace(0, new SPDiagnosticsCategory("Custom", TraceSeverity.Unexpected, EventSeverity.Error), TraceSeverity.Unexpected, ex.Message, ex.StackTrace);
            }
        }
    }
}
