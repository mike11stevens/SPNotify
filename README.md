SPNotifiy
=========

top banner (classification banner), user acceptance modal window (terms and policy), and custom notification (alerts) solution for SharePoint 2010 using configurable property bag values and custom delegate controls.


###SPNotify.Alert

----------

TODO: Add description and sample PowerShell for alert


###SPNotify.Banner

----------

SPWebApplication scoped banner for the top of every page. The style attributes and the content are set for each SPWebApplication in the property bag: ["BannerHtml"],["BannerStyle"]

![](https://6me80a.sn2.df.livefilestore.com/y2pavnSKrNrgqc0Slo1DGZKdJSptCgFRr1ceplV8Y9_haj_OeIwqFVICp_Ovdy1uyt3yLHGThSkHHt1Kv0EQtfUw_spRTYHfkDYHwZx5mYs2rg/SPNotify.Banner.png)

Here is an example of how to set the Banner property bag values using PowerShell:

    $url = 'http://yoururl'
    Add-PSSnapin Microsoft.SharePoint.Powershell
    $spWebApp = Get-SPWebApplication $url
    $spWebApp.Properties["BannerHtml"]="Here is my top banner text."
    $spWebApp.Properties["BannerStyle"]="background-color:rgb(0,0,255); color:rgb(255,255,255); font-weight:bold; padding-top:5px; padding-bottom:5px; text-align:center;"
    $spWebApp.Update()


###SPNotify.UserAgreement

----------

TODO: Add description and sample PowerShell for user agreement


