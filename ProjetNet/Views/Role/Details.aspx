<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.master" Inherits="System.Web.Mvc.ViewPage<Projet_ASP.Models.Roles>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Details
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>Details</h2>

<fieldset>
    <legend>Roles</legend>

    <div class="display-label">
        <%: Html.DisplayNameFor(model => model.Titre) %>
    </div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Titre) %>
    </div>
</fieldset>
<p>

    <%: Html.ActionLink("Modifier", "Edit", new { id=Model.RoleId }) %> |
    <%: Html.ActionLink("Retour", "Index") %>
</p>

</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>

<asp:Content ID="Content4" ContentPlaceHolderID="ScriptsSection" runat="server">
</asp:Content>
