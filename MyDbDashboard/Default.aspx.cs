using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyDbDashboard
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                PopulateDatabaseDropDown();

            }
        }

        private void PopulateDatabaseDropDown()
        {
            ddlDatabases.DataSource = DataAccess.GetDatabaseList();
            ddlDatabases.DataTextField = "DatabaseName";
            ddlDatabases.DataValueField = "DBID";
            ddlDatabases.DataBind();
        }

        protected void btnGetDetails_Click(object sender, EventArgs e)
        {
            // Get the selected database ID
            string selectedDbId = ddlDatabases.SelectedValue;

            // Store it in the Session to pass it to the next page
            Session["SelectedDBID"] = selectedDbId;

            // Redirect to the details page
            Response.Redirect("Details.aspx");
        }
    }
}