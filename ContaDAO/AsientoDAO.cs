using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContaDTO;
using ContabilidadDTO;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Data;
using System.Data.Common;
using System.Globalization;
using System.Threading;


namespace ContaDAO
{
    public class AsientoDAO
    {
        Conexion _Conexion = new Conexion("Contabilidad");
        public String getCorrelativoAsientoVenta(String Fecha, String Tipo)
        {
            String aux="";
            Database db = DatabaseFactory.CreateDatabase("Contabilidad");
            DbCommand dbCommand = db.GetStoredProcCommand("sp_getAsientoCorrelativo",
                   new object[] { Fecha, Tipo });
            using (IDataReader dataReader = db.ExecuteReader(dbCommand))
            {
                while (dataReader.Read())
                {
                    aux = dataReader["correlativo"].ToString();
                }
            }
            return aux;
        }
        public List<AsientoDetalle> getGenerarDetalleValidar(String serie, String numero)
        {
            List<AsientoDetalle> objList = new List<AsientoDetalle>();
            AsientoDetalle obj;
            Database db = DatabaseFactory.CreateDatabase("Contabilidad");
            /*procedimiento almacenado*/
            DbCommand dbCommand = db.GetStoredProcCommand("sp_GenerarAsientoVentaValidar",
                   new object[] { serie, numero });
            using (IDataReader dataReader = db.ExecuteReader(dbCommand))
            {
                while (dataReader.Read())
                {
                    obj = new AsientoDetalle();
                    obj.numeroot = Convert.ToInt32(dataReader["suma"].ToString());
                    obj.CodoOt = dataReader["codot"].ToString();
                    objList.Add(obj);
                }
            }
            return objList;
        }
        /*procedimiento para poder listar las facturas que posteriormente se ejecutaran como asientos*/
        public List<AsientoDetalle> getGenerarDetalle(String serie, String numero)
        {
            List<AsientoDetalle> objList = new List<AsientoDetalle>();
            AsientoDetalle obj;
            Database db = DatabaseFactory.CreateDatabase("Contabilidad");
            /*procedimiento almacenado*/
            DbCommand dbCommand = db.GetStoredProcCommand("sp_GenerarAsientoVenta",
                   new object[] { serie, numero });
            using (IDataReader dataReader = db.ExecuteReader(dbCommand))
            {
                while (dataReader.Read())
                {
                    obj = new AsientoDetalle();
                    obj.Cuenta = dataReader["Cuenta"].ToString();
                    obj.Anexo = dataReader["RucCli"].ToString();
                    obj.TipoImporte = dataReader["TipoImporte"].ToString();
                    obj.Importe = convertToDouble(dataReader["Importe"].ToString());
                    obj.TipoDoc = dataReader["TipDoc"].ToString();
                    obj.Fecha = dataReader["Fecha"].ToString();
                    obj.Documento = dataReader["Documento"].ToString();
                    obj.FechaVcto = dataReader["FechaVcto"].ToString();
                    obj.TipDocCodigo = dataReader["DocCod"].ToString();
                    obj.TipoAsiento = "05";
                    obj.CodoOt = dataReader["CodOt"].ToString();
                    obj.CuentaDescripcion = dataReader["DescripcionCuenta"].ToString();
                    objList.Add(obj);
                }
            }
            return objList;
        }
        public List<AsientoDetalle> getGenerarDetalleCentroCosto(String serie, String numero)
        {
            List<AsientoDetalle> objList = new List<AsientoDetalle>();
            AsientoDetalle obj;
            Database db = DatabaseFactory.CreateDatabase("Contabilidad");
            /*procedimiento almacenado*/
            DbCommand dbCommand = db.GetStoredProcCommand("sp_GenerarAsientoVentaCentroCosto",
                   new object[] { serie, numero });
            using (IDataReader dataReader = db.ExecuteReader(dbCommand))
            {
                while (dataReader.Read())
                {
                    obj = new AsientoDetalle();
                    obj.Cuenta = dataReader["Cuenta"].ToString();
                    obj.TipoImporte = dataReader["TipoImporte"].ToString();
                    obj.Importe = convertToDouble(dataReader["Importe"].ToString());
                    obj.TipoDoc = dataReader["TipDoc"].ToString();
                    obj.Fecha = dataReader["Fecha"].ToString();
                    obj.Documento = dataReader["Documento"].ToString();
                    obj.FechaVcto = dataReader["FechaVcto"].ToString();
                    obj.TipDocCodigo = dataReader["DocCod"].ToString();
                    obj.TipoAsiento = "05";
                    obj.Anexo = "";
                    objList.Add(obj);
                }
            }
            return objList;
        }
        public List<AsientoDetalle> getGenerarDetalleCompra(String numeroRegistro)
        {
            List<AsientoDetalle> objList = new List<AsientoDetalle>();
            AsientoDetalle obj;
            Database db = DatabaseFactory.CreateDatabase("Contabilidad");
            DbCommand dbCommand = db.GetStoredProcCommand("sp_GenerarCompraAsiento",
                   new object[] { numeroRegistro });
            using (IDataReader dataReader = db.ExecuteReader(dbCommand))
            {
                while (dataReader.Read())
                {
                    obj = new AsientoDetalle();
                    obj.Cuenta = dataReader["Cuenta"].ToString();
                    obj.TipoImporte = dataReader["TipoImporte"].ToString();
                    obj.Importe = convertToDouble(dataReader["Importe"].ToString());
                    obj.TipoDoc = dataReader["TipDoc"].ToString();
                    obj.Fecha = dataReader["Fecha"].ToString();
                    obj.Documento = dataReader["Documento"].ToString();
                    obj.FechaVcto = dataReader["FechaVcto"].ToString();
                    obj.TipDocCodigo = dataReader["DocCod"].ToString();
                    obj.TipoAsiento = "11";
                    obj.Anexo = dataReader["rucprov"].ToString();
                    obj.CodoOt = dataReader["CodOt"].ToString();
                    obj.CuentaDescripcion = dataReader["DescripcionCuenta"].ToString();
                    objList.Add(obj);
                }
            }
            return objList;
        }
        public List<AsientoDetalle> getGenerarDetalleCompraServicio1(String numeroRegistro)
        {
            List<AsientoDetalle> objList = new List<AsientoDetalle>();
            AsientoDetalle obj;
            Database db = DatabaseFactory.CreateDatabase("Contabilidad");
            DbCommand dbCommand = db.GetStoredProcCommand("sp_GenerarCompraAsientoServicio1",
                   new object[] { numeroRegistro });
            using (IDataReader dataReader = db.ExecuteReader(dbCommand))
            {
                while (dataReader.Read())
                {
                    obj = new AsientoDetalle();
                    obj.Cuenta = dataReader["Cuenta"].ToString();
                    obj.TipoImporte = dataReader["TipoImporte"].ToString();
                    obj.Importe = convertToDouble(dataReader["Importe"].ToString());
                    obj.TipoDoc = dataReader["TipDoc"].ToString();
                    obj.Fecha = dataReader["Fecha"].ToString();
                    obj.Documento = dataReader["Documento"].ToString();
                    obj.FechaVcto = dataReader["FechaVcto"].ToString();
                    obj.TipDocCodigo = dataReader["DocCod"].ToString();
                    obj.TipoAsiento = "11";
                    obj.CodoOt = dataReader["CodOt"].ToString();
                    obj.CuentaDescripcion = dataReader["DescripcionCuenta"].ToString();
                    objList.Add(obj);
                }
            }
            return objList;
        }
        public List<AsientoDetalle> getGenerarDetalleCompraServicio(String numeroRegistro)
        {
            List<AsientoDetalle> objList = new List<AsientoDetalle>();
            AsientoDetalle obj;
            Database db = DatabaseFactory.CreateDatabase("Contabilidad");
            DbCommand dbCommand = db.GetStoredProcCommand("sp_GenerarCompraAsientoServicio",
                   new object[] { numeroRegistro });
            using (IDataReader dataReader = db.ExecuteReader(dbCommand))
            {
                while (dataReader.Read())
                {
                    obj = new AsientoDetalle();
                    obj.Cuenta = dataReader["Cuenta"].ToString();
                    obj.TipoImporte = dataReader["TipoImporte"].ToString();
                    obj.Importe = convertToDouble(dataReader["Importe"].ToString());
                    obj.TipoDoc = dataReader["TipDoc"].ToString();
                    obj.Fecha = dataReader["Fecha"].ToString();
                    obj.Documento = dataReader["Documento"].ToString();
                    obj.FechaVcto = dataReader["FechaVcto"].ToString();
                    obj.TipDocCodigo = dataReader["DocCod"].ToString();
                    obj.TipoAsiento = "11";
                    obj.CodoOt = dataReader["CodOt"].ToString();
                    obj.CuentaDescripcion = dataReader["DescripcionCuenta"].ToString();
                    objList.Add(obj);
                }
            }
            return objList;
        }
        public List<AsientoDetalle> getGenerarDetalleCompraServicio2(String numeroRegistro)
        {
            List<AsientoDetalle> objList = new List<AsientoDetalle>();
            AsientoDetalle obj;
            Database db = DatabaseFactory.CreateDatabase("Contabilidad");
            DbCommand dbCommand = db.GetStoredProcCommand("sp_GenerarCompraAsientoDetalleServicio1",
                   new object[] { numeroRegistro });
            using (IDataReader dataReader = db.ExecuteReader(dbCommand))
            {
                while (dataReader.Read())
                {
                    obj = new AsientoDetalle();
                    obj.Cuenta = dataReader["Cuenta"].ToString();
                    obj.TipoImporte = dataReader["TipoImporte"].ToString();
                    obj.Importe = convertToDouble(dataReader["Importe"].ToString());
                    obj.TipoDoc = dataReader["TipDoc"].ToString();
                    obj.Fecha = dataReader["Fecha"].ToString();
                    obj.Documento = dataReader["Documento"].ToString();
                    obj.FechaVcto = dataReader["FechaVcto"].ToString();
                    obj.TipDocCodigo = dataReader["DocCod"].ToString();
                    obj.TipoAsiento = "11";
                    obj.CodoOt = dataReader["CodOt"].ToString();
                    obj.CuentaDescripcion = dataReader["DescripcionCuenta"].ToString();
                    objList.Add(obj);
                }
            }
            return objList;
        }
        public List<AsientoDetalle> getGenerarDetalleCaja(String nrocaja, int nrooperacion,String codent)
        {
            List<AsientoDetalle> objList = new List<AsientoDetalle>();
            AsientoDetalle obj;
            Database db = DatabaseFactory.CreateDatabase("Contabilidad");
            DbCommand dbCommand = db.GetStoredProcCommand("sp_DetalleCajaAsiento",
                   new object[] { nrocaja, nrooperacion, codent });
            using (IDataReader dataReader = db.ExecuteReader(dbCommand))
            {
                while (dataReader.Read())
                {
                    obj = new AsientoDetalle();
                    obj.Cuenta = dataReader["Cuenta"].ToString();
                    obj.TipoImporte = dataReader["TipoImporte"].ToString();
                    obj.Importe = convertToDouble(dataReader["Importe"].ToString());
                    obj.TipoDoc = dataReader["TipDoc"].ToString();
                    obj.Fecha = dataReader["Fecha"].ToString();
                    obj.Documento = dataReader["Documento"].ToString();
                    obj.FechaVcto = dataReader["FechaVcto"].ToString();
                    obj.TipDocCodigo = dataReader["DocCod"].ToString();
                    obj.TipoAsiento = "01";
                    obj.Anexo = "";
                    objList.Add(obj);
                }
            }
            return objList;
        }
        public List<AsientoDetalle> getGenerarDetalleVoucher(String nroVoucher)
        {
            List<AsientoDetalle> objList = new List<AsientoDetalle>();
            AsientoDetalle obj;
            Database db = DatabaseFactory.CreateDatabase("Contabilidad");
            DbCommand dbCommand = db.GetStoredProcCommand("sp_DetalleVoucherAsiento",
                   new object[] { nroVoucher});
            using (IDataReader dataReader = db.ExecuteReader(dbCommand))
            {
                while (dataReader.Read())
                {
                    obj = new AsientoDetalle();
                    obj.Cuenta = dataReader["Cuenta"].ToString();
                    obj.TipoImporte = dataReader["TipoImporte"].ToString();
                    obj.Importe = convertToDouble(dataReader["Importe"].ToString());
                    obj.TipoDoc = dataReader["TipDoc"].ToString();
                    obj.Fecha = dataReader["Fecha"].ToString();
                    obj.Documento = dataReader["Documento"].ToString();
                    obj.FechaVcto = dataReader["FechaVcto"].ToString();
                    obj.TipDocCodigo = dataReader["DocCod"].ToString();
                    obj.TipoAsiento = "01";
                    obj.Anexo = dataReader["Cliente"].ToString();
                    objList.Add(obj);
                }
            }
            return objList;
        }
        public List<AsientoDetalle> getGenerarDetalleVoucherAbono(String nroVoucher)
        {
            List<AsientoDetalle> objList = new List<AsientoDetalle>();
            AsientoDetalle obj;
            Database db = DatabaseFactory.CreateDatabase("Contabilidad");
            DbCommand dbCommand = db.GetStoredProcCommand("sp_DetalleVoucherAsientoAbono",
                   new object[] { nroVoucher });
            using (IDataReader dataReader = db.ExecuteReader(dbCommand))
            {
                while (dataReader.Read())
                {
                    obj = new AsientoDetalle();
                    obj.Cuenta = dataReader["Cuenta"].ToString();
                    obj.TipoImporte = dataReader["TipoImporte"].ToString();
                    obj.Importe = convertToDouble(dataReader["Importe"].ToString());
                    obj.TipoDoc = dataReader["TipDoc"].ToString();
                    obj.Fecha = dataReader["Fecha"].ToString();
                    obj.Documento = dataReader["Documento"].ToString();
                    obj.FechaVcto = dataReader["FechaVcto"].ToString();
                    obj.TipDocCodigo = dataReader["DocCod"].ToString();
                    obj.TipoAsiento = "01";
                    obj.Anexo = dataReader["Cliente"].ToString();
                    obj.Descripcion = dataReader["Descripcion"].ToString();
                    objList.Add(obj);
                }
            }
            return objList;
        }
        public List<AsientoDetalle> getGenerarDetalleVoucherCargo(String nroVoucher)
        {
            List<AsientoDetalle> objList = new List<AsientoDetalle>();
            AsientoDetalle obj;
            Database db = DatabaseFactory.CreateDatabase("Contabilidad");
            DbCommand dbCommand = db.GetStoredProcCommand("sp_DetalleVoucherAsientoCargo",
                   new object[] { nroVoucher });
            using (IDataReader dataReader = db.ExecuteReader(dbCommand))
            {
                while (dataReader.Read())
                {
                    obj = new AsientoDetalle();
                    obj.Cuenta = dataReader["Cuenta"].ToString();
                    obj.TipoImporte = dataReader["TipoImporte"].ToString();
                    obj.Importe = convertToDouble(dataReader["Importe"].ToString());
                    obj.TipoDoc = dataReader["TipDoc"].ToString();
                    obj.Fecha = dataReader["Fecha"].ToString();
                    obj.Documento = dataReader["Documento"].ToString();
                    obj.FechaVcto = dataReader["FechaVcto"].ToString();
                    obj.TipDocCodigo = dataReader["DocCod"].ToString();
                    obj.TipoAsiento = "01";
                    obj.Anexo = dataReader["Cliente"].ToString();
                    objList.Add(obj);
                }
            }
            return objList;
        }
        public List<AsientoDetalle> getGenerarDetalleVoucherCheque(String nroVoucher)
        {
            List<AsientoDetalle> objList = new List<AsientoDetalle>();
            AsientoDetalle obj;
            Database db = DatabaseFactory.CreateDatabase("Contabilidad");
            DbCommand dbCommand = db.GetStoredProcCommand("sp_DetalleVoucherAsiento",
                   new object[] { nroVoucher });
            using (IDataReader dataReader = db.ExecuteReader(dbCommand))
            {
                while (dataReader.Read())
                {
                    obj = new AsientoDetalle();
                    obj.Cuenta = dataReader["Cuenta"].ToString();
                    obj.TipoImporte = dataReader["TipoImporte"].ToString();
                    obj.Importe = convertToDouble(dataReader["Importe"].ToString());
                    obj.TipoDoc = dataReader["TipDoc"].ToString();
                    obj.Fecha = dataReader["Fecha"].ToString();
                    obj.Documento = dataReader["Documento"].ToString();
                    obj.FechaVcto = dataReader["FechaVcto"].ToString();
                    obj.TipDocCodigo = dataReader["DocCod"].ToString();
                    obj.TipoAsiento = "01";
                    obj.Anexo = "";
                    objList.Add(obj);
                }
            }
            return objList;
        }

        public bool insertarAsientoCab(Asiento obj)
        {
            Database db = DatabaseFactory.CreateDatabase("Contabilidad");
            DbCommand dbCommand = db.GetStoredProcCommand("sp_InsertAsientoCab",
                   new object[] { obj.TipoAsiento, obj.Correlativo, obj.Fecha, obj.MonedaCod,
                       obj.Debe, obj.Haber });
            try
            {
                db.ExecuteScalar(dbCommand);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool insertarAsientoDet(AsientoDetalle obj)
        {
            Database db = DatabaseFactory.CreateDatabase("Contabilidad");
            DbCommand dbCommand = db.GetStoredProcCommand("sp_InsertAsientoDet",
                   new object[] { obj.TipoAsiento, obj.Correlativo, obj.Fecha, obj.Cuenta,
                       obj.TipoImporte, obj.Importe,obj.TipDocCodigo, obj.Documento, obj.FechaDoc,
                       obj.FechaVcto,obj.NumReg });
            try
            {
                db.ExecuteScalar(dbCommand);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool updateEstadoAsientoVenta(String serie, String nro)
        {
            Database db = DatabaseFactory.CreateDatabase("Contabilidad");
            DbCommand dbCommand = db.GetStoredProcCommand("sp_estadoDocumentoAsiento",
                   new object[] { serie, nro });
            try
            {
                db.ExecuteScalar(dbCommand);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool updateEstadoAsientoCompra(String numReg)
        {
            Database db = DatabaseFactory.CreateDatabase("Contabilidad");
            DbCommand dbCommand = db.GetStoredProcCommand("sp_estadoCompraAsiento",
                   new object[] { numReg });
            try
            {
                db.ExecuteScalar(dbCommand);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public List<TipoAsiento> getComboTipoAsiento()
        {
            List<TipoAsiento> objList = new List<TipoAsiento>();
            TipoAsiento obj;
            Database db = DatabaseFactory.CreateDatabase("Contabilidad");
            DbCommand dbCommand = db.GetStoredProcCommand("sp_ComboAsiento");
            using (IDataReader dataReader = db.ExecuteReader(dbCommand))
            {
                while (dataReader.Read())
                {
                    obj = new TipoAsiento();
                    obj.Id = dataReader["Id"].ToString();
                    obj.Descripcion = dataReader["Descripcion"].ToString();
                   
                    objList.Add(obj);
                }
            }
            return objList;
        }
        public List<LibroDiario> getLibroDiario(String moneda, String subdiario1, String subdiario2, String mes)
        {
            List<LibroDiario> objList = new List<LibroDiario>();
            LibroDiario obj;
            Database db = DatabaseFactory.CreateDatabase("Contabilidad");
            DbCommand dbCommand = db.GetStoredProcCommand("sp_getLibroDiario",
                   new object[] { moneda, subdiario1, subdiario2, mes });
            using (IDataReader dataReader = db.ExecuteReader(dbCommand))
            {
                while (dataReader.Read())
                {
                    obj = new LibroDiario();
                    obj.TipoAsiento = dataReader["Tipo"].ToString();
                    obj.Correlativo = dataReader["Correlativo"].ToString();
                    obj.FechaOperacion = dataReader["Fecha"].ToString();
                    obj.Descripcion = dataReader["Descripcion"].ToString();
                    obj.TipoDocumento = dataReader["TipoDoc"].ToString();
                    obj.Documento = dataReader["Documento"].ToString();
                    obj.FechaDocumento= dataReader["FechaDocumento"].ToString();
                    obj.CuentaContable = dataReader["Cuenta"].ToString();
                    obj.CuentaDescripcion = dataReader["CC_Descripcion"].ToString();
                    if (String.IsNullOrEmpty(obj.CuentaDescripcion))
                    {
                        obj.CuentaDescripcion = "------";
                    }
                    obj.Ruc = dataReader["Ruc"].ToString();
                    if (String.IsNullOrEmpty(obj.Ruc))
                    {
                        obj.Ruc = "------";
                    }
                    obj.Haber = convertToDouble(dataReader["Haber"].ToString());
                    obj.Debe = convertToDouble(dataReader["Debe"].ToString());
                    objList.Add(obj);
                }
            }
            return objList;
        }
        public List<EstadoGananciasPerdidasNaturaleza> getEstadoGPNaturaleza(String anio,String mes)
        {
            List<EstadoGananciasPerdidasNaturaleza> objList = new List<EstadoGananciasPerdidasNaturaleza>();
            EstadoGananciasPerdidasNaturaleza obj;
            Database db = DatabaseFactory.CreateDatabase("Contabilidad");
            DbCommand dbCommand = db.GetStoredProcCommand("sp_EstadoGananciasPerdidasNaturaleza",
                   new object[] { anio, mes });
            using (IDataReader dataReader = db.ExecuteReader(dbCommand))
            {
                while (dataReader.Read())
                {
                    obj = new EstadoGananciasPerdidasNaturaleza();
                    obj.Descripcion = dataReader["Descripcion"].ToString();
                    obj.Suma = Convert.ToDouble(dataReader["Suma"].ToString());
                    obj.cuenta =Convert.ToInt32(dataReader["Cuenta"].ToString());
                    objList.Add(obj);
                }
            }
            return objList;
        }
        public List<BalanceGeneralReporte> getBalanceGeneral(String anio1, String mes1, String anio2, String mes2)
        {
            List<BalanceGeneralReporte> objList = new List<BalanceGeneralReporte>();
            BalanceGeneralReporte obj;
            Database db = DatabaseFactory.CreateDatabase("Contabilidad");
            DbCommand dbCommand = db.GetStoredProcCommand("sp_BalanceGeneral",
                   new object[] { anio1, mes1, anio2, mes2 });
            using (IDataReader dataReader = db.ExecuteReader(dbCommand))
            {
                while (dataReader.Read())
                {
                    obj = new BalanceGeneralReporte();
                    obj.Cuenta = dataReader["CuentaContable"].ToString();
                    obj.Descripcion = dataReader["Descripccion"].ToString();
                    obj.SaldoAnterior =Convert.ToDouble( dataReader["SaldoAterior"].ToString());
                    obj.Debe = Convert.ToDouble(dataReader["Debe"].ToString());
                    obj.Haber = Convert.ToDouble(dataReader["Haber"].ToString());
                    obj.SaldoActual = Convert.ToDouble(dataReader["SaldoActual"].ToString());
                    objList.Add(obj);
                }
            }
            return objList;
        }
        public List<EstadoGananciasPerdidasFunciones> getEstadoGPFuncion(String anio, String mes)
        {
            List<EstadoGananciasPerdidasFunciones> objList = new List<EstadoGananciasPerdidasFunciones>();
            EstadoGananciasPerdidasFunciones obj;
            Database db = DatabaseFactory.CreateDatabase("Contabilidad");
            DbCommand dbCommand = db.GetStoredProcCommand("sp_EstadoGananciasPerdidasFuncion",
                   new object[] { anio, mes });
            using (IDataReader dataReader = db.ExecuteReader(dbCommand))
            {
                while (dataReader.Read())
                {
                    obj = new EstadoGananciasPerdidasFunciones();
                    obj.egpf1 = Convert.ToDouble(dataReader["egpn1"].ToString());
                    obj.egpf2 = Convert.ToDouble(dataReader["egpn2"].ToString());
                    obj.egpf3 = Convert.ToDouble(dataReader["egpn3"].ToString());
                    obj.egpf4 = Convert.ToDouble(dataReader["egpn4"].ToString());
                    obj.egpf5 = Convert.ToDouble(dataReader["egpn5"].ToString());
                    obj.egpf6 = Convert.ToDouble(dataReader["egpn6"].ToString());
                    obj.egpf7 = Convert.ToDouble(dataReader["egpn7"].ToString());
                    obj.egpf8 = Convert.ToDouble(dataReader["egpn8"].ToString());
                    obj.egpf9 = Convert.ToDouble(dataReader["egpn9"].ToString());
                    obj.egpf10 = Convert.ToDouble(dataReader["egpn10"].ToString());
                    obj.egpf11 = Convert.ToDouble(dataReader["egpn11"].ToString());
                    obj.egpf12 = Convert.ToDouble(dataReader["egpn12"].ToString());
                    obj.egpf13 = Convert.ToDouble(dataReader["egpn13"].ToString());
                    obj.egpf14 = Convert.ToDouble(dataReader["egpn14"].ToString());
                    obj.egpf15 = Convert.ToDouble(dataReader["egpn15"].ToString());
                    obj.egpf16 = Convert.ToDouble(dataReader["egpn16"].ToString());
                    obj.egpf17 = Convert.ToDouble(dataReader["egpn17"].ToString());
                    obj.egpf18 = Convert.ToDouble(dataReader["egpn18"].ToString());
                    obj.egpf19 = Convert.ToDouble(dataReader["egpn19"].ToString());
                    obj.egpf20 = Convert.ToDouble(dataReader["egpn20"].ToString());
                    obj.egpf21 = Convert.ToDouble(dataReader["egpn21"].ToString());
                    obj.egpf22 = Convert.ToDouble(dataReader["egpn22"].ToString());
                    obj.egpf23 = Convert.ToDouble(dataReader["egpn23"].ToString());
                    objList.Add(obj);
                }
            }
            return objList;
        }
        public List<EstadoFlujoEfectivo> getEstadoFlujoEfectivo(String anio, String mes)
        {
            List<EstadoFlujoEfectivo> objList = new List<EstadoFlujoEfectivo>();
            EstadoFlujoEfectivo obj;
            Database db = DatabaseFactory.CreateDatabase("Contabilidad");
            DbCommand dbCommand = db.GetStoredProcCommand("sp_EstadoFlujoEfectivo",
                   new object[] { anio, mes });
            using (IDataReader dataReader = db.ExecuteReader(dbCommand))
            {
                while (dataReader.Read())
                {
                    obj = new EstadoFlujoEfectivo();
                    obj.efe1 = Convert.ToDouble(dataReader["egpn1"].ToString());
                    obj.efe2 = Convert.ToDouble(dataReader["egpn2"].ToString());
                    obj.efe3 = Convert.ToDouble(dataReader["egpn3"].ToString());
                    obj.efe4 = Convert.ToDouble(dataReader["egpn4"].ToString());
                    obj.efe5 = Convert.ToDouble(dataReader["egpn5"].ToString());
                    obj.efe6 = Convert.ToDouble(dataReader["egpn6"].ToString());
                    obj.efe7 = Convert.ToDouble(dataReader["egpn7"].ToString());
                    obj.efe8 = Convert.ToDouble(dataReader["egpn8"].ToString());
                    obj.efe9 = Convert.ToDouble(dataReader["egpn9"].ToString());
                    obj.efe10 = Convert.ToDouble(dataReader["egpn10"].ToString());
                    obj.efe11 = Convert.ToDouble(dataReader["egpn11"].ToString());
                    obj.efe12 = Convert.ToDouble(dataReader["egpn12"].ToString());
                    obj.efe13 = Convert.ToDouble(dataReader["egpn13"].ToString());
                    obj.efe14 = Convert.ToDouble(dataReader["egpn14"].ToString());
                    obj.efe15 = Convert.ToDouble(dataReader["egpn15"].ToString());
                    obj.efe16 = Convert.ToDouble(dataReader["egpn16"].ToString());
                    obj.efe17 = Convert.ToDouble(dataReader["egpn17"].ToString());
                    obj.efe18 = Convert.ToDouble(dataReader["egpn18"].ToString());
                    obj.efe19 = Convert.ToDouble(dataReader["egpn19"].ToString());
                    obj.efe20 = Convert.ToDouble(dataReader["egpn20"].ToString());
                    obj.efe21 = Convert.ToDouble(dataReader["egpn21"].ToString());
                    obj.efe22 = Convert.ToDouble(dataReader["egpn22"].ToString());
                    obj.efe23 = Convert.ToDouble(dataReader["egpn23"].ToString());
                    obj.efe24 = Convert.ToDouble(dataReader["egpn24"].ToString());
                    obj.efe25 = Convert.ToDouble(dataReader["egpn25"].ToString());
                    obj.efe26 = Convert.ToDouble(dataReader["egpn26"].ToString());
                    obj.efe27 = Convert.ToDouble(dataReader["egpn27"].ToString());
                    obj.efe28 = Convert.ToDouble(dataReader["egpn28"].ToString());
                    obj.efe29 = Convert.ToDouble(dataReader["egpn29"].ToString());
                    obj.efe30 = Convert.ToDouble(dataReader["egpn30"].ToString());
                    obj.efe31 = Convert.ToDouble(dataReader["egpn31"].ToString());
                    obj.efe32 = Convert.ToDouble(dataReader["egpn32"].ToString());
                    obj.efe33 = Convert.ToDouble(dataReader["egpn33"].ToString());
                    obj.efe34 = Convert.ToDouble(dataReader["egpn34"].ToString());
                    obj.efe35 = Convert.ToDouble(dataReader["egpn35"].ToString());
                    obj.efe36 = Convert.ToDouble(dataReader["egpn36"].ToString());
                    obj.efe37 = Convert.ToDouble(dataReader["egpn37"].ToString());
                    obj.efe38 = Convert.ToDouble(dataReader["egpn38"].ToString());
                    obj.efe39 = Convert.ToDouble(dataReader["egpn39"].ToString());
                    obj.efe40 = Convert.ToDouble(dataReader["egpn40"].ToString());
                    obj.efe41 = Convert.ToDouble(dataReader["egpn41"].ToString());
                    obj.efe42 = Convert.ToDouble(dataReader["egpn42"].ToString());
                    obj.efe43 = Convert.ToDouble(dataReader["egpn43"].ToString());
                    obj.efe44 = Convert.ToDouble(dataReader["egpn44"].ToString());
                    obj.efe45 = Convert.ToDouble(dataReader["egpn45"].ToString());
                    obj.efe46 = Convert.ToDouble(dataReader["egpn46"].ToString());
                    obj.efe47 = Convert.ToDouble(dataReader["egpn47"].ToString());
                    obj.efe48 = Convert.ToDouble(dataReader["egpn48"].ToString());
                    obj.efe49 = Convert.ToDouble(dataReader["egpn49"].ToString());
                    obj.efe50 = Convert.ToDouble(dataReader["egpn50"].ToString());
                    obj.efe51 = Convert.ToDouble(dataReader["egpn51"].ToString());
                    obj.efe52 = Convert.ToDouble(dataReader["egpn52"].ToString());
                    obj.efe53 = Convert.ToDouble(dataReader["egpn53"].ToString());
                    objList.Add(obj);
                }
            }
            return objList;
        }
        public List<LibroDiario> getLibroMayor(String moneda,String mes)
        {
            List<LibroDiario> objList = new List<LibroDiario>();
            LibroDiario obj;
            Database db = DatabaseFactory.CreateDatabase("Contabilidad");
            DbCommand dbCommand = db.GetStoredProcCommand("sp_getLibroMayor",
                   new object[] { moneda, mes });
            using (IDataReader dataReader = db.ExecuteReader(dbCommand))
            {
                while (dataReader.Read())
                {
                    obj = new LibroDiario();
                    obj.TipoAsiento = dataReader["Tipo"].ToString();
                    obj.Correlativo = dataReader["Correlativo"].ToString();
                    obj.FechaOperacion = dataReader["Fecha"].ToString();
                    obj.Descripcion = dataReader["Descripcion"].ToString();
                    obj.TipoDocumento = dataReader["TipoDoc"].ToString();
                    obj.Documento = dataReader["Documento"].ToString();
                    obj.FechaDocumento = dataReader["FechaDocumento"].ToString();
                    obj.CuentaContable = dataReader["Cuenta"].ToString();
                    obj.CuentaDescripcion = dataReader["CC_Descripcion"].ToString();
                    if (String.IsNullOrEmpty(obj.CuentaDescripcion))
                    {
                        obj.CuentaDescripcion = "------";
                    }
                    obj.Ruc = dataReader["Ruc"].ToString();
                    if (String.IsNullOrEmpty(obj.Ruc))
                    {
                        obj.Ruc = "------";
                    }
                    obj.Haber = convertToDouble(dataReader["Haber"].ToString());
                    obj.Debe = convertToDouble(dataReader["Debe"].ToString());
                    objList.Add(obj);
                }
            }
            return objList;
        }
        public List<LibroDiario> getLibroMayorCajaBanco(String moneda, String mes, String cuenta1, String cuenta2)
        {
            List<LibroDiario> objList = new List<LibroDiario>();
            LibroDiario obj;
            Database db = DatabaseFactory.CreateDatabase("Contabilidad");
            DbCommand dbCommand = db.GetStoredProcCommand("sp_getLibroMayorCajaBanco",
                   new object[] { moneda, mes, cuenta1, cuenta2 });
            using (IDataReader dataReader = db.ExecuteReader(dbCommand))
            {
                while (dataReader.Read())
                {
                    obj = new LibroDiario();
                    obj.TipoAsiento = dataReader["Tipo"].ToString();
                    obj.Correlativo = dataReader["Correlativo"].ToString();
                    obj.FechaOperacion = dataReader["Fecha"].ToString();
                    obj.Descripcion = dataReader["Descripcion"].ToString();
                    obj.TipoDocumento = dataReader["TipoDoc"].ToString();
                    obj.Documento = dataReader["Documento"].ToString();
                    obj.FechaDocumento = dataReader["FechaDocumento"].ToString();
                    obj.CuentaContable = dataReader["Cuenta"].ToString();
                    obj.CuentaDescripcion = dataReader["CC_Descripcion"].ToString();
                    if (String.IsNullOrEmpty(obj.CuentaDescripcion))
                    {
                        obj.CuentaDescripcion = "------";
                    }
                    obj.Ruc = dataReader["Ruc"].ToString();
                    if (String.IsNullOrEmpty(obj.Ruc))
                    {
                        obj.Ruc = "------";
                    }
                    obj.Haber = convertToDouble(dataReader["Haber"].ToString());
                    obj.Debe = convertToDouble(dataReader["Debe"].ToString());
                    objList.Add(obj);
                }
            }
            return objList;
        }

        public List<CajaDet> getGenerarCaja(String CodEnt)
        {
            List<CajaDet> objList = new List<CajaDet>();
            CajaDet obj;
            Database db = DatabaseFactory.CreateDatabase("Contabilidad");
            DbCommand dbCommand = db.GetStoredProcCommand("sp_GenerarCajaAsiento",
                   new object[] { CodEnt});
            using (IDataReader dataReader = db.ExecuteReader(dbCommand))
            {
                while (dataReader.Read())
                {
                    obj = new CajaDet();
                    obj.NumeroOperacion = Convert.ToInt32(dataReader["NroOperacion"].ToString());
                    obj.NumeroCaja = dataReader["NroCaja"].ToString();
                    obj.Ruc = dataReader["Ruc"].ToString();
                    obj.FechaOperacion = Convert.ToDateTime(dataReader["FechaOperacion"].ToString());
                 
                    obj.DescripcionOperacion = dataReader["DescripcionOperacion"].ToString();
                    obj.MonedaCod = dataReader["MonedaCod"].ToString();
                    obj.SubTotal = convertToDouble(dataReader["Subtotal"].ToString());
                    obj.IGV = convertToDouble(dataReader["IGV"].ToString());
                    obj.Total = convertToDouble(dataReader["Total"].ToString());
                    obj.TipoDocRef = dataReader["TipDocRef"].ToString();
                    obj.SerieDocRef = dataReader["SerieDocRef"].ToString();
                    obj.NroDocRef = dataReader["NroDocRef"].ToString();
                    obj.CodGas = dataReader["CodGas"].ToString();
                    obj.CuentaContable = dataReader["CuentaContable"].ToString();
                    obj.CodOt = dataReader["CodOt"].ToString();
                    obj.NroOt = dataReader["NroOt"].ToString();
                    obj.Motivo = dataReader["Motivo"].ToString();
                    obj.Tper = dataReader["Tper"].ToString();
                    obj.Distrito = dataReader["Distrito"].ToString();
                    obj.CodConcepto = dataReader["CodConcepto"].ToString();

                    obj.Pedido = dataReader["Pedido"].ToString();
                    
                 
                    obj.CentroLabor = dataReader["CentroLabor"].ToString().Trim();
                    obj.TipoDocCorta = dataReader["Codigo2"].ToString().Trim();
                    obj.NroDocumento = dataReader["NroDocumento"].ToString();
                    obj.Proveedor = dataReader["Proveedor"].ToString().Trim().ToUpper();
                    String aux = dataReader["FechaEmision"].ToString();
                    if (!String.IsNullOrEmpty(aux))
                    {
                        obj.FechaEmision = Convert.ToDateTime(aux);
                    }
                    objList.Add(obj);


                }
            }
            return objList;
        }

        public List<Voucher> getGenerarVoucher(String CodEnt)
        {
            List<Voucher> objList = new List<Voucher>();
            Voucher obj;
            Database db = DatabaseFactory.CreateDatabase("Contabilidad");
            DbCommand dbCommand = db.GetStoredProcCommand("sp_GenerarVoucherAsiento",
                   new object[] { CodEnt });
            using (IDataReader dataReader = db.ExecuteReader(dbCommand))
            {
                while (dataReader.Read())
                {
                    obj = new Voucher();
                 //  obj.Item = Convert.ToInt32(dataReader["Item"].ToString());
                    obj.NroVoucher = dataReader["NroVoucher"].ToString();
                    obj.FechaPago = Convert.ToDateTime(dataReader["FechaPago"].ToString());
                    String aux = dataReader["FechaEmision"].ToString();
                    if (!String.IsNullOrEmpty(aux))
                    {
                        obj.FechaEmision = Convert.ToDateTime(aux);
                    }
                    obj.NumeroCheque = dataReader["NroCheque"].ToString();
                    obj.NumeroCuenta   = dataReader["NroCuenta"].ToString();
                    obj.Moneda = dataReader["Moneda"].ToString();
                    obj.TpersonaCod = dataReader["TPersona"].ToString();
                    obj.Tpersona = dataReader["Descripcion"].ToString();
                    obj.SolicitaCod = dataReader["CodSolicita"].ToString();
                    obj.CuentaContable = dataReader["CuentaContable"].ToString();
                    obj.BancoCod = dataReader["CodBanco"].ToString();
                    obj.Banco = dataReader["Banco"].ToString();
                    obj.Solicitante = dataReader["Solicitante"].ToString().ToUpper();
                    obj.Importe = convertToDouble(dataReader["MontoPago"].ToString());
                    obj.CodOt = dataReader["CodOt"].ToString();
                    obj.NroOt = dataReader["NroOt"].ToString();
                    obj.SerieDocRef = dataReader["SerieDocRef"].ToString();
                    obj.NumeroDocRef = dataReader["NroDocRef"].ToString();
                    obj.TipDocRef = dataReader["TipoDocRef"].ToString();
                    obj.TipDocCorta = dataReader["Codigo2"].ToString();
                    obj.TipoPagoCod = dataReader["TipoPagoCod"].ToString();
                    obj.TipoPago = dataReader["TipoPago"].ToString();
                    obj.Ruc = dataReader["rucprov"].ToString();
                    obj.TipVoucher = dataReader["TipVou"].ToString();
                    objList.Add(obj);


                }
            }
            return objList;
        }



        public Double convertToDouble(String conv)
        {
            try
            {
                char systemSeparator = Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyDecimalSeparator[0];
                if (!conv.Contains(","))
                    return double.Parse(conv, CultureInfo.InvariantCulture);
                else
                    return Convert.ToDouble(conv.Replace(".", systemSeparator.ToString()).Replace(",", systemSeparator.ToString()));
            }
            catch (Exception ex)
            {
                return 0;
            }

        }
    }
}
