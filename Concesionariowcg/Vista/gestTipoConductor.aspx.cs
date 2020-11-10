using Controlador.TipoConductor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Vista
{
    public partial class gestTipoConductor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            int cartypeid = Int32.Parse(txtId.Text);
            string typename = txtTipo_Persona.Text;

            logicaControladorTipoConductor negocioAddTipoConductor = new logicaControladorTipoConductor();

            int resultadoAddTipoConductor = negocioAddTipoConductor.NegociarInsertTipoConductor(cartypeid, typename);
            if (resultadoAddTipoConductor > 0)
                lblMensaje.Text = "Registro ok";
            else
                lblMensaje.Text = "No se pudo resgistrar";

            negocioAddTipoConductor = null;
        }

        protected void btnList_Click(object sender, EventArgs e)
        {
            GridView.DataSource = logicaControladorTipoConductor.NegociarSelectTipoConductor();

            GridView.DataBind();

            txtId.Text = txtTipo_Persona.Text = "";
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            int cartypeid = Int32.Parse(txtId.Text);
            string typetipo_persona = txtTipo_Persona.Text;

            logicaControladorTipoConductor negocioUpdateTipoConductor = new logicaControladorTipoConductor();

            int resultadoUpdateTipoConductor = negocioUpdateTipoConductor.NegociarUpdateTipoConductor(cartypeid, typetipo_persona);
            if (resultadoUpdateTipoConductor > 0)
                lblMensaje.Text = "Actualizar ok";
            else
                lblMensaje.Text = "No se pudo actualizar";

            negocioUpdateTipoConductor = null;
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            int cartypeid = Int32.Parse(txtId.Text);

            logicaControladorTipoConductor negocioDeleteTipoConductor = new logicaControladorTipoConductor();

            int resultadoDeleteTipoConductor = negocioDeleteTipoConductor.NegociarDeleteTipoConductor(cartypeid);
            if (resultadoDeleteTipoConductor > 0)
                lblMensaje.Text = "Eliminar ok";
            else
                lblMensaje.Text = "No se pudo elimina";

            negocioDeleteTipoConductor = null;
        }
    }
}