﻿namespace Conta.RegistroAsientoGeneral
{
    partial class AsientoCGeneral
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmb_Cuenta = new System.Windows.Forms.ComboBox();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Documento = new System.Windows.Forms.TextBox();
            this.txt_Importe = new System.Windows.Forms.TextBox();
            this.txt_Cuenta = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.grd_Facturas = new System.Windows.Forms.DataGridView();
            this.btn_Cerrar = new System.Windows.Forms.Button();
            this.btn_SaveData = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_Facturas)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.cmb_Cuenta);
            this.panel2.Controls.Add(this.btn_Guardar);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txt_Documento);
            this.panel2.Controls.Add(this.txt_Importe);
            this.panel2.Controls.Add(this.txt_Cuenta);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(16, 128);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(641, 133);
            this.panel2.TabIndex = 48;
            // 
            // cmb_Cuenta
            // 
            this.cmb_Cuenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Cuenta.FormattingEnabled = true;
            this.cmb_Cuenta.Location = new System.Drawing.Point(88, 53);
            this.cmb_Cuenta.Name = "cmb_Cuenta";
            this.cmb_Cuenta.Size = new System.Drawing.Size(116, 21);
            this.cmb_Cuenta.TabIndex = 46;
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Image = global::Contabilidad.Properties.Resources.guardar;
            this.btn_Guardar.Location = new System.Drawing.Point(294, 89);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(41, 37);
            this.btn_Guardar.TabIndex = 45;
            this.btn_Guardar.UseVisualStyleBackColor = true;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // label10
            // 
            this.label10.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label10.Location = new System.Drawing.Point(38, 55);
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
            this.label5.Location = new System.Drawing.Point(19, 19);
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
            this.label6.Location = new System.Drawing.Point(400, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 36;
            this.label6.Text = "Documento  :";
            // 
            // txt_Documento
            // 
            this.txt_Documento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_Documento.Location = new System.Drawing.Point(512, 56);
            this.txt_Documento.Name = "txt_Documento";
            this.txt_Documento.Size = new System.Drawing.Size(98, 20);
            this.txt_Documento.TabIndex = 38;
            // 
            // txt_Importe
            // 
            this.txt_Importe.Location = new System.Drawing.Point(512, 16);
            this.txt_Importe.Name = "txt_Importe";
            this.txt_Importe.Size = new System.Drawing.Size(98, 20);
            this.txt_Importe.TabIndex = 37;
            // 
            // txt_Cuenta
            // 
            this.txt_Cuenta.Location = new System.Drawing.Point(88, 16);
            this.txt_Cuenta.Name = "txt_Cuenta";
            this.txt_Cuenta.Size = new System.Drawing.Size(116, 20);
            this.txt_Cuenta.TabIndex = 34;
            // 
            // label8
            // 
            this.label8.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label8.Location = new System.Drawing.Point(426, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 35;
            this.label8.Text = "Importe :";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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
            this.panel1.Location = new System.Drawing.Point(16, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(641, 100);
            this.panel1.TabIndex = 47;
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
            // grd_Facturas
            // 
            this.grd_Facturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_Facturas.Location = new System.Drawing.Point(39, 288);
            this.grd_Facturas.Name = "grd_Facturas";
            this.grd_Facturas.Size = new System.Drawing.Size(598, 185);
            this.grd_Facturas.TabIndex = 46;
            // 
            // btn_Cerrar
            // 
            this.btn_Cerrar.Image = global::Contabilidad.Properties.Resources.close;
            this.btn_Cerrar.Location = new System.Drawing.Point(608, 488);
            this.btn_Cerrar.Name = "btn_Cerrar";
            this.btn_Cerrar.Size = new System.Drawing.Size(49, 43);
            this.btn_Cerrar.TabIndex = 50;
            this.btn_Cerrar.UseVisualStyleBackColor = true;
            this.btn_Cerrar.Click += new System.EventHandler(this.btn_Cerrar_Click);
            // 
            // btn_SaveData
            // 
            this.btn_SaveData.Image = global::Contabilidad.Properties.Resources.saveopt;
            this.btn_SaveData.Location = new System.Drawing.Point(301, 488);
            this.btn_SaveData.Name = "btn_SaveData";
            this.btn_SaveData.Size = new System.Drawing.Size(48, 46);
            this.btn_SaveData.TabIndex = 49;
            this.btn_SaveData.UseVisualStyleBackColor = true;
            this.btn_SaveData.Click += new System.EventHandler(this.btn_SaveData_Click);
            // 
            // AsientoCGeneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 558);
            this.Controls.Add(this.btn_Cerrar);
            this.Controls.Add(this.btn_SaveData);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grd_Facturas);
            this.Name = "AsientoCGeneral";
            this.Text = "AsientoCGeneral";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_Facturas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_Documento;
        private System.Windows.Forms.TextBox txt_Importe;
        private System.Windows.Forms.TextBox txt_Cuenta;
        private System.Windows.Forms.Label label8;
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
        private System.Windows.Forms.DataGridView grd_Facturas;
        private System.Windows.Forms.Button btn_Cerrar;
        private System.Windows.Forms.Button btn_SaveData;
        private System.Windows.Forms.ComboBox cmb_Cuenta;
    }
}