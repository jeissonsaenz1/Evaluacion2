using Controlador.Vehiculo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Vista
{
    public partial class gestVehiculo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            int carid = Int32.Parse(txtId.Text);
            string carmarca = txtMarca.Text;
            string carmodelo = txtModelo.Text;
            string carplaca = txtPlaca.Text;
            int caranio = Int32.Parse(txtAnio.Text);
            int id_tv = Int32.Parse(txtId_tv.Text);

            logicaControladorVehiculo negocioAddVehiculo = new logicaControladorVehiculo();

            int resultadoAddVehiculo = negocioAddVehiculo.NegociarInsertVehiculo(carid, carmarca, carmodelo, carplaca, caranio, id_tv);
            if (resultadoAddVehiculo > 0)
                lblMensaje.Text = "Registro ok";
            else
                lblMensaje.Text = "No se pudo resgistrar";

            negocioAddVehiculo = null;
        }
        protected void btnList_Click(object sender, EventArgs e)
        {
            GridView.DataSource = logicaControladorVehiculo.NegociarSelectVehiculo();

            GridView.DataBind();

            txtId.Text = txtPlaca.Text = txtModelo.Text = txtPlaca.Text = txtAnio.Text = txtId_tv.Text = "";
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            int carid = Int32.Parse(txtId.Text);
            string carmarca = txtMarca.Text;
            string carmodelo = txtModelo.Text;
            string carplaca = txtPlaca.Text;
            int caranio = Int32.Parse(txtAnio.Text);
            int id_tv = Int32.Parse(txtId_tv.Text);

            logicaControladorVehiculo negocioUpdateVehiculo = new logicaControladorVehiculo();

            int resultadoUpdateVehiculo = negocioUpdateVehiculo.NegociarUpdateVehiculo(carid, carmarca, carmodelo, carplaca, caranio, id_tv);
            if (resultadoUpdateVehiculo > 0)
                lblMensaje.Text = "Actualizar ok";
            else
                lblMensaje.Text = "No se pudo actualizar";

            negocioUpdateVehiculo = null;
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            int carid = Int32.Parse(txtId.Text);
          
            logicaControladorVehiculo negocioDeleteVehiculo = new logicaControladorVehiculo();

            int resultadoDeleteVehiculo = negocioDeleteVehiculo.NegociarDeleteVehiculo(carid);
            if (resultadoDeleteVehiculo > 0)
                lblMensaje.Text = "Eliminar ok";
            else
                lblMensaje.Text = "No se pudo elimina";

            negocioDeleteVehiculo = null;
        }
    }
}