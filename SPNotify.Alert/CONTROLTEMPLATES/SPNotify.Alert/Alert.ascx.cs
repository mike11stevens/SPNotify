using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using Microsoft.SharePoint;
using Microsoft.SharePoint.Administration;

namespace SPNotify.Alert.CONTROLTEMPLATES.SPNotify.Alert
{
    public partial class Alert : UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                SPWebApplication spWebApp = SPContext.Current.Site.WebApplication;
                if (spWebApp.Properties["AlertTitle"].ToString() != "")
                {

                    string strTitle = spWebApp.Properties["AlertTitle"].ToString();
                    string strMessage = spWebApp.Properties["AlertMessage"].ToString();
                    string strColor = spWebApp.Properties["Alertcolor"].ToString().ToLower();

                    string strAlert = "<script type='text/javascript' language='javascript'>"
                        + "ExecuteOrDelayUntilScriptLoaded(AddCustomStatus, 'sp.js'); "
                        + "_spBodyOnLoadFunctionNames.push('AddCustomStatus'); "
                        + "function AddCustomStatus() { "
                        + "statusId = SP.UI.Status.addStatus(\'" + strTitle + "\', \'" + strMessage + "', true); "
                        + "SP.UI.Status.setStatusPriColor(statusId, \'" + strColor + "\'); return statusId; } "
                        + "</script>";

                    litAlert.Text = strAlert;
                }
            }
            catch (Exception ex)
            {
                SPDiagnosticsService.Local.WriteTrace(0, new SPDiagnosticsCategory("Custom", TraceSeverity.Unexpected, EventSeverity.Error), TraceSeverity.Unexpected, ex.Message, ex.StackTrace);
            }
        }
    }
}
