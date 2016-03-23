<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Projet_ASP.Models.Employe_Role>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Modifier
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>Modifier</h2>

<% using (Html.BeginForm()) { %>
    <%: Html.AntiForgeryToken() %>
    <%: Html.ValidationSummary(true) %>

    <fieldset>
        <legend>Employe_Role</legend>

        <%: Html.HiddenFor(model => model.Employe_RoleId) %>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.EmployeRefId, "Employe") %>
        </div>
        <div class="editor-field">
            <%: Html.DropDownList("EmployeRefId", String.Empty) %>
            <%: Html.ValidationMessageFor(model => model.EmployeRefId) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.RoleRefId, "Role") %>
        </div>
        <div class="editor-field">
            <%: Html.DropDownList("RoleRefId", String.Empty) %>
            <%: Html.ValidationMessageFor(model => model.RoleRefId) %>
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
