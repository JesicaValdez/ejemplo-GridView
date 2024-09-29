using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;

namespace ejemplo_web
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        { 
            
            if(Session["listaAutos"] == null)
            {
                AutoNegocio negocio = new AutoNegocio();
                Session.Add("listaAutos", negocio.listar());
            }
           
            dgvAutos.DataSource = Session["listaAutos"];
            dgvAutos.DataBind(); // This method is used to bind the data from the data source to the GridView control.

        }

        protected void dgvAutos_SelectedIndexChanged(object sender, EventArgs e)
        {
           var detalle = dgvAutos.SelectedRow.Cells[0].Text;
            var id = dgvAutos.SelectedDataKey.Value.ToString(); // This method is used to get the value of the data key in the selected row.
            Response.Redirect("AutoForm.aspx?id=" + id);
        }
    }
}