<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<Projet_ASP.Models.Employe>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Employés
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>Employés</h2>

<p>
    <%: Html.ActionLink("Créer un employé", "Create") %>
    <%: Html.ActionLink("Les postes attribués", "Index", "EmployeMetier") %>
</p>
    
<% var selectedemploye = 0; %>
<% ICollection<Projet_ASP.Models.Employe_Metier> metierslist = null; %>
<% using (Html.BeginForm("Search", "Employe"))  {%>

    <p>
        <%: @Html.TextBox("searchString", null, new { @PlaceHolder = "Matricule" })%> 
        <input type="submit" value="Recherche" /></p>
<% } %>

<table>
    <tr>
        <th>
            <%: Html.DisplayNameFor(model => model.Nom) %>
        </th>
        <th>
            <%: Html.DisplayNameFor(model => model.Prenom) %>
        </th>
        <th>
            <%: Html.DisplayNameFor(model => model.Matricule) %>
        </th>
        <th>
            <%: Html.DisplayNameFor(model => model.dateNaissance) %>
        </th>
        <th>
            <%: Html.DisplayNameFor(model => model.dateEntree) %>
        </th>
        <th>Gestion</th>
    </tr>
    
<% foreach (var item in Model) { %> 
    <% if(ViewData["metiers"] != null) { %>
       <% selectedemploye = item.EmployeID; %>
        <% metierslist = item.Metiers; %>
    <% } %>
    <tr>
        <td>
            <%: Html.DisplayFor(modelItem => item.Nom) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.Prenom) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.Matricule) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.dateNaissance) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.dateEntree) %>
        </td>
      
        <td>
                <%: Html.ActionLink("Modifier", "Edit", new { id=item.EmployeID }) %> |
                <%: Html.ActionLink("Details", "Details", new { id=item.EmployeID }) %> |
                <%: Html.ActionLink("Supprimer", "Delete", new { id=item.EmployeID }) %>
            
        </td>
    </tr>
<% } %>

</table>
<% if(ViewData["metiers"] != null) { %>
    Associer un métier : 
    <% var currentCategorie = ""; %>
    
    <% using (Html.BeginForm())  {%>
        <input type="hidden" name="employeid" value ="<%: Html.DisplayFor(m => selectedemploye) %>" />
        <select name="selectedmetier" id="selectedmetier">
            <% foreach (var metier in ViewData["metiers"] as IEnumerable<Projet_ASP.Models.Metier>) { %>
                <% if(currentCategorie != metier.Categorie) { %>
                    <optgroup label="<%: Html.DisplayFor(m => metier.Categorie) %>" />
                    <% currentCategorie = metier.Categorie; %>
                <% } %>
                <option value="<%: Html.DisplayFor(m => metier.MetierId) %>"><%: Html.DisplayFor(m => metier.Libelle) %></option>
            <% } %> %>
        </select>
        <input type="submit" value="Associer" />
    <% } %>
<% } %>

</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>

<asp:Content ID="Content4" ContentPlaceHolderID="ScriptsSection" runat="server">
</asp:Content>
