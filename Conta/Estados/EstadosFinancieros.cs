using System;
using ContaDTO;
using CrystalDecisions.Shared;
using Conta;
using ContaDAO;
using Contabilidad;
using ContabilidadDTO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contabilidad.Estados
{
    public partial class EstadosFinancieros : Form
    {
        public static List<EstadoGananciasPerdidasNaturaleza> objListEGPN = new List<EstadoGananciasPerdidasNaturaleza>();
        EstadoGananciasPerdidasNaturaleza objn;
        public static List<EstadoGananciasPerdidasFunciones> objListEGPF = new List<EstadoGananciasPerdidasFunciones>();
        public static List<EstadoFlujoEfectivo> objListFE = new List<EstadoFlujoEfectivo>();
        AsientoDAO objAsientoDao;
        EstadoGananciasPerdidasNaturaleza objGPN;
        public EstadosFinancieros()
        {
            InitializeComponent();
            objn = new EstadoGananciasPerdidasNaturaleza();
            cmbMes();
            cmbAnio();
            cmbEstado();
            objAsientoDao = new AsientoDAO();
        }
        void cmbMes()
        {
            List<MesDTO> objListMes = new List<MesDTO>();
            MesDTO objMes = new MesDTO();
            objMes.Month = "Enero";
            objMes.Value = "01";
            objListMes.Add(objMes);
            objMes = null;
            objMes = new MesDTO();
            objMes.Month = "Febrero";
            objMes.Value = "02";
            objListMes.Add(objMes);
            objMes = null;
            objMes = new MesDTO();
            objMes.Month = "Marzo";
            objMes.Value = "03";
            objListMes.Add(objMes);
            objMes = null;
            objMes = new MesDTO();
            objMes.Month = "Abril";
            objMes.Value = "04";
            objListMes.Add(objMes);
            objMes = null;
            objMes = new MesDTO();
            objMes.Month = "Mayo";
            objMes.Value = "05";
            objListMes.Add(objMes);
            objMes = null;
            objMes = new MesDTO();
            objMes.Month = "Junio";
            objMes.Value = "06";
            objListMes.Add(objMes);
            objMes = null;
            objMes = new MesDTO();
            objMes.Month = "Julio";
            objMes.Value = "07";
            objListMes.Add(objMes);
            objMes = null;
            objMes = new MesDTO();
            objMes.Month = "Agosto";
            objMes.Value = "08";
            objListMes.Add(objMes);
            objMes = null;
            objMes = new MesDTO();
            objMes.Month = "Septiembre";
            objMes.Value = "09";
            objListMes.Add(objMes);
            objMes = null;
            objMes = new MesDTO();
            objMes.Month = "Octubre";
            objMes.Value = "10";
            objListMes.Add(objMes);
            objMes = null;
            objMes = new MesDTO();
            objMes.Month = "Noviembre";
            objMes.Value = "11";
            objListMes.Add(objMes);
            objMes = null;
            objMes = new MesDTO();
            objMes.Month = "Diciembre";
            objMes.Value = "12";
            objListMes.Add(objMes);
            cmb_Mes.DisplayMember = "Month";
            cmb_Mes.ValueMember = "Value";
            cmb_Mes.DataSource = objListMes;
            cmb_Mes.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        void cmbAnio()
        {
            List<MesDTO> objListMes = new List<MesDTO>();
            MesDTO objMes = new MesDTO();
            objMes.Month = "2018";
            objMes.Value = "2018";
            objListMes.Add(objMes);
            objMes = null;
            objMes = new MesDTO();
            objMes.Month = "2019";
            objMes.Value = "2019";
            objListMes.Add(objMes);
            objMes = null;
            objMes = new MesDTO();
            objMes.Month = "2020";
            objMes.Value = "03";
            objListMes.Add(objMes);
            objMes = null;
            objMes = new MesDTO();
            objMes.Month = "2021";
            objMes.Value = "2021";
            objListMes.Add(objMes);
            objMes = null;
            objMes = new MesDTO();
            objMes.Month = "2022";
            objMes.Value = "2022";
            objListMes.Add(objMes);
            objMes = null;
            objMes = new MesDTO();
            objMes.Month = "2023";
            objMes.Value = "2023";
            objListMes.Add(objMes);
            objMes = null;
            objMes = new MesDTO();
            objMes.Month = "2024";
            objMes.Value = "2024";
            objListMes.Add(objMes);
            cmb_anio.DisplayMember = "Month";
            cmb_anio.ValueMember = "Value";
            cmb_anio.DataSource = objListMes;
            cmb_anio.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        void cmbEstado()
        {
            List<MesDTO> objListMes = new List<MesDTO>();
            MesDTO objMes = new MesDTO();
            objMes.Month = "Estado Ganancias y Perdidas Por Naturaleza";
            objMes.Value = "01";
            objListMes.Add(objMes);
            objMes = null;
            objMes = new MesDTO();
            objMes.Month = "Estado Ganancias y Perdidas Por Función";
            objMes.Value = "02";
            objListMes.Add(objMes);
            objMes = null;
            objMes = new MesDTO();
            objMes.Month = "Estado de flujo de efectivo";
            objMes.Value = "03";
            objListMes.Add(objMes);
            objMes = new MesDTO();
            objMes.Month = "Balance de Comprobación";
            objMes.Value = "04";
            objListMes.Add(objMes);
            cmb_estado.DisplayMember = "Month";
            cmb_estado.ValueMember = "Value";
            cmb_estado.DataSource = objListMes;
            cmb_estado.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            ContabilidadMenu.formContabilidad.setEnabledItems("SF");
        }

        private void btn_excel_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            String fileName = @"N:\contabilidad_ef\EstadoFinancieroNaturaleza" + "-" + DateTime.Now.ToString("dd-MM-yyyy") + "-" + r.Next(1, 30) + ".xls";
            String fileName2 = @"N:\contabilidad_ef\EstadoFinancieroFuncion" + "-" + DateTime.Now.ToString("dd-MM-yyyy") + "-" + r.Next(1, 30) + ".xls";
            String fileName3 = @"N:\contabilidad_ef\EstadoFlujoEfectivo" + "-" + DateTime.Now.ToString("dd-MM-yyyy") + "-" + r.Next(1, 30) + ".xls";
            String fileName4 = @"N:\contabilidad_ef\BalanceComprobacion" + "-" + DateTime.Now.ToString("dd-MM-yyyy") + "-" + r.Next(1, 30) + ".xls";
            if (cmb_estado.SelectedValue.ToString()=="01")
            {
                objListEGPN = objAsientoDao.getEstadoGPNaturaleza(cmb_anio.SelectedValue.ToString(), cmb_Mes.SelectedValue.ToString());
                //objListEGPN.Sort(objn.Desc);
         
                btn_excel.Enabled = false;
                Reporte.GananciasPerdidasNaturaleza cr = new Reporte.GananciasPerdidasNaturaleza();
                cr.SetDataSource(objListEGPN);
                ExportOptions exportOpts = new ExportOptions();
                ExcelFormatOptions excelFormatOpts = new ExcelFormatOptions();
                DiskFileDestinationOptions diskOpts = new DiskFileDestinationOptions();
                exportOpts = cr.ExportOptions;

                // Set the excel format options.
                excelFormatOpts.ExcelUseConstantColumnWidth = true;
                excelFormatOpts.ExcelTabHasColumnHeadings = true;
                excelFormatOpts.ShowGridLines = true;
                excelFormatOpts.ExportPageBreaksForEachPage = true;
                //excelFormatOpts.UsePageRange = true;

                exportOpts.ExportFormatType = ExportFormatType.Excel;
                exportOpts.FormatOptions = excelFormatOpts;

                // Set the disk file options and export.
                exportOpts.ExportDestinationType = ExportDestinationType.DiskFile;
                diskOpts.DiskFileName = fileName;
                exportOpts.DestinationOptions = diskOpts;
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                cr.Export();
                btn_excel.Enabled = true;
            }
            else if(cmb_estado.SelectedValue.ToString() == "02")
            {
                objListEGPF = objAsientoDao.getEstadoGPFuncion(cmb_anio.SelectedValue.ToString(), cmb_Mes.SelectedValue.ToString());
                btn_excel.Enabled = false;
                Reporte.GananciasPerdidasFuncion cr = new Reporte.GananciasPerdidasFuncion();
                cr.SetDataSource(objListEGPF);
                ExportOptions exportOpts = new ExportOptions();
                ExcelFormatOptions excelFormatOpts = new ExcelFormatOptions();
                DiskFileDestinationOptions diskOpts = new DiskFileDestinationOptions();
                exportOpts = cr.ExportOptions;

                // Set the excel format options.
                excelFormatOpts.ExcelUseConstantColumnWidth = true;
                excelFormatOpts.ExcelTabHasColumnHeadings = true;
                excelFormatOpts.ShowGridLines = true;
                excelFormatOpts.ExportPageBreaksForEachPage = true;
                //excelFormatOpts.UsePageRange = true;

                exportOpts.ExportFormatType = ExportFormatType.Excel;
                exportOpts.FormatOptions = excelFormatOpts;

                // Set the disk file options and export.
                exportOpts.ExportDestinationType = ExportDestinationType.DiskFile;
                diskOpts.DiskFileName = fileName2;
                exportOpts.DestinationOptions = diskOpts;
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                cr.Export();
                btn_excel.Enabled = true;
            }
            else if(cmb_estado.SelectedValue.ToString()=="03")
            {
                objListFE = objAsientoDao.getEstadoFlujoEfectivo(cmb_anio.SelectedValue.ToString(), cmb_Mes.SelectedValue.ToString());
                btn_excel.Enabled = false;
                Reporte.EstadoFlujoEfectivo cr = new Reporte.EstadoFlujoEfectivo();
                cr.SetDataSource(objListFE);
                ExportOptions exportOpts = new ExportOptions();
                ExcelFormatOptions excelFormatOpts = new ExcelFormatOptions();
                DiskFileDestinationOptions diskOpts = new DiskFileDestinationOptions();
                exportOpts = cr.ExportOptions;

                // Set the excel format options.
                excelFormatOpts.ExcelUseConstantColumnWidth = true;
                excelFormatOpts.ExcelTabHasColumnHeadings = true;
                excelFormatOpts.ShowGridLines = true;
                excelFormatOpts.ExportPageBreaksForEachPage = true;
                //excelFormatOpts.UsePageRange = true;

                exportOpts.ExportFormatType = ExportFormatType.Excel;
                exportOpts.FormatOptions = excelFormatOpts;

                // Set the disk file options and export.
                exportOpts.ExportDestinationType = ExportDestinationType.DiskFile;
                diskOpts.DiskFileName = fileName3;
                exportOpts.DestinationOptions = diskOpts;
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                cr.Export();
                btn_excel.Enabled = true;
            }
            else if (cmb_estado.SelectedValue.ToString()=="04")
            {
                //objListFE = objAsientoDao.getEstadoFlujoEfectivo(cmb_anio.SelectedValue.ToString(), cmb_Mes.SelectedValue.ToString());
                btn_excel.Enabled = false;
                Reporte.BalanceComprobacion cr = new Reporte.BalanceComprobacion();
                //cr.SetDataSource(objListFE);
                ExportOptions exportOpts = new ExportOptions();
                ExcelFormatOptions excelFormatOpts = new ExcelFormatOptions();
                DiskFileDestinationOptions diskOpts = new DiskFileDestinationOptions();
                exportOpts = cr.ExportOptions;

                // Set the excel format options.
                excelFormatOpts.ExcelUseConstantColumnWidth = true;
                excelFormatOpts.ExcelTabHasColumnHeadings = true;
                excelFormatOpts.ShowGridLines = true;
                excelFormatOpts.ExportPageBreaksForEachPage = true;
                //excelFormatOpts.UsePageRange = true;

                exportOpts.ExportFormatType = ExportFormatType.Excel;
                exportOpts.FormatOptions = excelFormatOpts;

                // Set the disk file options and export.
                exportOpts.ExportDestinationType = ExportDestinationType.DiskFile;
                diskOpts.DiskFileName = fileName4;
                exportOpts.DestinationOptions = diskOpts;
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                cr.Export();
                btn_excel.Enabled = true;
            }
        }
    }
}
