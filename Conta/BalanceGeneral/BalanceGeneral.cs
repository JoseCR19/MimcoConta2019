using System;
using Conta;
using ContabilidadDTO;
using ContaDTO;
using ContaDAO;
using CrystalDecisions.Shared;
using Contabilidad;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contabilidad.BalanceGeneral
{
    public partial class BalanceGeneral : Form
    {
        public static List<BalanceGeneralReporte> objListBalance = new List<BalanceGeneralReporte>();
        AsientoDAO objAsientoDao;
        public String Anio2 = "";
        public String Mes2 = "";
        BalanceGeneral objGPN;
        public BalanceGeneral()
        {
            InitializeComponent();
            cmbAnio();
            cmbMes();
            objAsientoDao = new AsientoDAO();
        }
        void cmbMes()
        {
            List<MesDTO> objListMes = new List<MesDTO>();
            MesDTO objMes = new MesDTO();
            objMes.Month = "Enero";
            objMes.Value = "1";
            objListMes.Add(objMes);
            objMes = null;
            objMes = new MesDTO();
            objMes.Month = "Febrero";
            objMes.Value = "2";
            objListMes.Add(objMes);
            objMes = null;
            objMes = new MesDTO();
            objMes.Month = "Marzo";
            objMes.Value = "3";
            objListMes.Add(objMes);
            objMes = null;
            objMes = new MesDTO();
            objMes.Month = "Abril";
            objMes.Value = "4";
            objListMes.Add(objMes);
            objMes = null;
            objMes = new MesDTO();
            objMes.Month = "Mayo";
            objMes.Value = "5";
            objListMes.Add(objMes);
            objMes = null;
            objMes = new MesDTO();
            objMes.Month = "Junio";
            objMes.Value = "6";
            objListMes.Add(objMes);
            objMes = null;
            objMes = new MesDTO();
            objMes.Month = "Julio";
            objMes.Value = "7";
            objListMes.Add(objMes);
            objMes = null;
            objMes = new MesDTO();
            objMes.Month = "Agosto";
            objMes.Value = "8";
            objListMes.Add(objMes);
            objMes = null;
            objMes = new MesDTO();
            objMes.Month = "Septiembre";
            objMes.Value = "9";
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

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            ContabilidadMenu.formContabilidad.setEnabledItems("BG");
        }

        private void btn_excel_Click(object sender, EventArgs e)
        {
            
            Random r = new Random();
            String fileName = @"N:\Balance\EstadoFinancieroNaturaleza" + "-" + DateTime.Now.ToString("dd-MM-yyyy") + "-" + r.Next(1, 30) + ".xls";
            if(cmb_anio.SelectedValue.ToString()=="2019" && cmb_Mes.SelectedValue.ToString() == "1")
            {
               Anio2 = "2018";
               Mes2 = "12";
            }
            else if(cmb_Mes.SelectedValue.ToString() == "2")
            {
                Anio2 = "2019";
                Mes2 = "1";
            }
            else if (cmb_Mes.SelectedValue.ToString() == "3")
            {
                Anio2 = "2019";
                Mes2 = "2";
            }
            else if (cmb_Mes.SelectedValue.ToString() == "4")
            {
                Anio2 = "2019";
                Mes2 = "3";
            }
            else if (cmb_Mes.SelectedValue.ToString() == "5")
            {
                Anio2 = "2019";
                Mes2 = "4";
            }
            else if (cmb_Mes.SelectedValue.ToString() == "6")
            {
                Anio2 = "2019";
                Mes2 = "5";
            }
            else if (cmb_Mes.SelectedValue.ToString() == "7")
            {
                Anio2 = "2019";
                Mes2 = "6";
            }
            else if (cmb_Mes.SelectedValue.ToString() == "8")
            {
                Anio2 = "2019";
                Mes2 = "7";
            }
            else if (cmb_Mes.SelectedValue.ToString() == "9")
            {
                Anio2 = "2019";
                Mes2 = "8";
            }
            else if (cmb_Mes.SelectedValue.ToString() == "10")
            {
                Anio2 = "2019";
                Mes2 = "9";
            }
            else if (cmb_Mes.SelectedValue.ToString() == "11")
            {
                Anio2 = "2019";
                Mes2 = "10";
            }
            objListBalance = objAsientoDao.getBalanceGeneral(cmb_anio.SelectedValue.ToString(), cmb_Mes.SelectedValue.ToString(), Anio2.ToString(),Mes2.ToString());
            btn_excel.Enabled = false;
            Reporte.BalanceGeneral cr = new Reporte.BalanceGeneral();
            cr.SetDataSource(objListBalance);
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
    }
}
