<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>

<asp:Content ID="indexTitle" ContentPlaceHolderID="TitleContent" runat="server">
    WonderTwitter
</asp:Content>

<asp:Content ID="indexContent" ContentPlaceHolderID="MainContent" runat="server">
<div id="howto">
    <h1>How does this work?</h1>
    <h1>1.  Click <img src="../../Content/btn-signin-mini.png" /> to sign in using your Twitter account.</h1>
    <h1>2.  Select the statuses you want to retweet.</h1>
    <h1>3.  Click <img src="../../Content/btn-retweet-mini.png" /> and you're done.</h1>
</div>
</asp:Content>
