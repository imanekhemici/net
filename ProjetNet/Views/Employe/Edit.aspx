<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Projet_ASP.Models.Employe>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Modifier
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>Modifier</h2>

<% using (Html.BeginForm()) { %>
    <%: Html.AntiForgeryToken() %>
    <%: Html.ValidationSummary(true) %>

    <fieldset>
        <legend>Employe</legend>

        <%: Html.HiddenFor(model => model.EmployeID) %>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.Nom) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.Nom) %>
            <%: Html.ValidationMessageFor(model => model.Nom) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.Prenom) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.Prenom) %>
            <%: Html.ValidationMessageFor(model => model.Prenom) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.Matricule) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.Matricule) %>
            <%: Html.ValidationMessageFor(model => model.Matricule) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.dateNaissance) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.dateNaissance) %>
            <%: Html.ValidationMessageFor(model => model.dateNaissance) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.dateEntree) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.dateEntree) %>
            <%: Html.ValidationMessageFor(model => model.dateEntree) %>
        </div>

        <p>
            <input type="submit" value="Sauvegarder" />
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
