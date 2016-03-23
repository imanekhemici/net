<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Projet_ASP.Models.Metier>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Modifier
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>Modifier</h2>

<% using (Html.BeginForm()) { %>
    <%: Html.AntiForgeryToken() %>
    <%: Html.ValidationSummary(true) %>

    <fieldset>
        <legend>Metier</legend>

        <%: Html.HiddenFor(model => model.MetierId) %>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.Categorie) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.Categorie) %>
            <%: Html.ValidationMessageFor(model => model.Categorie) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.Libelle) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.Libelle) %>
            <%: Html.ValidationMessageFor(model => model.Libelle) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.debut) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.debut) %>
            <%: Html.ValidationMessageFor(model => model.debut) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.fin) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.fin) %>
            <%: Html.ValidationMessageFor(model => model.fin) %>
        </div>

        <p>
            <input type="submit" value="Modifier" />
        </p>
    </fieldset>
<% } %>

<div>
    <%: Html.ActionLink("Retour", "Index") %>
</div>

</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>

<asp:Content ID="Content4" ContentPlaceHolderID="ScriptsSection" runat="server">
    <%: Scripts.Render("~/bundles/jqueryval") %>
</asp:Content>
