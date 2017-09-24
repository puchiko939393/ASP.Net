@Imports System.Web.Http
@Imports MvcAppliction1_WebAPI_0001_VB.Areas.HelpPage.ModelDescriptions
@ModelType ModelDescription

<link type="text/css" href="~/Areas/HelpPage/HelpPage.css" rel="stylesheet" />
<div id="body" class="help-page">
    <section class="featured">
        <div class="content-wrapper">
            <p>
                @Html.ActionLink("Help Page Home", "Index")
            </p>
        </div>
    </section>
    <h1>@Model.Name</h1>
    <p>@Model.Documentation</p>
    <section class="content-wrapper main-content clear-fix">
        @Html.DisplayFor(Function(m) Model)
    </section>
</div>
