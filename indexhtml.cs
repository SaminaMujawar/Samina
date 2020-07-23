@model List<Project>

<h1>Project</h1>

<table>
    <tr>
        <th>PID</th>
        <th>Task</th>
        <th>Description</th>
    </tr>
    @foreach(var project in Model)
    {
    <tr>
        <td>@project.PID</td>
        <td>@project.Task</td>
        <td>@project.Description</td>  
    </tr>
    }
</table>
