<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Projet_ASP.Models.Employe_Metier>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Attribuer un metier
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>Attribuer un metier</h2>

<% using (Html.BeginForm()) { %>
    <%: Html.AntiForgeryToken() %>
    <%: Html.ValidationSummary(true) %>

    <fieldset>
        <legend>Employe_Metier</legend>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.EmployeRefId, "Employe") %>
        </div>
        <div class="editor-field">
            <%: Html.DropDownList("EmployeRefId", String.Empty) %>
            <%: Html.ValidationMessageFor(model => model.EmployeRefId) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.MetierRefId, "Metier") %>
        </div>
        <div class="editor-field">
            <%: Html.DropDownList("MetierRefId", String.Empty) %>
            <%: Html.ValidationMessageFor(model => model.MetierRefId) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.DebutMetier) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.DebutMetier) %>
            <%: Html.ValidationMessageFor(model => model.DebutMetier) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.FinMetier) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.FinMetier) %>
            <%: Html.ValidationMessageFor(model => model.FinMetier) %>
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
