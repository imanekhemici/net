<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Projet_ASP.Models.Employe>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Search
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>Assigner un métier</h2>
    
    <% var currentCategorie = ""; %>
    <% using (Html.BeginForm("Index", "Employe"))
        { %>
        <input type="hidden" name="employeid" value ="<%: Html.DisplayFor(m => Model.EmployeID)%>" />
        <select name="metierid" id="selectedmetier">
            <% foreach (var metier in ViewData["metiers"] as IEnumerable<Projet_ASP.Models.Metier>)
                { %>
                <% if (currentCategorie != metier.Categorie)
                    { %>
                    <optgroup label="<%: Html.DisplayFor(m => metier.Categorie)%>" />
                    <% currentCategorie = metier.Categorie; %>
                <% } %>
                <option value="<%: Html.DisplayFor(m => metier.MetierId)%>"><%: Html.DisplayFor(m => metier.Libelle)%></option>
            <% } %> %>
        </select>
        <input type="date" id="debut_metier" name="debut_metier"/>
        <input type="date" id="fin_metier" name="fin_metier" />
        <input type="submit" value="Associer" />
    <% }%>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>

<asp:Content ID="Content4" ContentPlaceHolderID="ScriptsSection" runat="server">
</asp:Content>
