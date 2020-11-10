using Controlador.Conductor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Vista
{
    public partial class gestConductor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            int carid = Int32.Parse(txtId.Text);
            string carname = txtName.Text;
            string cartipo_licencia = txtTipo_licencia.Text;
            int carid_vehiculo = Int32.Parse(txtId_vehiculo.Text);
            string carid_tipo_conductor = txtId_tipo_conductor.Text;

            logicaControladorConductor negocioAddConductor = new logicaControladorConductor();

            int resultadoAddConductor = negocioAddConductor.NegociarInsertConductor(carid, carname, cartipo_licencia, carid_vehiculo, carid_tipo_conductor);
            if (resultadoAddConductor > 0)
                lblMensaje.Text = "Registro ok";
            else
                lblMensaje.Text = "No se pudo resgistrar";

            negocioAddConductor = null;
        }
        protected void btnList_Click(object sender, EventArgs e)
        {
            GridView.DataSource = logicaControladorConductor.NegociarSelectConductor();

            GridView.DataBind();

            txtId.Text = txtName.Text = txtTipo_licencia.Text = txtId_vehiculo.Text = txtId_tipo_conductor.Text = "";
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            int carid = Int32.Parse(txtId.Text);
            string carname = txtName.Text;
            string cartipo_licencia = txtTipo_licencia.Text;
            int carid_vehiculo = Int32.Parse(txtId_vehiculo.Text);
            string carid_tipo_conductor = txtId_tipo_conductor.Text;

            logicaControladorConductor negocioUpdateConductor = new logicaControladorConductor();

            int resultadoUpdateConductor = negocioUpdateConductor.NegociarUpdateConductor(carid, carname, cartipo_licencia, carid_vehiculo, carid_tipo_conductor);
            if (resultadoUpdateConductor > 0)
                lblMensaje.Text = "Actualizar ok";
            else
                lblMensaje.Text = "No se pudo actualizar";

            negocioUpdateConductor = null;
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            int carid = Int32.Parse(txtId.Text);

            logicaControladorConductor negocioDeleteConductor = new logicaControladorConductor();

            int resultadoDeleteConductor = negocioDeleteConductor.NegociarDeleteConductor(carid);
            if (resultadoDeleteConductor > 0)
                lblMensaje.Text = "Eliminar ok";
            else
                lblMensaje.Text = "No se pudo elimina";

            negocioDeleteConductor = null;
        }
    }
}