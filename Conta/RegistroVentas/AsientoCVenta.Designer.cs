namespace Conta.RegistroVentas
{
    partial class AsientoCVenta
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
            this.grd_Facturas = new System.Windows.Forms.DataGridView();
            this.txt_TipoAsiento = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txt_Correlativo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Debe = new System.Windows.Forms.TextBox();
            this.txt_Haber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Moneda = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Fecha = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_cliente = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_glosa = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_Tipo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Documento = new System.Windows.Forms.TextBox();
            this.txt_Importe = new System.Windows.Forms.TextBox();
            this.txt_Cuenta = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_TipoDoc = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_Cerrar = new System.Windows.Forms.Button();
            this.btn_SaveData = new System.Windows.Forms.Button();
            this.txt_desccuenta = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grd_Facturas)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grd_Facturas
            // 
            this.grd_Facturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_Facturas.Location = new System.Drawing.Point(16, 297);
            this.grd_Facturas.Name = "grd_Facturas";
            this.grd_Facturas.ReadOnly = true;
            this.grd_Facturas.Size = new System.Drawing.Size(800, 185);
            this.grd_Facturas.TabIndex = 31;
            // 
            // txt_TipoAsiento
            // 
            this.txt_TipoAsiento.Enabled = false;
            this.txt_TipoAsiento.Location = new System.Drawing.Point(77, 16);
            this.txt_TipoAsiento.Name = "txt_TipoAsiento";
            this.txt_TipoAsiento.Size = new System.Drawing.Size(29, 20);
            this.txt_TipoAsiento.TabIndex = 32;
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
            // txt_Correlativo
            // 
            this.txt_Correlativo.Enabled = false;
            this.txt_Correlativo.Location = new System.Drawing.Point(119, 16);
            this.txt_Correlativo.Name = "txt_Correlativo";
            this.txt_Correlativo.Size = new System.Drawing.Size(74, 20);
            this.txt_Correlativo.TabIndex = 34;
            this.txt_Correlativo.TextChanged += new System.EventHandler(this.txt_Correlativo_TextChanged);
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
            // txt_Debe
            // 
            this.txt_Debe.Enabled = false;
            this.txt_Debe.Location = new System.Drawing.Point(512, 16);
            this.txt_Debe.Name = "txt_Debe";
            this.txt_Debe.Size = new System.Drawing.Size(98, 20);
            this.txt_Debe.TabIndex = 37;
            // 
            // txt_Haber
            // 
            this.txt_Haber.Enabled = false;
            this.txt_Haber.Location = new System.Drawing.Point(512, 56);
            this.txt_Haber.Name = "txt_Haber";
            this.txt_Haber.Size = new System.Drawing.Size(98, 20);
            this.txt_Haber.TabIndex = 38;
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
            // txt_Moneda
            // 
            this.txt_Moneda.Enabled = false;
            this.txt_Moneda.Location = new System.Drawing.Point(77, 55);
            this.txt_Moneda.Name = "txt_Moneda";
            this.txt_Moneda.Size = new System.Drawing.Size(116, 20);
            this.txt_Moneda.TabIndex = 40;
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
            // txt_Fecha
            // 
            this.txt_Fecha.Enabled = false;
            this.txt_Fecha.Location = new System.Drawing.Point(284, 33);
            this.txt_Fecha.Name = "txt_Fecha";
            this.txt_Fecha.Size = new System.Drawing.Size(109, 20);
            this.txt_Fecha.TabIndex = 42;
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
            this.panel1.Location = new System.Drawing.Point(85, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(641, 100);
            this.panel1.TabIndex = 44;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txt_desccuenta);
            this.panel2.Controls.Add(this.txt_cliente);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.txt_glosa);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txt_descripcion);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.txt_Tipo);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txt_Documento);
            this.panel2.Controls.Add(this.txt_Importe);
            this.panel2.Controls.Add(this.txt_Cuenta);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.txt_TipoDoc);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Location = new System.Drawing.Point(85, 118);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(641, 173);
            this.panel2.TabIndex = 45;
            // 
            // txt_cliente
            // 
            this.txt_cliente.Enabled = false;
            this.txt_cliente.Location = new System.Drawing.Point(88, 88);
            this.txt_cliente.Name = "txt_cliente";
            this.txt_cliente.Size = new System.Drawing.Size(522, 20);
            this.txt_cliente.TabIndex = 51;
            // 
            // label12
            // 
            this.label12.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label12.Location = new System.Drawing.Point(11, 90);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 13);
            this.label12.TabIndex = 50;
            this.label12.Text = "Cliente :";
            // 
            // txt_glosa
            // 
            this.txt_glosa.Location = new System.Drawing.Point(88, 145);
            this.txt_glosa.Name = "txt_glosa";
            this.txt_glosa.Size = new System.Drawing.Size(522, 20);
            this.txt_glosa.TabIndex = 49;
            // 
            // label7
            // 
            this.label7.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label7.Location = new System.Drawing.Point(11, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 13);
            this.label7.TabIndex = 48;
            this.label7.Text = "Descripción :";
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Location = new System.Drawing.Point(88, 119);
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(522, 20);
            this.txt_descripcion.TabIndex = 47;
            // 
            // label11
            // 
            this.label11.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label11.Location = new System.Drawing.Point(11, 121);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 13);
            this.label11.TabIndex = 46;
            this.label11.Text = "Glosa :";
            // 
            // txt_Tipo
            // 
            this.txt_Tipo.Enabled = false;
            this.txt_Tipo.Location = new System.Drawing.Point(271, 41);
            this.txt_Tipo.Name = "txt_Tipo";
            this.txt_Tipo.Size = new System.Drawing.Size(109, 20);
            this.txt_Tipo.TabIndex = 44;
            // 
            // label10
            // 
            this.label10.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label10.Location = new System.Drawing.Point(225, 43);
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
            this.label5.Location = new System.Drawing.Point(19, 13);
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
            this.label6.Location = new System.Drawing.Point(400, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 36;
            this.label6.Text = "Documento  :";
            // 
            // txt_Documento
            // 
            this.txt_Documento.Enabled = false;
            this.txt_Documento.Location = new System.Drawing.Point(512, 60);
            this.txt_Documento.Name = "txt_Documento";
            this.txt_Documento.Size = new System.Drawing.Size(98, 20);
            this.txt_Documento.TabIndex = 38;
            // 
            // txt_Importe
            // 
            this.txt_Importe.Enabled = false;
            this.txt_Importe.Location = new System.Drawing.Point(512, 34);
            this.txt_Importe.Name = "txt_Importe";
            this.txt_Importe.Size = new System.Drawing.Size(98, 20);
            this.txt_Importe.TabIndex = 37;
            // 
            // txt_Cuenta
            // 
            this.txt_Cuenta.Enabled = false;
            this.txt_Cuenta.Location = new System.Drawing.Point(88, 10);
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
            this.label8.Location = new System.Drawing.Point(426, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 35;
            this.label8.Text = "Importe :";
            // 
            // txt_TipoDoc
            // 
            this.txt_TipoDoc.Enabled = false;
            this.txt_TipoDoc.Location = new System.Drawing.Point(88, 59);
            this.txt_TipoDoc.Name = "txt_TipoDoc";
            this.txt_TipoDoc.Size = new System.Drawing.Size(116, 20);
            this.txt_TipoDoc.TabIndex = 40;
            // 
            // label9
            // 
            this.label9.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label9.Location = new System.Drawing.Point(11, 62);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 13);
            this.label9.TabIndex = 39;
            this.label9.Text = "Tipo Doc :";
            // 
            // btn_Cerrar
            // 
            this.btn_Cerrar.Image = global::Contabilidad.Properties.Resources.close;
            this.btn_Cerrar.Location = new System.Drawing.Point(767, 488);
            this.btn_Cerrar.Name = "btn_Cerrar";
            this.btn_Cerrar.Size = new System.Drawing.Size(49, 43);
            this.btn_Cerrar.TabIndex = 46;
            this.btn_Cerrar.UseVisualStyleBackColor = true;
            this.btn_Cerrar.Click += new System.EventHandler(this.btn_Cerrar_Click);
            // 
            // btn_SaveData
            // 
            this.btn_SaveData.Image = global::Contabilidad.Properties.Resources.saveopt;
            this.btn_SaveData.Location = new System.Drawing.Point(301, 488);
            this.btn_SaveData.Name = "btn_SaveData";
            this.btn_SaveData.Size = new System.Drawing.Size(48, 46);
            this.btn_SaveData.TabIndex = 30;
            this.btn_SaveData.UseVisualStyleBackColor = true;
            this.btn_SaveData.Click += new System.EventHandler(this.btn_SaveData_Click);
            // 
            // txt_desccuenta
            // 
            this.txt_desccuenta.Enabled = false;
            this.txt_desccuenta.Location = new System.Drawing.Point(215, 8);
            this.txt_desccuenta.Name = "txt_desccuenta";
            this.txt_desccuenta.Size = new System.Drawing.Size(395, 20);
            this.txt_desccuenta.TabIndex = 52;
            // 
            // AsientoCVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 558);
            this.Controls.Add(this.btn_Cerrar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grd_Facturas);
            this.Controls.Add(this.btn_SaveData);
            this.Name = "AsientoCVenta";
            this.Text = "AsientoCVenta";
            ((System.ComponentModel.ISupportInitialize)(this.grd_Facturas)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_SaveData;
        private System.Windows.Forms.DataGridView grd_Facturas;
        private System.Windows.Forms.TextBox txt_TipoAsiento;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txt_Correlativo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Debe;
        private System.Windows.Forms.TextBox txt_Haber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Moneda;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Fecha;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_Documento;
        private System.Windows.Forms.TextBox txt_Importe;
        private System.Windows.Forms.TextBox txt_Cuenta;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_TipoDoc;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_Tipo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_Cerrar;
        private System.Windows.Forms.TextBox txt_descripcion;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_glosa;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_cliente;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_desccuenta;
    }
}