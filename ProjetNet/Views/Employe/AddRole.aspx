<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Projet_ASP.Models.Employe>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    AddRole
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>Assigner un rôle</h2>
     <% using (Html.BeginForm("Index", "Employe"))
        { %>
        <input type="hidden" name="employeid" value ="<%: Html.DisplayFor(m => Model.EmployeID)%>" />
        <select name="roleid" id="roleid">
            <% foreach (var role in ViewData["roles"] as IEnumerable<Projet_ASP.Models.Roles>)
                { %>
                <option value="<%: Html.DisplayFor(m => role.RoleId)%>"><%: Html.DisplayFor(m => role.Titre)%></option>
            <% } %> %>
        </select>
        <input type="submit" value="Associer" />
    <% }%>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>

<asp:Content ID="Content4" ContentPlaceHolderID="ScriptsSection" runat="server">
</asp:Content>
