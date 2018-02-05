@ModelType IEnumerable(Of MVCDestiny.Models.Movie)
@Code
    ViewData("Title") = "Index"
End Code



<h2>Index</h2>
<p>
    @*@Html.ActionLink("Create New", "Create")
        @Using Html.BeginForm("Index", "Movies", FormMethod.Get)
                @<p> Title: @Html.TextBox("SearchString") <br/>
                <input type="submit" value="Filter"/></p>
        End Using*@
    @Html.ActionLink("Create New", "Create")
    @Using Html.BeginForm("Index", "Movies", FormMethod.Get)
        @<p>Genre: @Html.DropDownList("movieGenre", "All")
        Title: @Html.TextBox("SearchString") <br />
        <input type = "submit" value="Filter" />
    </p>End Using
   



    <table class="table">
        <tr>
            <th>
                @Html.DisplayNameFor(Function(model) model.Title)
            </th>
            <th>
                @Html.DisplayNameFor(Function(model) model.ReleaseDate)
            </th>
            <th>
                @Html.DisplayNameFor(Function(model) model.Genre)
            </th>
            <th>
                @Html.DisplayNameFor(Function(model) model.Price)
            </th>
            <th>
                @Html.DisplayNameFor(Function(model) model.Rating)
            </th>
            <th></th>
        </tr>

        @For Each item In Model
            @<tr>
    <td>
        @Html.DisplayFor(Function(modelItem) item.Title)
    </td>
    <td>
        @Html.DisplayFor(Function(modelItem) item.ReleaseDate)
    </td>
    <td>
        @Html.DisplayFor(Function(modelItem) item.Genre)
    </td>
    <td>
        @Html.DisplayFor(Function(modelItem) item.Price)
    </td>
    <th>
        @Html.DisplayFor(Function(model) item.Rating)
    </th>
    <td>
        @Html.ActionLink("Edit", "Edit", New With {.id = item.ID}) |
        @Html.ActionLink("Details", "Details", New With {.id = item.ID}) |
        @Html.ActionLink("Delete", "Delete", New With {.id = item.ID})
    </td>

</tr>
        Next

    </table>

