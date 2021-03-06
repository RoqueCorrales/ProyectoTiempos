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
    public partial class FrmJugar : Form
    {
        private Modelo.Persona persona;
        private Sorteo sorteo;
        private DataTable result;
        private string codigo;
        private int id_sorteo;
        private Apuesta apuesta;
        private Casa casa;





        public FrmJugar()
        {
            InitializeComponent();
            sorteo = new Sorteo();
            result = new DataTable();
            cargarCombo();
            apuesta = new Apuesta();
            casa = new Casa();

        }
        public FrmJugar(Modelo.Persona persona)
        {
            InitializeComponent();
            sorteo = new Sorteo();
            result = new DataTable();
            cargarCombo();
            this.persona = persona;
            apuesta = new Apuesta();
            casa = new Casa();
        }
        public ComboBox cargarCombo()
        {
            result = this.sorteo.SelectSorteosEstadoTrue();

            for (int i = 0; i < result.Rows.Count; i++)
            {

                cbSorteo.Items.Add(result.Rows[i]["codigo"]);


            }
            if (this.sorteo.isError)
            {
                MessageBox.Show(this.sorteo.errorDescription);

            }

            return cbSorteo;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (validarMonto() > 0)
            {
                int numero = Convert.ToInt32(cbNumero.SelectedItem.ToString());
                double monto = validarMonto();
                apuesta.Insert(persona.id, id_sorteo, monto, numero);
                modificacionCasa();
                MessageBox.Show("Apuesta Realizada");
            }
            else
            {
                MessageBox.Show("Dinero invalido");
            }

        }

        public void buscarID()
        {
            result = this.sorteo.SelectCodigo(codigo);
            DataRow row = result.Rows[0];
            string id = row["id"].ToString();
            this.id_sorteo = Convert.ToInt32(id);
        }

        private void cbSorteo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Object selectedItem = cbSorteo.SelectedItem;
            codigo = selectedItem.ToString();
            buscarID();
        }

        private double validarMonto()
        {
            double monto = 0;
            try
            {
                monto = Convert.ToDouble(txtMontoApuesta.Text);
            }
            catch (Exception e)
            {
                MessageBox.Show("Digite un monto valido");
            }


            return monto;
        }
        private void Vaciar()
        {
            cbSorteo.SelectedIndex = -1;
            cbNumero.SelectedIndex = -1;
            txtMontoApuesta.Text = "";
           // if (string.IsNullOrEmpty(txtMontoApuesta.ToString())) ;
        }


        private void modificacionCasa()
        {
            DataTable tabla = casa.Select();
            DataRow row = tabla.Rows[0];
            validarMonto();
            int id = Convert.ToInt32(row["id"].ToString());
            string nombre = row["nombre"].ToString();
            double dinero = Convert.ToDouble(row["dinero"].ToString());
            dinero = dinero + Convert.ToDouble(txtMontoApuesta.Text);
            casa.Update(id, nombre, dinero);


        }

    }
}
