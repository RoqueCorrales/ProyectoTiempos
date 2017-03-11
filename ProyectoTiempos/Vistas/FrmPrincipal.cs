using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoTiempos.Vistas;
namespace ProyectoTiempos
{

    public partial class FrmPrincipal : Form
    {

        private FrmConfigCasa oConfigCasa;
        private FrmGanadores oGanadores;
        private FrmNumerosPremiados oPremiados;
        private FrmCrearSorteo oSorteos;
        private FrmAyuda oAyuda;
        private FrmVerSorteos oVerSorteos;
        private FrmJugar oJugar;
        public FrmPrincipal()
        {
            InitializeComponent();

        }
        public FrmPrincipal(Boolean privilegios)
        {
            InitializeComponent();
            configuracion.Visible = privilegios;


        }
        private bool HandleForm(Form currentForm)
        {
            if (this.MdiChildren.Contains(currentForm))
            {
                currentForm.WindowState = FormWindowState.Maximized;
                currentForm.Activate();
                return false;
            }
            return true;
        }
        private void configuracionDElaCasaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.HandleForm(this.oConfigCasa))
            {
                this.oConfigCasa = new FrmConfigCasa();
                oConfigCasa.MdiParent = this;
                oConfigCasa.Show();
            }
        }

        private void tablaDeGanadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.HandleForm(this.oGanadores))
            {
                this.oGanadores = new FrmGanadores();
                oGanadores.MdiParent = this;
                oGanadores.Show();
            }
        }

        private void numerosPremiadosEnSorteoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (this.HandleForm(this.oPremiados))
            {
                this.oPremiados = new FrmNumerosPremiados();
                oPremiados.MdiParent = this;
                oPremiados.Show();
            }
        }



        private void crearSorteoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.HandleForm(this.oSorteos))
            {
                this.oSorteos = new FrmCrearSorteo();
                oSorteos.MdiParent = this;
                oSorteos.Show();
            }

        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.HandleForm(this.oAyuda))
            {
                this.oAyuda = new FrmAyuda();
                oAyuda.MdiParent = this;
                oAyuda.Show();
            }
        }

        private void disponiblesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.HandleForm(this.oVerSorteos))
            {
                this.oVerSorteos = new FrmVerSorteos();
                oVerSorteos.MdiParent = this;
                oVerSorteos.Show();
            }
        }

        private void jugarToolStripMenuItem_Click(object sender, EventArgs e)

        {
            if (this.HandleForm(this.oJugar))
            {
                this.oJugar = new FrmJugar();
                oJugar.MdiParent = this;
                oJugar.Show();
            }
        }

        
    }
}
