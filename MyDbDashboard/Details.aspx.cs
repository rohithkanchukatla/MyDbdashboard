using System;
using System.Data;
using System.Web.UI;

namespace MyDbDashboard
{

    public partial class Details : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Check if we have a DBID from the previous page
            if (Session["SelectedDBID"] != null)
            {
                int dbId = Convert.ToInt32(Session["SelectedDBID"]);
                LoadDetails(dbId);
            }
            else
            {
                // If no ID was passed, redirect back home
                Response.Redirect("Default.aspx");
            }
        }

        private void LoadDetails(int dbId)
        {
            DataTable dt = DataAccess.GetDatabaseDetails(dbId);

            // Make sure we got a result
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                lblName.Text = row["DatabaseName"].ToString();
                lblServer.Text = row["ServerName"].ToString();
                lblLastBackup.Text = Convert.ToDateTime(row["LastBackupDate"]).ToString("yyyy-MM-dd HH:mm");
                lblSize.Text = row["SizeMB"].ToString();
            }
        }
    }
}
