<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Projet_ASP.Models.Employe>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Supprimer
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>Supprimer</h2>

<fieldset>
    <legend>Employe</legend>

    <div class="display-label">
        <%: Html.DisplayNameFor(model => model.Nom) %>
    </div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Nom) %>
    </div>

    <div class="display-label">
        <%: Html.DisplayNameFor(model => model.Prenom) %>
    </div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Prenom) %>
    </div>

    <div class="display-label">
        <%: Html.DisplayNameFor(model => model.Matricule) %>
    </div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Matricule) %>
    </div>

    <div class="display-label">
        <%: Html.DisplayNameFor(model => model.dateNaissance) %>
    </div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.dateNaissance) %>
    </div>

    <div class="display-label">
        <%: Html.DisplayNameFor(model => model.dateEntree) %>
    </div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.dateEntree) %>
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
