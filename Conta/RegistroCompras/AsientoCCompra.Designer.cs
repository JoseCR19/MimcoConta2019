﻿namespace Conta.RegistroCompras
{
    partial class AsientoCCompra
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_cliente = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_glosa = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.txt_TipoAsiento = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Haber = new System.Windows.Forms.TextBox();
            this.txt_Fecha = new System.Windows.Forms.TextBox();
            this.txt_Debe = new System.Windows.Forms.TextBox();
            this.txt_Correlativo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Moneda = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmb_Documento = new System.Windows.Forms.ComboBox();
            this.cmb_Cuenta = new System.Windows.Forms.ComboBox();
            this.btn_Editar = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Documento = new System.Windows.Forms.TextBox();
            this.txt_Importe = new System.Windows.Forms.TextBox();
            this.txt_Cuenta = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.grd_Facturas = new System.Windows.Forms.DataGridView();
            this.btn_Cerrar = new System.Windows.Forms.Button();
            this.btn_SaveData = new System.Windows.Forms.Button();
            this.txt_cuentadescripcion = new System.Windows.Forms.TextBox();
            this.txt_ot = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_Facturas)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txt_cliente);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.txt_glosa);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txt_descripcion);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label21);
            this.panel1.Controls.Add(this.txt_TipoAsiento);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt_Haber);
            this.panel1.Controls.Add(this.txt_Fecha);
            this.panel1.Controls.Add(this.txt_Debe);
            this.panel1.Controls.Add(this.txt_Correlativo);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_Moneda);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(110, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(641, 165);
            this.panel1.TabIndex = 45;
            // 
            // txt_cliente
            // 
            this.txt_cliente.Enabled = false;
            this.txt_cliente.Location = new System.Drawing.Point(77, 81);
            this.txt_cliente.Name = "txt_cliente";
            this.txt_cliente.Size = new System.Drawing.Size(533, 20);
            this.txt_cliente.TabIndex = 57;
            // 
            // label12
            // 
            this.label12.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label12.Location = new System.Drawing.Point(0, 83);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 13);
            this.label12.TabIndex = 56;
            this.label12.Text = "Proveedor :";
            // 
            // txt_glosa
            // 
            this.txt_glosa.Location = new System.Drawing.Point(77, 138);
            this.txt_glosa.Name = "txt_glosa";
            this.txt_glosa.Size = new System.Drawing.Size(533, 20);
            this.txt_glosa.TabIndex = 55;
            // 
            // label7
            // 
            this.label7.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label7.Location = new System.Drawing.Point(0, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 13);
            this.label7.TabIndex = 54;
            this.label7.Text = "Descripción :";
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Location = new System.Drawing.Point(77, 112);
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(533, 20);
            this.txt_descripcion.TabIndex = 53;
            // 
            // label11
            // 
            this.label11.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label11.Location = new System.Drawing.Point(0, 114);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 13);
            this.label11.TabIndex = 52;
            this.label11.Text = "Glosa :";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label21.Location = new System.Drawing.Point(3, 19);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(61, 13);
            this.label21.TabIndex = 33;
            this.label21.Text = "Asiento  :";
            // 
            // txt_TipoAsiento
            // 
            this.txt_TipoAsiento.Enabled = false;
            this.txt_TipoAsiento.Location = new System.Drawing.Point(77, 16);
            this.txt_TipoAsiento.Name = "txt_TipoAsiento";
            this.txt_TipoAsiento.Size = new System.Drawing.Size(29, 20);
            this.txt_TipoAsiento.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Location = new System.Drawing.Point(431, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "Haber  :";
            // 
            // txt_Haber
            // 
            this.txt_Haber.Enabled = false;
            this.txt_Haber.Location = new System.Drawing.Point(512, 56);
            this.txt_Haber.Name = "txt_Haber";
            this.txt_Haber.Size = new System.Drawing.Size(98, 20);
            this.txt_Haber.TabIndex = 38;
            // 
            // txt_Fecha
            // 
            this.txt_Fecha.Enabled = false;
            this.txt_Fecha.Location = new System.Drawing.Point(284, 33);
            this.txt_Fecha.Name = "txt_Fecha";
            this.txt_Fecha.Size = new System.Drawing.Size(109, 20);
            this.txt_Fecha.TabIndex = 42;
            // 
            // txt_Debe
            // 
            this.txt_Debe.Enabled = false;
            this.txt_Debe.Location = new System.Drawing.Point(512, 16);
            this.txt_Debe.Name = "txt_Debe";
            this.txt_Debe.Size = new System.Drawing.Size(98, 20);
            this.txt_Debe.TabIndex = 37;
            // 
            // txt_Correlativo
            // 
            this.txt_Correlativo.Enabled = false;
            this.txt_Correlativo.Location = new System.Drawing.Point(119, 16);
            this.txt_Correlativo.Name = "txt_Correlativo";
            this.txt_Correlativo.Size = new System.Drawing.Size(74, 20);
            this.txt_Correlativo.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label4.Location = new System.Drawing.Point(228, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 41;
            this.label4.Text = "Fecha :";
            // 
            // label1
            // 
            this.label1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(436, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "Debe  :";
            // 
            // txt_Moneda
            // 
            this.txt_Moneda.Enabled = false;
            this.txt_Moneda.Location = new System.Drawing.Point(77, 55);
            this.txt_Moneda.Name = "txt_Moneda";
            this.txt_Moneda.Size = new System.Drawing.Size(116, 20);
            this.txt_Moneda.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.Location = new System.Drawing.Point(4, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "Moneda :";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txt_ot);
            this.panel2.Controls.Add(this.txt_cuentadescripcion);
            this.panel2.Controls.Add(this.cmb_Documento);
            this.panel2.Controls.Add(this.cmb_Cuenta);
            this.panel2.Controls.Add(this.btn_Editar);
            this.panel2.Controls.Add(this.btn_Add);
            this.panel2.Controls.Add(this.btn_Guardar);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txt_Documento);
            this.panel2.Controls.Add(this.txt_Importe);
            this.panel2.Controls.Add(this.txt_Cuenta);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Location = new System.Drawing.Point(110, 173);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(641, 133);
            this.panel2.TabIndex = 46;
            // 
            // cmb_Documento
            // 
            this.cmb_Documento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Documento.Enabled = false;
            this.cmb_Documento.FormattingEnabled = true;
            this.cmb_Documento.Location = new System.Drawing.Point(88, 65);
            this.cmb_Documento.Name = "cmb_Documento";
            this.cmb_Documento.Size = new System.Drawing.Size(116, 21);
            this.cmb_Documento.TabIndex = 50;
            // 
            // cmb_Cuenta
            // 
            this.cmb_Cuenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Cuenta.Enabled = false;
            this.cmb_Cuenta.FormattingEnabled = true;
            this.cmb_Cuenta.Location = new System.Drawing.Point(271, 41);
            this.cmb_Cuenta.Name = "cmb_Cuenta";
            this.cmb_Cuenta.Size = new System.Drawing.Size(116, 21);
            this.cmb_Cuenta.TabIndex = 49;
            // 
            // btn_Editar
            // 
            this.btn_Editar.Image = global::Contabilidad.Properties.Resources.editar;
            this.btn_Editar.Location = new System.Drawing.Point(317, 91);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Size = new System.Drawing.Size(41, 37);
            this.btn_Editar.TabIndex = 48;
            this.btn_Editar.UseVisualStyleBackColor = true;
            this.btn_Editar.Click += new System.EventHandler(this.btn_Editar_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Image = global::Contabilidad.Properties.Resources.agregar;
            this.btn_Add.Location = new System.Drawing.Point(248, 91);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(41, 37);
            this.btn_Add.TabIndex = 47;
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Image = global::Contabilidad.Properties.Resources.guardar;
            this.btn_Guardar.Location = new System.Drawing.Point(382, 91);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(41, 37);
            this.btn_Guardar.TabIndex = 46;
            this.btn_Guardar.UseVisualStyleBackColor = true;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // label10
            // 
            this.label10.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label10.Location = new System.Drawing.Point(225, 49);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 43;
            this.label10.Text = "Tipo :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label5.Location = new System.Drawing.Point(19, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "Cuenta  :";
            // 
            // label6
            // 
            this.label6.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label6.Location = new System.Drawing.Point(400, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 36;
            this.label6.Text = "Documento  :";
            // 
            // txt_Documento
            // 
            this.txt_Documento.Enabled = false;
            this.txt_Documento.Location = new System.Drawing.Point(512, 66);
            this.txt_Documento.Name = "txt_Documento";
            this.txt_Documento.Size = new System.Drawing.Size(98, 20);
            this.txt_Documento.TabIndex = 38;
            // 
            // txt_Importe
            // 
            this.txt_Importe.Enabled = false;
            this.txt_Importe.Location = new System.Drawing.Point(512, 40);
            this.txt_Importe.Name = "txt_Importe";
            this.txt_Importe.Size = new System.Drawing.Size(98, 20);
            this.txt_Importe.TabIndex = 37;
            // 
            // txt_Cuenta
            // 
            this.txt_Cuenta.Enabled = false;
            this.txt_Cuenta.Location = new System.Drawing.Point(88, 12);
            this.txt_Cuenta.Name = "txt_Cuenta";
            this.txt_Cuenta.Size = new System.Drawing.Size(116, 20);
            this.txt_Cuenta.TabIndex = 34;
            this.txt_Cuenta.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Cuenta_KeyDown);
            // 
            // label8
            // 
            this.label8.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label8.Location = new System.Drawing.Point(426, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 35;
            this.label8.Text = "Importe :";
            // 
            // label9
            // 
            this.label9.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label9.Location = new System.Drawing.Point(11, 68);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 13);
            this.label9.TabIndex = 39;
            this.label9.Text = "Tipo Doc :";
            // 
            // grd_Facturas
            // 
            this.grd_Facturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_Facturas.Location = new System.Drawing.Point(33, 312);
            this.grd_Facturas.Name = "grd_Facturas";
            this.grd_Facturas.ReadOnly = true;
            this.grd_Facturas.Size = new System.Drawing.Size(825, 185);
            this.grd_Facturas.TabIndex = 48;
            // 
            // btn_Cerrar
            // 
            this.btn_Cerrar.Image = global::Contabilidad.Properties.Resources.close;
            this.btn_Cerrar.Location = new System.Drawing.Point(579, 503);
            this.btn_Cerrar.Name = "btn_Cerrar";
            this.btn_Cerrar.Size = new System.Drawing.Size(49, 43);
            this.btn_Cerrar.TabIndex = 49;
            this.btn_Cerrar.UseVisualStyleBackColor = true;
            this.btn_Cerrar.Click += new System.EventHandler(this.btn_Cerrar_Click);
            // 
            // btn_SaveData
            // 
            this.btn_SaveData.Image = global::Contabilidad.Properties.Resources.saveopt;
            this.btn_SaveData.Location = new System.Drawing.Point(272, 503);
            this.btn_SaveData.Name = "btn_SaveData";
            this.btn_SaveData.Size = new System.Drawing.Size(48, 46);
            this.btn_SaveData.TabIndex = 47;
            this.btn_SaveData.UseVisualStyleBackColor = true;
            this.btn_SaveData.Click += new System.EventHandler(this.btn_SaveData_Click);
            // 
            // txt_cuentadescripcion
            // 
            this.txt_cuentadescripcion.Enabled = false;
            this.txt_cuentadescripcion.Location = new System.Drawing.Point(210, 12);
            this.txt_cuentadescripcion.Name = "txt_cuentadescripcion";
            this.txt_cuentadescripcion.Size = new System.Drawing.Size(400, 20);
            this.txt_cuentadescripcion.TabIndex = 51;
            // 
            // txt_ot
            // 
            this.txt_ot.Enabled = false;
            this.txt_ot.Location = new System.Drawing.Point(512, 92);
            this.txt_ot.Name = "txt_ot";
            this.txt_ot.Size = new System.Drawing.Size(98, 20);
            this.txt_ot.TabIndex = 52;
            // 
            // AsientoCCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 558);
            this.Controls.Add(this.btn_Cerrar);
            this.Controls.Add(this.grd_Facturas);
            this.Controls.Add(this.btn_SaveData);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AsientoCCompra";
            this.Text = "AsientoCCompra";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_Facturas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txt_TipoAsiento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Haber;
        private System.Windows.Forms.TextBox txt_Fecha;
        private System.Windows.Forms.TextBox txt_Debe;
        private System.Windows.Forms.TextBox txt_Correlativo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Moneda;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_Documento;
        private System.Windows.Forms.TextBox txt_Importe;
        private System.Windows.Forms.TextBox txt_Cuenta;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_Cerrar;
        private System.Windows.Forms.DataGridView grd_Facturas;
        private System.Windows.Forms.Button btn_SaveData;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.Button btn_Editar;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.ComboBox cmb_Cuenta;
        private System.Windows.Forms.ComboBox cmb_Documento;
        private System.Windows.Forms.TextBox txt_cliente;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_glosa;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_descripcion;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_cuentadescripcion;
        private System.Windows.Forms.TextBox txt_ot;
    }
}