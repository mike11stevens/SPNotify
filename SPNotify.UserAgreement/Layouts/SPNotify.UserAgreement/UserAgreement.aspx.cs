using System;
using Microsoft.SharePoint;
using Microsoft.SharePoint.Administration;
using Microsoft.SharePoint.WebControls;

namespace SPNotify.UserAgreement.Layouts.SPNotify.UserAgreement
{
    public partial class UserAgreement : LayoutsPageBase
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                SPWebApplication spWebApp = SPContext.Current.Site.WebApplication;
                if (spWebApp.Properties["UserAgreementHtml"].ToString() != "")
                {
                    string strHTML;
                    
                    //set agreement title
                    string strTitle = spWebApp.Properties["UserAgreementTitle"].ToString();
                    litUserAgreementTitle.Text = strTitle;
                    
                    ////set agreement style
                    //strHTML = @"<style type=text/css>#UserAgreement {" + spWebApp.Properties["UserAgreementStyle"].ToString() + @" }</style>";
                    //litUserAgreementStyle.Text = strHTML;
                    //litUserAgreementHtml.Visible = true;

                    //set agreement body copy
                    strHTML = String.Format("<div id='UserAgreement'>" + spWebApp.Properties["UserAgreementHtml"].ToString() + "</div>");
                    litUserAgreementHtml.Text = strHTML;

                    ////set agreement link
                    //strHTML = String.Format("<a href=" + spWebApp.Properties["UserAgreementLink"].ToString() + @" target=_blank class='btn'>More Details...<a>");
                    //litUserAgreementLink.Text = strHTML;

                    ////set cookie expiration days
                    //strHTML = String.Format("<a href='' class='btn btn-primary' onclick='javascript:createCookie('SPNotify_UserAgreement', 'accepted'," + spWebApp.Properties["UserAgreementExpirationDays"].ToString() + @"); window.frameElement.cancelPopUp(); return false;'>I Accept</a>");
                    //litUserAgreementExpirationDays.Text = strHTML;
                    
                }

            }
            catch (Exception ex)
            {
                SPDiagnosticsService.Local.WriteTrace(0, new SPDiagnosticsCategory("Custom", TraceSeverity.Unexpected, EventSeverity.Error), TraceSeverity.Unexpected, ex.Message, ex.StackTrace);
            }
        }
    }
}
