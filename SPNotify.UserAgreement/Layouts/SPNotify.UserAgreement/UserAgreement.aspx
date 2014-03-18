<%@ Assembly Name="$SharePoint.Project.AssemblyFullName$" %>
<%@ Import Namespace="Microsoft.SharePoint.ApplicationPages" %>
<%@ Register Tagprefix="SharePoint" Namespace="Microsoft.SharePoint.WebControls" Assembly="Microsoft.SharePoint, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register Tagprefix="Utilities" Namespace="Microsoft.SharePoint.Utilities" Assembly="Microsoft.SharePoint, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register Tagprefix="asp" Namespace="System.Web.UI" Assembly="System.Web.Extensions, Version=3.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" %>
<%@ Import Namespace="Microsoft.SharePoint" %>
<%@ Assembly Name="Microsoft.Web.CommandUI, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserAgreement.aspx.cs" Inherits="SPNotify.UserAgreement.Layouts.SPNotify.UserAgreement.UserAgreement" DynamicMasterPageFile="~masterurl/default.master" %>

<asp:Content ID="PageHead" ContentPlaceHolderID="PlaceHolderAdditionalPageHead" runat="server">
    <script type="text/javascript" src="/_layouts/SPNotify.UserAgreement/jquery-1.10.2/jquery-1.10.2.min.js"></script>
    <script type="text/javascript" src="/_layouts/SPNotify.UserAgreement/bootstrap/js/bootstrap.min.js"></script>
    <link rel="Stylesheet" type="text/css" href="/_layouts/SPNotify.UserAgreement/bootstrap/css/bootstrap.min.css" />
    <link rel="Stylesheet" type="text/css" href="/_layouts/SPNotify.UserAgreement/bootstrap/css/bootstrap-responsive.min.css" />
    <script type="text/javascript" src="/_layouts/SPNotify.UserAgreement/SPNotifySessionCookies.js"></script>

    <style type="text/css">#Banner { visibility:hidden; display:none; }</style>
</asp:Content>

<asp:Content ID="Main" ContentPlaceHolderID="PlaceHolderMain" runat="server">
    <asp:Literal ID="litUserAgreementStyle" runat="server" Text="" />
    <div style="padding: 20px 30px;">
        <div class="">
            <p>
                <asp:Literal ID="litUserAgreementHtml" runat="server" Text="" />
            </p>
         </div>
         <div class="form-actions">
            <asp:Literal ID="litUserAgreementLink" runat="server" Text="" />
            <asp:Literal ID="litUserAgreementExpirationDays" runat="server" Text="" />
        </div>
    </div>

        <script type="text/javascript">

            function createCookie(name, value, days) {
                if (days) {
                    var date = new Date();
                    date.setTime(date.getTime() + (days * 24 * 60 * 60 * 1000));
                    var expires = "; expires=" + date.toGMTString();
                }
                else var expires = "";
                document.cookie = name + "=" + value + expires + "; path=/";
            }

            function readCookie(name) {
                var nameEQ = name + "=";
                var ca = document.cookie.split(';');
                for (var i = 0; i < ca.length; i++) {
                    var c = ca[i];
                    while (c.charAt(0) == ' ') c = c.substring(1, c.length);
                    if (c.indexOf(nameEQ) == 0) return c.substring(nameEQ.length, c.length);
                }
                return null;
            }

            function eraseCookie(name) {
                createCookie(name, "", -1);
            }

    </script>

</asp:Content>

<asp:Content ID="PageTitle" ContentPlaceHolderID="PlaceHolderPageTitle" runat="server">
    <asp:Literal ID="litUserAgreementTitle" runat="server" Text="" />
</asp:Content>

<asp:Content ID="PageTitleInTitleArea" ContentPlaceHolderID="PlaceHolderPageTitleInTitleArea" runat="server" >
hello world!
</asp:Content>
