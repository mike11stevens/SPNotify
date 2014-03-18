SPNotify
=========

top banner (classification banner), user acceptance modal window (terms and policy), and custom notification (alerts) solution for SharePoint 2010 using configurable property bag values and custom delegate controls.

Here are the current SPWebApplication scoped features:

- **[SPNotify.Alert](#spnotify.alert "SPNotify.Alert")**
- **[SPNotify.Banner](#spnotify.banner "SPNotify.Banner")**
- **[SPNotify.UserAgreement](#spnotify.useragreement"SPNotify.UserAgreement")**

![](https://6me80a.sn2.df.livefilestore.com/y2pYVLFwtHZ3rudHA99ZWM4-JobiVzGaDx3OlnLs5-xt2RzkHA5c_5rXLMpJ-uXmlgwb6xSARfWsup4gm0vu1rRSzSmL6cUogc-YJisI9pTSSY/SPNotify.CentralAdmin.png)

###SPNotify.Alert

----------

TODO: checkin tested alerts, add description and sample PowerShell for property values


###SPNotify.Banner

----------

SPWebApplication scoped banner for the top of every page. The style attributes and the content are set for each SPWebApplication in the property bag: 

- ["BannerHtml"]
- ["BannerStyle"]

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

SPWebApplication scoped end user agreement modal form.  Configurable with property bag values:


- ["UserAgreementTitle"]
- ["UserAgreementStyle"]
- ["UserAgreementHtml"]
- ["UserAgreementLinks"]
- ["UserAgreementExpirationDays"]

![](https://6me80a.sn2.df.livefilestore.com/y2pMiEouCrgjQ0---il99X8R15qqc2S9iOuqxWhlKmbViqbS1eg2YrF_519LYyQz67C4Ddi-hE0VmVIpMtIszRyxMJLif2GB7PaMJIdonnlxG0/SPNotify.UserAgreement.png)

Here is an example of how to set the User Agreement property bag values using PowerShell:

    $url = 'http://yoururl'
    $spWebApp = Get-SPWebApplication $url
    $spWebApp.Properties["UserAgreementTitle"]="Agree or No Soup for You!"
    $spWebApp.Properties["UserAgreementHtml"]="Before they sold out art party single-origin coffee tattooed. 90's meh XOXO, single-origin coffee Pinterest church-key ennui asymmetrical Marfa 3 wolf moon distillery Banksy typewriter pork belly. High Life Carles polaroid freegan 90's Schlitz. Vice PBR direct trade semiotics ugh. Carles bicycle rights iPhone skateboard retro banjo. VHS +1 American Apparel, 90's banh mi asymmetrical selvage Cosby sweater literally cornhole slow-carb shabby chic yr craft beer Williamsburg. Dreamcatcher Helvetica seitan, cornhole typewriter authentic church-key paleo master cleanse pickled occupy Pinterest brunch hella Truffaut. Bicycle rights Austin Odd Future, 8-bit chambray authentic mustache Portland next level DIY letterpress twee direct trade Echo Park. Squid pork belly forage, DIY blog normcore scenester readymade. DIY before they sold out polaroid messenger bag, Williamsburg retro Austin lo-fi. McSweeney's freegan post-ironic umami, flexitarian cray Etsy fap lo-fi. Irony Helvetica aesthetic cliche scenester kitsch. Truffaut lomo scenester, Thundercats Williamsburg pork belly craft beer quinoa put a bird on it bespoke. Farm-to-table Tonx Williamsburg fingerstache mlkshk High Life."
    $spWebApp.Properties["UserAgreementStyle"]="font-family:'Times New Roman',Georgia,Serif; color:rgb(192,192,192); font-weight:normal; padding:10px;"
    $spWebApp.Properties["UserAgreementLink"] = "http://mike11stevens.com/"
    $spWebApp.Properties["UserAgreementExpirationDays"] = "15"
    $spWebApp.Update()
