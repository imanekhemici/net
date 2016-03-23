<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Projet_ASP.Models.Metier>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Supprimer
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>Supprimer</h2>
<fieldset>
    <legend>Metier</legend>

    <div class="display-label">
        <%: Html.DisplayNameFor(model => model.Categorie) %>
    </div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Categorie) %>
    </div>

    <div class="display-label">
        <%: Html.DisplayNameFor(model => model.Libelle) %>
    </div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Libelle) %>
    </div>

    <div class="display-label">
        <%: Html.DisplayNameFor(model => model.debut) %>
    </div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.debut) %>
    </div>

    <div class="display-label">
        <%: Html.DisplayNameFor(model => model.fin) %>
    </div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.fin) %>
    </div>
</fieldset>
<% using (Html.BeginForm()) { %>
    <%: Html.AntiForgeryToken() %>
    <p>
        <input type="submit" value="Supprimer" /> |
        <%: Html.ActionLink("Retour", "Index") %>
    </p>
<% } %>

</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>

<asp:Content ID="Content4" ContentPlaceHolderID="ScriptsSection" runat="server">
</asp:Content>
