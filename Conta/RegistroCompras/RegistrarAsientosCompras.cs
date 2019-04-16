﻿using ContaDAO;
using ContaDTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conta.RegistroCompras
{
    public partial class RegistrarAsientosCompras : Form
    {
        public static List<DocumentoCab> objListaDocumentoCab = new List<DocumentoCab>();
        public static RegistrarAsientosCompras AsientoCompraForm;
        DocumentoCab objDocumentoCab = new DocumentoCab();
        DocumentoDAO objDocumentoDao;
        public static List<UnidadNegocio> objListUnidadNegocio = new List<UnidadNegocio>();
        UnidadNegocio objUnidadNegocio;
        MonedaDAO objMonedaDao;
        public RegistrarAsientosCompras()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.Text = "Asientos Contables";
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(50, 20);
            AsientoCompraForm = this;
            objDocumentoDao = new DocumentoDAO();
            objMonedaDao = new MonedaDAO();
            objMonedaDao.tipoCambio();
            cargarcmb();
            gridParams();
            objListaDocumentoCab = objDocumentoDao.listarCompraAsientos(cmb_UnidadNegocio.SelectedValue.ToString());
            grd_Facturas.DataSource = objListaDocumentoCab;
            grd_Facturas.Refresh();
            cmb_UnidadNegocio.SelectedIndexChanged += Cmb_UnidadNegocio_SelectedIndexChanged;
            grd_Facturas.DoubleClick += Grd_Facturas_DoubleClick;
            grd_Facturas.Click += Grd_Facturas_Click;
        }

        private void Grd_Facturas_Click(object sender, EventArgs e)
        {
            int index = grd_Facturas.SelectedCells[0].RowIndex;
            objDocumentoCab = objListaDocumentoCab[index];
        }
        private void Grd_Facturas_DoubleClick(object sender, EventArgs e)
        {
            AsientoCCompra form = new AsientoCCompra(objDocumentoCab);

            form.Show();
            this.Close();
        }

        private void Cmb_UnidadNegocio_SelectedIndexChanged(object sender, EventArgs e)
        {
            grd_Facturas.DataSource = null;
            objListaDocumentoCab = objDocumentoDao.listarCompraAsientos( cmb_UnidadNegocio.SelectedValue.ToString());
            grd_Facturas.DataSource = objListaDocumentoCab;
            grd_Facturas.Refresh();
        }
        public void gridParams()
        {
            grd_Facturas.AutoGenerateColumns = false;
            DataGridViewTextBoxColumn idColumn1 = new DataGridViewTextBoxColumn();
            idColumn1.Name = "Serie";
            idColumn1.Width = 50;
            idColumn1.DataPropertyName = "DocumentoCabSerie";
            grd_Facturas.Columns.Add(idColumn1);
            DataGridViewTextBoxColumn idColumn100 = new DataGridViewTextBoxColumn();
            idColumn100.Name = "Número";
            idColumn100.DataPropertyName = "DocumentoCabNro";
            idColumn100.Width = 80;
            grd_Facturas.Columns.Add(idColumn100);
            DataGridViewTextBoxColumn idColumn2 = new DataGridViewTextBoxColumn();
            idColumn2.Name = "Fecha";
            idColumn2.DataPropertyName = "DocumentoCabFecha";
            idColumn2.Width = 80;
            grd_Facturas.Columns.Add(idColumn2);
            DataGridViewTextBoxColumn idColumn3 = new DataGridViewTextBoxColumn();
            idColumn3.Name = "Razón Social";
            idColumn3.DataPropertyName = "DocumentoCabCliente";
            idColumn3.Width = 300;
            grd_Facturas.Columns.Add(idColumn3);
            DataGridViewTextBoxColumn idColumn4 = new DataGridViewTextBoxColumn();
            idColumn4.Name = "RUC";
            idColumn4.DataPropertyName = "DocumentoCabClienteDocumento";
            idColumn4.Width = 100;
            grd_Facturas.Columns.Add(idColumn4);
            DataGridViewTextBoxColumn idColumn5 = new DataGridViewTextBoxColumn();
            idColumn5.Name = "Moneda";
            idColumn5.DataPropertyName = "DocumentoCabMoneda";
            idColumn5.Width = 100;
            grd_Facturas.Columns.Add(idColumn5);
            DataGridViewTextBoxColumn idColumn6 = new DataGridViewTextBoxColumn();
            idColumn6.Name = "Total";
            idColumn6.DataPropertyName = "DocumentoCabTotal";
            idColumn6.Width = 90;
            grd_Facturas.Columns.Add(idColumn6);


        }

        public void cargarcmb()
        {
            cmb_UnidadNegocio.DataSource = null;
            objListUnidadNegocio = null;
            objListUnidadNegocio = new List<UnidadNegocio>();
            objUnidadNegocio = new UnidadNegocio();
            objUnidadNegocio.Codigo = "01";
            objUnidadNegocio.Negocio = "METALES";
            objListUnidadNegocio.Add(objUnidadNegocio);
            objUnidadNegocio = null;
            objUnidadNegocio = new UnidadNegocio();
            objUnidadNegocio.Codigo = "02";
            objUnidadNegocio.Negocio = "GALVANIZADO";
            objListUnidadNegocio.Add(objUnidadNegocio);

            cmb_UnidadNegocio.DisplayMember = "Negocio";
            cmb_UnidadNegocio.ValueMember = "Codigo";
            cmb_UnidadNegocio.DataSource = objListUnidadNegocio;

        }
        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            ContabilidadMenu.formContabilidad.setEnabledItems("AC");
            this.Close();
        }

        private void cmb_UnidadNegocio_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
