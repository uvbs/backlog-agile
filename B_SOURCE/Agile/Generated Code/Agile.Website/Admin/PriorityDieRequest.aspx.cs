﻿

#region Using directives
using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using Agile.Web.UI;
#endregion

public partial class PriorityDieRequest : System.Web.UI.Page
{	
    protected void Page_Load(object sender, EventArgs e)
	{
		FormUtil.RedirectAfterUpdate(GridView1, "PriorityDieRequest.aspx?page={0}");
		FormUtil.SetPageIndex(GridView1, "page");
		FormUtil.SetDefaultButton((Button)GridViewSearchPanel1.FindControl("cmdSearch"));
    }

	protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
	{
		string urlParams = string.Format("PriorityDieRequestId={0}", GridView1.SelectedDataKey.Values[0]);
		Response.Redirect("PriorityDieRequestEdit.aspx?" + urlParams, true);
	}
	
}


