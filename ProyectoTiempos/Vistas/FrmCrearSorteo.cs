﻿using ProyectoTiempos.Controladores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoTiempos.Vistas
{
    public partial class FrmCrearSorteo : Form
    {
        
        private Serial serial;
        private Sorteo sorteo;
        public FrmCrearSorteo()
        {

            InitializeComponent();
            serial = new Serial();
            sorteo = new Sorteo();
             Refrescar();
           
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            lblSerial.Text = serial.sacarSerial();
            
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            Modelo.Apuesta apuesta = new Modelo.Apuesta()
            {
                errorDescription = txtDescripcion.Text
            };

            DateTime fecha = dtHora.Value.Date +
                    dtHora.Value.TimeOfDay;
            MessageBox.Show(fecha.ToString());
         
            string descripcion = txtDescripcion.Text;
            string codigo = lblSerial.Text;
            Boolean estado = false;
            if (rbHabilitar.Checked)
            {
                estado = true;
            }
            MessageBox.Show(Convert.ToString(estado));

            sorteo.Insert(descripcion, codigo, fecha, estado);
            Refrescar();

        }
        private void Refrescar()
        {
            DataTable result = new DataTable();
            result = this.sorteo.Select();
            if (this.sorteo.isError)
            {
                MessageBox.Show(this.sorteo.errorDescription);
                return;
            }
            this.dtgSorteo.DataSource = result;
        }

        private void btnHabilitar_Click(object sender, EventArgs e)
        {
            
        }

        private void dtgSorteo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(this.dtgSorteo.CurrentRow.Cells[0].Value.ToString());
            string descripcion = this.dtgSorteo.CurrentRow.Cells[1].Value.ToString();
            txtDescripcion.Text = descripcion;
            DateTime fecha = DateTime.Parse(this.dtgSorteo.CurrentRow.Cells[2].Value.ToString());
            dtHora.Value = fecha;
            Boolean estado = Convert.ToBoolean(this.dtgSorteo.CurrentRow.Cells[3].Value.ToString()); ;
            if (estado)
            {
                rbHabilitar.Select();
            }else
            {
                rbDeshabilitar.Select();
            }
            string codigo = this.dtgSorteo.CurrentRow.Cells[4].Value.ToString();
            lblSerial.Text = codigo;
           // this.sorteo.Update(id, descripcion, fecha, estado, codigo);
            if (this.sorteo.isError)
            {
                MessageBox.Show(this.sorteo.errorDescription);
                return;
            }
        }
    }
}
