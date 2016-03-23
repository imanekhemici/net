<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.master" Inherits="System.Web.Mvc.ViewPage<Projet_ASP.Models.Roles>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Créer un role 
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>Créer un role</h2>

<% using (Html.BeginForm()) { %>
    <%: Html.AntiForgeryToken() %>
    <%: Html.ValidationSummary(true) %>

    <fieldset>
        <legend>Roles</legend>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.Titre) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.Titre) %>
            <%: Html.ValidationMessageFor(model => model.Titre) %>
        </div>

        <p>
            <input type="submit" value="Créer" />
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
