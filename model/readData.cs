public ActionResult project()
{
    String connectionString = "connectionString";
    String sql = "SELECT * FROM Project";
    SqlCommand cmd = new SqlCommand(sql, conn);

    var model = new List<Project>();
    using(SqlConnection conn = new SqlConnection(connectionString))
    {
        conn.Open();
        SqlDataReader rdr = cmd.ExecuteReader();
        while(rdr.Read())
        {
            var project = new projectReadData();
            project.PId = rdr["PId"];
            project.Title = rdr["Title"];
            project.Description = rdr["Description"];


            model.Add(project);
        }

    }

    return View(model);
}
