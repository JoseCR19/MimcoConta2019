﻿using ContaDAO;
using ContaDTO;
using System;
using System.Collections.Generic;
using Conta.PlanDeCuenta;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conta.RegistroCompras
{
    public partial class AsientoCCompra : Form
    {
        public static DocumentoCab objDocumentoCab = new DocumentoCab();
        public static AsientoCCompra formAsientoCompra;
        Asiento objAsiento;
        static int index;
        public static List<AsientoDetalle> objListaAsientoDetalle = new List<AsientoDetalle>();
        AsientoDAO objAsientoDao;
        AsientoDetalle objAsientoDetalle;
        String Operacion = "Q";
        public AsientoCCompra(DocumentoCab obj)
        {
            InitializeComponent();
            this.ControlBox = false;
            formAsientoCompra = this;
            this.Text = "Asientos Contables";
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(50, 20);
            objAsiento = new Asiento();
            objAsientoDao = new AsientoDAO();
            txt_TipoAsiento.Text = "11";
            objDocumentoCab = obj;
            txt_Correlativo.Text = objAsientoDao.getCorrelativoAsientoVenta(objDocumentoCab.DocumentoCabFecha.ToString("dd/MM/yyyy"), txt_TipoAsiento.Text);
            txt_Fecha.Text = objDocumentoCab.DocumentoCabFecha.ToString("dd/MM/yyyy");
            txt_Moneda.Text = objDocumentoCab.DocumentoCabMoneda;
            txt_glosa.Text = objDocumentoCab.DocumentoCabTipoDoc.ToString().Trim() + " " + objDocumentoCab.DocumentoCabSerie.ToString() + " " + objDocumentoCab.DocumentoCabNro.ToString();
            txt_cliente.Text = objDocumentoCab.DocumentoCabCliente.ToString().Trim();
            //txt_Haber.Text = objDocumentoCab.DocumentoCabTotal.ToString("C").Substring(3);
            //txt_Debe.Text = objDocumentoCab.DocumentoCabTotal.ToString("C").Substring(3);
            gridParams();
            cmbCuenta();
            cmbDocumento();
            /*este if es para cuando es una nea y cuando el servicio no estaba registrando con detalle*/
            if(objDocumentoCab.tipreg=="0")
            {
                objListaAsientoDetalle = objAsientoDao.getGenerarDetalleCompra(objDocumentoCab.NumeroRegistro);
                if (objListaAsientoDetalle.Count > 2)
                {
                    grd_Facturas.DataSource = objListaAsientoDetalle;
                }
                else
                {
                    objListaAsientoDetalle = objAsientoDao.getGenerarDetalleCompraServicio(objDocumentoCab.NumeroRegistro);
                    grd_Facturas.DataSource = objListaAsientoDetalle;
                }
            }
            if(objDocumentoCab.tipreg == "1")
            {
                objListaAsientoDetalle = objAsientoDao.getGenerarDetalleCompraServicio1(objDocumentoCab.NumeroRegistro);
                if (objListaAsientoDetalle.Count > 2)
                {
                    grd_Facturas.DataSource = objListaAsientoDetalle;
                }
                else
                {
                    objListaAsientoDetalle = objAsientoDao.getGenerarDetalleCompraServicio2(objDocumentoCab.NumeroRegistro);
                    grd_Facturas.DataSource = objListaAsientoDetalle;
                }
            }
            grd_Facturas.CellClick += Grd_Facturas_CellClick;
            grd_Facturas.Refresh();
            sumatorias();
        }
        private void Grd_Facturas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = grd_Facturas.SelectedCells[0].RowIndex;
            objAsientoDetalle = new AsientoDetalle();
            objAsientoDetalle = objListaAsientoDetalle[index];
            txt_Cuenta.Text = objAsientoDetalle.Cuenta;
            txt_Documento.Text = objAsientoDetalle.Documento;
            txt_Importe.Text = objAsientoDetalle.Importe.ToString();
            cmb_Cuenta.SelectedValue = objAsientoDetalle.TipoImporte;
            cmb_Documento.SelectedValue = objAsientoDetalle.TipDocCodigo;
            txt_cuentadescripcion.Text = objAsientoDetalle.CuentaDescripcion.ToString();
            txt_ot.Text = objAsientoDetalle.CodoOt.ToString();
            
        }
        public void gridParams()
        {
            grd_Facturas.AutoGenerateColumns = false;
            DataGridViewTextBoxColumn idColumn0 = new DataGridViewTextBoxColumn();
            idColumn0.Name = "Cuenta";
            idColumn0.Width = 60;
            idColumn0.DataPropertyName = "Cuenta";
            grd_Facturas.Columns.Add(idColumn0);
            DataGridViewTextBoxColumn idColumn8 = new DataGridViewTextBoxColumn();
            idColumn8.Name = "Anexo";
            idColumn8.Width = 80;
            idColumn8.DataPropertyName = "Anexo";
            grd_Facturas.Columns.Add(idColumn8);
            DataGridViewTextBoxColumn idColumn1 = new DataGridViewTextBoxColumn();
            idColumn1.Name = "Tipo";
            idColumn1.Width = 40;
            idColumn1.DataPropertyName = "TipoImporte";
            grd_Facturas.Columns.Add(idColumn1);
            DataGridViewTextBoxColumn idColumn2 = new DataGridViewTextBoxColumn();
            idColumn2.Name = "Importe";
            idColumn2.Width = 100;
            idColumn2.DataPropertyName = "Importe";
            grd_Facturas.Columns.Add(idColumn2);
            DataGridViewTextBoxColumn idColumn3 = new DataGridViewTextBoxColumn();
            idColumn3.Name = "Tipo Documento";
            idColumn3.Width = 120;
            idColumn3.DataPropertyName = "TipoDoc";
            grd_Facturas.Columns.Add(idColumn3);
            DataGridViewTextBoxColumn idColumn4 = new DataGridViewTextBoxColumn();
            idColumn4.Name = "Documento";
            idColumn4.Width = 120;
            idColumn4.DataPropertyName = "Documento";
            grd_Facturas.Columns.Add(idColumn4);
            DataGridViewTextBoxColumn idColumn5 = new DataGridViewTextBoxColumn();
            idColumn5.Name = "Fecha";
            idColumn5.Width = 80;
            idColumn5.DataPropertyName = "Fecha";
            grd_Facturas.Columns.Add(idColumn5);
            DataGridViewTextBoxColumn idColumn6 = new DataGridViewTextBoxColumn();
            idColumn6.Name = "Fecha Vcto";
            idColumn6.Width = 80;
            idColumn6.DataPropertyName = "FechaVcto";
            grd_Facturas.Columns.Add(idColumn6);
            DataGridViewTextBoxColumn idColumn7 = new DataGridViewTextBoxColumn();
            idColumn7.Name = "CodOt";
            idColumn7.Width = 80;
            idColumn7.DataPropertyName = "CodoOt";
            grd_Facturas.Columns.Add(idColumn7);

        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            RegistrarAsientosCompras formAsient = new RegistrarAsientosCompras();
            formAsient.Show();
            this.Close();
        }

        private void btn_SaveData_Click(object sender, EventArgs e)
        {
            btn_SaveData.Enabled = false;
            bool insert, insertDet = false;
            objAsiento = new Asiento();
            objAsiento.Correlativo = txt_Correlativo.Text;
            objAsiento.Debe = objAsientoDao.convertToDouble(txt_Debe.Text);
            objAsiento.Fecha = txt_Fecha.Text;
            objAsiento.Haber = objAsientoDao.convertToDouble(txt_Haber.Text);
            objAsiento.MonedaCod = objDocumentoCab.DocumentoCabTipoMoneda;


            objAsiento.TipoAsiento = txt_TipoAsiento.Text;

            insert = objAsientoDao.insertarAsientoCab(objAsiento);
            if (insert)
            {

            }
            else
            {
                MessageBox.Show("Hubo un error al Guardar");
                return;
            }
            for (int i = 0; i < objListaAsientoDetalle.Count; i++)
            {
                objListaAsientoDetalle[i].NumReg = objDocumentoCab.NumeroRegistro;
                objListaAsientoDetalle[i].Correlativo = txt_Correlativo.Text;
                objListaAsientoDetalle[i].FechaDoc = objDocumentoCab.DocumentoCabFecha.ToString("dd/MM/yyyy");
                objListaAsientoDetalle[i].Anexo = objDocumentoCab.DocumentoCabClienteDocumento;
                insertDet = objAsientoDao.insertarAsientoDet(objListaAsientoDetalle[i]);
                if (insertDet)
                {
                   
                    objAsientoDao.updateEstadoAsientoCompra(objListaAsientoDetalle[i].NumReg);
                }
                else
                {
                    MessageBox.Show("Hubo un error al Guardar");
                    return;
                }
            }
            if (insertDet)
            {
                MessageBox.Show("Se creó el Asiento Contable");
            }
            btn_SaveData.Enabled = true;
            RegistrarAsientosCompras formAsient = new RegistrarAsientosCompras();
            formAsient.Show();
            this.Close();
        }
        void cmbCuenta()
        {
            List<TipoCuenta> objListCuenta = new List<TipoCuenta>();
            TipoCuenta objCuenta = new TipoCuenta();
            objCuenta.Id = "D";
            objCuenta.Descripcion = "Debe";
            objListCuenta.Add(objCuenta);
            objCuenta = new TipoCuenta();
            objCuenta.Id = "H";
            objCuenta.Descripcion = "Haber";
            objListCuenta.Add(objCuenta);
            cmb_Cuenta.DataSource = objListCuenta;
            cmb_Cuenta.ValueMember = "Id";
            cmb_Cuenta.DisplayMember = "Descripcion";
            cmb_Cuenta.Refresh();

        }
        void cmbDocumento()
        {
            List<TipoDocumentoContabilidad> objListTipDocu = new List<TipoDocumentoContabilidad>();
            TipoDocumentoContabilidad obj = new TipoDocumentoContabilidad();
            obj.Codigo = "01";
            obj.Descripcion = "Factura";
            objListTipDocu.Add(obj);
            obj = new TipoDocumentoContabilidad();
            obj.Codigo = "03";
            obj.Descripcion = "Boleta";
            objListTipDocu.Add(obj);
            obj = new TipoDocumentoContabilidad();
            obj.Codigo = "07";
            obj.Descripcion = "Nota de Crédito";
            objListTipDocu.Add(obj);
            obj = new TipoDocumentoContabilidad();
            obj.Codigo = "08";
            obj.Descripcion = "Nota de Débito";
            objListTipDocu.Add(obj);

            cmb_Documento.DataSource = objListTipDocu;
            cmb_Documento.ValueMember = "Codigo";
            cmb_Documento.DisplayMember = "Descripcion";
            cmb_Documento.Refresh();

        }
        private void btn_Editar_Click(object sender, EventArgs e)
        {
            Operacion = "M";
            habilitarCampos(true);
            habilitaBoton(false, true);
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            Operacion = "N";
            habilitarCampos(true);
            habilitaBoton(false, true);
            limpiaCampos();
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {

            objAsientoDetalle = new AsientoDetalle();
            objAsientoDetalle.Anexo = objDocumentoCab.DocumentoCabClienteDocumento;
            objAsientoDetalle.Correlativo = txt_Correlativo.Text;
            objAsientoDetalle.Cuenta = txt_Cuenta.Text;
            objAsientoDetalle.Documento = txt_Documento.Text;
            objAsientoDetalle.Fecha = txt_Fecha.Text;
            objAsientoDetalle.FechaDoc = objDocumentoCab.DocumentoCabFecha.ToString("dd/MM/yyyy");
            objAsientoDetalle.FechaVcto = objDocumentoCab.DocumentoCabFechaVcto.ToString("dd/MM/yyyy");
            objAsientoDetalle.Importe = objAsientoDao.convertToDouble( txt_Importe.Text);
            objAsientoDetalle.NumReg = objDocumentoCab.NumeroRegistro;
            objAsientoDetalle.TipDocCodigo = cmb_Documento.SelectedValue.ToString();
            objAsientoDetalle.TipoImporte = cmb_Cuenta.SelectedValue.ToString();
            objAsientoDetalle.TipoDoc = cmb_Documento.Text;
            objAsientoDetalle.CodoOt = txt_ot.Text;
            if (Operacion=="M")
            {
                objListaAsientoDetalle[index] = objAsientoDetalle;
            }else
            {
                objListaAsientoDetalle.Add(objAsientoDetalle);
            }
            limpiaCampos();
            grd_Facturas.DataSource = null;
            grd_Facturas.DataSource = objListaAsientoDetalle;
            grd_Facturas.Refresh();
            sumatorias();
            habilitaBoton(true, false);
            habilitarCampos(false);
        }
        void habilitarCampos(bool bhabilita)
        {
            txt_Cuenta.Enabled = bhabilita;
            txt_Importe.Enabled = bhabilita;
            cmb_Cuenta.Enabled = bhabilita;
            cmb_Documento.Enabled = bhabilita;
            txt_Documento.Enabled = bhabilita;
        }
        void limpiaCampos()
        {
            txt_Cuenta.Text = "";
            txt_Importe.Text = "";
            
            txt_Documento.Text = "";
        }
        void habilitaBoton(bool bhabilita1, bool bhabilita2)
        {
            btn_Add.Enabled = bhabilita1;
            btn_Guardar.Enabled = bhabilita2;
            btn_Editar.Enabled = bhabilita1;
        }
        void sumatorias()
        {
            List<AsientoDetalle> objListSumD = new List<AsientoDetalle>();
            List<AsientoDetalle> objListSumH = new List<AsientoDetalle>();
            objListSumD= objListaAsientoDetalle;
            objListSumH = objListaAsientoDetalle;
            txt_Debe.Text = objListSumD.Where(x => x.TipoImporte == "D").Sum( y=> y.Importe).ToString();
            txt_Haber.Text = objListSumH.Where(x => x.TipoImporte == "H").Sum(y => y.Importe).ToString();
        }

        private void txt_Cuenta_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                PlanDeCuenta.MantenimientoPlanContable check = new PlanDeCuenta.MantenimientoPlanContable("V");
                check.Show();
            }
        }
        public void setSolicitaCuenta(String cuenta, String descripcion)
        {
            txt_Cuenta.Text = cuenta;
            txt_cuentadescripcion.Text = descripcion;
        }
    }
}
