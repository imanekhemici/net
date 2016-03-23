<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Projet_ASP.Models.Employe_Role>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Details
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>Details</h2>

<fieldset>
    <legend>Employe_Role</legend>

    <div class="display-label">
        <%: Html.DisplayNameFor(model => model.Employe.Nom) %>
    </div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Employe.Nom) %>
    </div>

    <div class="display-label">
        <%: Html.DisplayNameFor(model => model.Role.Titre) %>
    </div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Role.Titre) %>
    </div>
</fieldset>
<p>

    <%: Html.ActionLink("Modifier", "Edit", new { id=Model.Employe_RoleId }) %> |
    <%: Html.ActionLink("Retour", "Index") %>
</p>

</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>

<asp:Content ID="Content4" ContentPlaceHolderID="ScriptsSection" runat="server">
</asp:Content>
