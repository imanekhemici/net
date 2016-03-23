<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<Projet_ASP.Models.Employe_Role>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Roles attribés
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>Roles attribés</h2>

<p>
    <%: Html.ActionLink("Attribuer un role", "Create") %>
</p>
<table>
    <tr>
        <th>
            <%: Html.DisplayNameFor(model => model.Employe.Nom) %>
        </th>
        <th>
            <%: Html.DisplayNameFor(model => model.Role.Titre) %>
        </th>
        <th></th>
    </tr>

<% foreach (var item in Model) { %>
    <tr>
        <td>
            <%: Html.DisplayFor(modelItem => item.Employe.Nom) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.Role.Titre) %>
        </td>
        <td>
            <%: Html.ActionLink("Modifier", "Edit", new { id=item.Employe_RoleId }) %> |
            <%: Html.ActionLink("Details", "Details", new { id=item.Employe_RoleId }) %> |
            <%: Html.ActionLink("Supprimer", "Delete", new { id=item.Employe_RoleId }) %>
        </td>
    </tr>
<% } %>

</table>

</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>

<asp:Content ID="Content4" ContentPlaceHolderID="ScriptsSection" runat="server">
</asp:Content>
