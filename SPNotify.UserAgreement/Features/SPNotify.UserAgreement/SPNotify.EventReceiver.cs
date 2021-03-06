using System;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using Microsoft.SharePoint;
using Microsoft.SharePoint.Administration;

namespace SPNotify.UserAgreement.Features.SPNotify.UserAgreement
{
    /// <summary>
    /// This class handles events raised during feature activation, deactivation, installation, uninstallation, and upgrade.
    /// </summary>
    /// <remarks>
    /// The GUID attached to this class may be used during packaging and should not be modified.
    /// </remarks>

    [Guid("3426d310-a745-4e1e-b8c8-5b720a1b9462")]
    public class SPNotifyEventReceiver : SPFeatureReceiver
    {
        // Uncomment the method below to handle the event raised after a feature has been activated.

        public override void FeatureActivated(SPFeatureReceiverProperties properties)
        {
            try
            {
                SPWebApplication spWebApp;
                spWebApp = properties.Feature.Parent as SPWebApplication;

                if (spWebApp.Properties["UserAgreementHtml"] == null) { spWebApp.Properties.Add("UserAgreementHtml", ""); }
                if (spWebApp.Properties["UserAgreementStyle"] == null) { spWebApp.Properties.Add("UserAgreementStyle", ""); }
                if (spWebApp.Properties["UserAgreementTitle"] == null) { spWebApp.Properties.Add("UserAgreementTitle", ""); }
                if (spWebApp.Properties["UserAgreementLink"] == null) { spWebApp.Properties.Add("UserAgreementLink", ""); }
                if (spWebApp.Properties["UserAgreementExpirationDays"] == null) { spWebApp.Properties.Add("UserAgreementExpirationDays", ""); }
                spWebApp.Update();
            }
            catch (Exception ex)
            {
                SPDiagnosticsService.Local.WriteTrace(0, new SPDiagnosticsCategory("Custom", TraceSeverity.Unexpected, EventSeverity.Error), TraceSeverity.Unexpected, ex.Message, ex.StackTrace);
            }
        }


        // Uncomment the method below to handle the event raised before a feature is deactivated.

        //public override void FeatureDeactivating(SPFeatureReceiverProperties properties)
        //{
        //}


        // Uncomment the method below to handle the event raised after a feature has been installed.

        //public override void FeatureInstalled(SPFeatureReceiverProperties properties)
        //{
        //}


        // Uncomment the method below to handle the event raised before a feature is uninstalled.

        //public override void FeatureUninstalling(SPFeatureReceiverProperties properties)
        //{
        //}

        // Uncomment the method below to handle the event raised when a feature is upgrading.

        //public override void FeatureUpgrading(SPFeatureReceiverProperties properties, string upgradeActionName, System.Collections.Generic.IDictionary<string, string> parameters)
        //{
        //}
    }
}
