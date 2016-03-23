<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<Projet_ASP.Models.Metier>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Metiers
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>Metiers existants</h2>

<p>
    <%: Html.ActionLink("Créer un nouveau metier", "Create") %>
</p>
<table>
    <tr>
        <th>
            <%: Html.DisplayNameFor(model => model.Categorie) %>
        </th>
        <th>
            <%: Html.DisplayNameFor(model => model.Libelle) %>
        </th>
        <th>
            <%: Html.DisplayNameFor(model => model.debut) %>
        </th>
        <th>
            <%: Html.DisplayNameFor(model => model.fin) %>
        </th>
        <th></th>
    </tr>

<% foreach (var item in Model) { %>
    <tr>
        <td>
            <%: Html.DisplayFor(modelItem => item.Categorie) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.Libelle) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.debut) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.fin) %>
        </td>
        <td>
            <%: Html.ActionLink("Modifier", "Edit", new { id=item.MetierId }) %> |
            <%: Html.ActionLink("Details", "Details", new { id=item.MetierId }) %> |
            <%: Html.ActionLink("Supprimer", "Delete", new { id=item.MetierId }) %>
        </td>
    </tr>
<% } %>

</table>

</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>

<asp:Content ID="Content4" ContentPlaceHolderID="ScriptsSection" runat="server">
</asp:Content>
