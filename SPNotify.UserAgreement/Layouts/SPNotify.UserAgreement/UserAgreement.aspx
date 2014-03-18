<%@ Assembly Name="$SharePoint.Project.AssemblyFullName$" %>
<%@ Import Namespace="Microsoft.SharePoint.ApplicationPages" %>
<%@ Register Tagprefix="SharePoint" Namespace="Microsoft.SharePoint.WebControls" Assembly="Microsoft.SharePoint, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register Tagprefix="Utilities" Namespace="Microsoft.SharePoint.Utilities" Assembly="Microsoft.SharePoint, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register Tagprefix="asp" Namespace="System.Web.UI" Assembly="System.Web.Extensions, Version=3.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" %>
<%@ Import Namespace="Microsoft.SharePoint" %>
<%@ Assembly Name="Microsoft.Web.CommandUI, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserAgreement.aspx.cs" Inherits="SPNotify.UserAgreement.Layouts.SPNotify.UserAgreement.UserAgreement" DynamicMasterPageFile="~masterurl/minimal.master" %>

<asp:Content ID="PageHead" ContentPlaceHolderID="PlaceHolderAdditionalPageHead" runat="server">

    <script type="text/javascript" src="/_layouts/SPNotify.UserAgreement/jquery-1.10.2/jquery-1.10.2.min.js"></script>
    <script type="text/javascript" src="/_layouts/SPNotify.UserAgreement/bootstrap/js/bootstrap.min.js"></script>
    <link rel="Stylesheet" type="text/css" href="/_layouts/SPNotify.UserAgreement/bootstrap/css/bootstrap.min.css" />
    <link rel="Stylesheet" type="text/css" href="/_layouts/SPNotify.UserAgreement/bootstrap/css/bootstrap-responsive.min.css" />

    <SharePoint:ScriptLink ID="SPNotifySessionCookies"runat="server" Language="javascript" Name="SPNotifySessionCookies.js" />
    <asp:Literal ID="litUserAgreementStyle" runat="server" Text="" />
</asp:Content>

<asp:Content ID="Main" ContentPlaceHolderID="PlaceHolderMain" runat="server">
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
</asp:Content>

<asp:Content ID="PageTitle" ContentPlaceHolderID="PlaceHolderPageTitle" runat="server">
    <asp:Literal ID="litUserAgreementTitle" runat="server" Text="" />
</asp:Content>
