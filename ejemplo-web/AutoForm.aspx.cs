using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;

namespace ejemplo_web
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                ddlColores.Items.Add("Rojo");
                ddlColores.Items.Add("Azul");
                ddlColores.Items.Add("Blanco");
            }

            // Validar si la lista de autos no está en la sesión
            if (Session["listaAutos"] == null)
            {
                // Crear una nueva lista de autos
                List<Auto> autos = new List<Auto>();

                // Agregar la lista a la sesión
                Session["listaAutos"] = autos;
            }

            if(Request.QueryString["Id"] != null)
            {
                int id = int.Parse(Request.QueryString["Id"]);
                List<Auto> temporal = (List<Auto>)Session["listaAutos"];
                Auto seleccionado = temporal.Find(a => a.Id == id);


                /*
                AutoNegocio negocio = new AutoNegocio();
                Auto auto = negocio.listar().Find(a => a.Id == id);
                */

                txtId.Text = seleccionado.Id.ToString();
                txtMarca.Text = seleccionado.Marca;
                txtModelo.Text = seleccionado.Modelo;
                txtDescripcion.Text = seleccionado.Descripcion;
                ddlColores.SelectedValue = seleccionado.Color;
                txtFecha.Text = seleccionado.Fecha.ToString("yyyy-MM-dd");
                chkUsado.Checked = seleccionado.usado;
                rdbImportado.Checked = seleccionado.Importado;
                rdbNacional.Checked = !seleccionado.Importado;

            }

        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar la entrada de datos y manejar posibles errores
                if (string.IsNullOrEmpty(txtId.Text) || !int.TryParse(txtId.Text, out int id))
                {
                    // Manejar error de entrada de datos
                    lblError.Text = "Por favor, ingrese un ID válido.";
                    return;
                }

                if (string.IsNullOrEmpty(txtFecha.Text) || !DateTime.TryParse(txtFecha.Text, out DateTime fecha))
                {
                    // Manejar error de entrada de datos
                    lblError.Text = "Por favor, ingrese una fecha válida.";
                    return;
                }

                // Crear una nueva instancia de Auto y asignar valores
                Auto auto = new Auto
                {
                    Id = id,
                    Marca = txtMarca.Text,
                    Modelo = txtModelo.Text,
                    Descripcion = txtDescripcion.Text,
                    Color = ddlColores.SelectedValue,
                    Fecha = fecha,
                    usado = chkUsado.Checked,
                    Importado = rdbImportado.Checked
                };

                // Obtener la lista de autos desde la sesión o inicializarla si es null
                List<Auto> temporal = Session["listaAutos"] as List<Auto> ?? new List<Auto>();

                // Agregar el auto a la lista
                temporal.Add(auto);

                // Actualizar la lista en la sesión
                Session["listaAutos"] = temporal;

                // Redirigir a otra página
                Response.Redirect("Default.aspx");
            }
            catch (Exception ex)
            {
                // Manejar cualquier excepción inesperada
                lblError.Text = "Ocurrió un error: " + ex.Message;
            }
        }
    }
}
        
        /*
        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            Auto auto = new Auto();

            auto.Id = int.Parse(txtId.Text);
            auto.Marca = txtMarca.Text;
            auto.Modelo = txtModelo.Text;
            auto.Descripcion = txtDescripcion.Text;
            auto.Color = ddlColores.SelectedValue;
            auto.Fecha = DateTime.Parse(txtFecha.Text);
            auto.usado = chkUsado.Checked;

            if (rdbImportado.Checked)
            {
                auto.Importado = true;
            }
            else if (rdbNacional.Checked)
            {
                auto.Importado = false;
            }

            List<Auto> temporal = Session["listaAutos"] as List<Auto>;
            if (temporal == null)
            {
                temporal = new List<Auto>();
                Session["listaAutos"] = temporal;
            }

            temporal.Add(auto);
            Session["listaAutos"] = temporal;

            Response.Redirect("Default.aspx");
        }
        */