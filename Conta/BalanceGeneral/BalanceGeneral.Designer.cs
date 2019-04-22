namespace Contabilidad.BalanceGeneral
{
    partial class BalanceGeneral
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_anio = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_Mes = new System.Windows.Forms.ComboBox();
            this.btn_Cerrar = new System.Windows.Forms.Button();
            this.btn_excel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 62;
            this.label1.Text = "Año:";
            // 
            // cmb_anio
            // 
            this.cmb_anio.FormattingEnabled = true;
            this.cmb_anio.Location = new System.Drawing.Point(85, 12);
            this.cmb_anio.Name = "cmb_anio";
            this.cmb_anio.Size = new System.Drawing.Size(135, 21);
            this.cmb_anio.TabIndex = 61;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 60;
            this.label2.Text = "Mes :";
            // 
            // cmb_Mes
            // 
            this.cmb_Mes.FormattingEnabled = true;
            this.cmb_Mes.Location = new System.Drawing.Point(85, 49);
            this.cmb_Mes.Name = "cmb_Mes";
            this.cmb_Mes.Size = new System.Drawing.Size(135, 21);
            this.cmb_Mes.TabIndex = 59;
            // 
            // btn_Cerrar
            // 
            this.btn_Cerrar.Image = global::Contabilidad.Properties.Resources.close;
            this.btn_Cerrar.Location = new System.Drawing.Point(171, 82);
            this.btn_Cerrar.Name = "btn_Cerrar";
            this.btn_Cerrar.Size = new System.Drawing.Size(49, 43);
            this.btn_Cerrar.TabIndex = 64;
            this.btn_Cerrar.UseVisualStyleBackColor = true;
            this.btn_Cerrar.Click += new System.EventHandler(this.btn_Cerrar_Click);
            // 
            // btn_excel
            // 
            this.btn_excel.Image = global::Contabilidad.Properties.Resources.excel1;
            this.btn_excel.Location = new System.Drawing.Point(28, 82);
            this.btn_excel.Name = "btn_excel";
            this.btn_excel.Size = new System.Drawing.Size(51, 43);
            this.btn_excel.TabIndex = 63;
            this.btn_excel.UseVisualStyleBackColor = true;
            this.btn_excel.Click += new System.EventHandler(this.btn_excel_Click);
            // 
            // BalanceGeneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 143);
            this.Controls.Add(this.btn_Cerrar);
            this.Controls.Add(this.btn_excel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_anio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmb_Mes);
            this.Name = "BalanceGeneral";
            this.Text = "BalanceGeneral";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_anio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_Mes;
        private System.Windows.Forms.Button btn_Cerrar;
        private System.Windows.Forms.Button btn_excel;
    }
}