namespace sueldonetointerfaz
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSueldoBruto = new System.Windows.Forms.Label();
            this.lblAFP = new System.Windows.Forms.Label();
            this.lblSFS = new System.Windows.Forms.Label();
            this.lblTotalDesc = new System.Windows.Forms.Label();
            this.lblSueldoNeto = new System.Windows.Forms.Label();
            this.txt_PagoHoras = new System.Windows.Forms.TextBox();
            this.txt_HorasTrabajadas = new System.Windows.Forms.TextBox();
            this.txt_SueldoBruto = new System.Windows.Forms.TextBox();
            this.txt_AFP = new System.Windows.Forms.TextBox();
            this.txt_SFS = new System.Windows.Forms.TextBox();
            this.txt_TotalDesc = new System.Windows.Forms.TextBox();
            this.txt_SueldoNeto = new System.Windows.Forms.TextBox();
            this.btn_CalcularSueldo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "PagoHoras";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "HorasTrabajadas";
            // 
            // lblSueldoBruto
            // 
            this.lblSueldoBruto.AutoSize = true;
            this.lblSueldoBruto.Location = new System.Drawing.Point(44, 99);
            this.lblSueldoBruto.Name = "lblSueldoBruto";
            this.lblSueldoBruto.Size = new System.Drawing.Size(65, 13);
            this.lblSueldoBruto.TabIndex = 2;
            this.lblSueldoBruto.Text = "SueldoBruto";
            this.lblSueldoBruto.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblAFP
            // 
            this.lblAFP.AutoSize = true;
            this.lblAFP.Location = new System.Drawing.Point(44, 125);
            this.lblAFP.Name = "lblAFP";
            this.lblAFP.Size = new System.Drawing.Size(27, 13);
            this.lblAFP.TabIndex = 3;
            this.lblAFP.Text = "AFP";
            this.lblAFP.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblSFS
            // 
            this.lblSFS.AutoSize = true;
            this.lblSFS.Location = new System.Drawing.Point(44, 148);
            this.lblSFS.Name = "lblSFS";
            this.lblSFS.Size = new System.Drawing.Size(27, 13);
            this.lblSFS.TabIndex = 4;
            this.lblSFS.Text = "SFS";
            // 
            // lblTotalDesc
            // 
            this.lblTotalDesc.AutoSize = true;
            this.lblTotalDesc.Location = new System.Drawing.Point(44, 174);
            this.lblTotalDesc.Name = "lblTotalDesc";
            this.lblTotalDesc.Size = new System.Drawing.Size(56, 13);
            this.lblTotalDesc.TabIndex = 5;
            this.lblTotalDesc.Text = "TotalDesc";
            this.lblTotalDesc.Click += new System.EventHandler(this.label6_Click);
            // 
            // lblSueldoNeto
            // 
            this.lblSueldoNeto.AutoSize = true;
            this.lblSueldoNeto.Location = new System.Drawing.Point(44, 240);
            this.lblSueldoNeto.Name = "lblSueldoNeto";
            this.lblSueldoNeto.Size = new System.Drawing.Size(63, 13);
            this.lblSueldoNeto.TabIndex = 6;
            this.lblSueldoNeto.Text = "SueldoNeto";
            // 
            // txt_PagoHoras
            // 
            this.txt_PagoHoras.Location = new System.Drawing.Point(244, 16);
            this.txt_PagoHoras.Name = "txt_PagoHoras";
            this.txt_PagoHoras.Size = new System.Drawing.Size(100, 20);
            this.txt_PagoHoras.TabIndex = 7;
            this.txt_PagoHoras.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txt_HorasTrabajadas
            // 
            this.txt_HorasTrabajadas.Location = new System.Drawing.Point(244, 38);
            this.txt_HorasTrabajadas.Name = "txt_HorasTrabajadas";
            this.txt_HorasTrabajadas.Size = new System.Drawing.Size(100, 20);
            this.txt_HorasTrabajadas.TabIndex = 8;
            this.txt_HorasTrabajadas.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txt_SueldoBruto
            // 
            this.txt_SueldoBruto.Location = new System.Drawing.Point(244, 92);
            this.txt_SueldoBruto.Name = "txt_SueldoBruto";
            this.txt_SueldoBruto.Size = new System.Drawing.Size(100, 20);
            this.txt_SueldoBruto.TabIndex = 9;
            this.txt_SueldoBruto.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txt_AFP
            // 
            this.txt_AFP.Location = new System.Drawing.Point(244, 118);
            this.txt_AFP.Name = "txt_AFP";
            this.txt_AFP.Size = new System.Drawing.Size(100, 20);
            this.txt_AFP.TabIndex = 10;
            // 
            // txt_SFS
            // 
            this.txt_SFS.Location = new System.Drawing.Point(244, 145);
            this.txt_SFS.Name = "txt_SFS";
            this.txt_SFS.Size = new System.Drawing.Size(100, 20);
            this.txt_SFS.TabIndex = 11;
            // 
            // txt_TotalDesc
            // 
            this.txt_TotalDesc.Location = new System.Drawing.Point(244, 171);
            this.txt_TotalDesc.Name = "txt_TotalDesc";
            this.txt_TotalDesc.Size = new System.Drawing.Size(100, 20);
            this.txt_TotalDesc.TabIndex = 12;
            // 
            // txt_SueldoNeto
            // 
            this.txt_SueldoNeto.Location = new System.Drawing.Point(244, 233);
            this.txt_SueldoNeto.Name = "txt_SueldoNeto";
            this.txt_SueldoNeto.Size = new System.Drawing.Size(100, 20);
            this.txt_SueldoNeto.TabIndex = 13;
            this.txt_SueldoNeto.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // btn_CalcularSueldo
            // 
            this.btn_CalcularSueldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CalcularSueldo.Location = new System.Drawing.Point(85, 299);
            this.btn_CalcularSueldo.Name = "btn_CalcularSueldo";
            this.btn_CalcularSueldo.Size = new System.Drawing.Size(184, 23);
            this.btn_CalcularSueldo.TabIndex = 14;
            this.btn_CalcularSueldo.Text = "Calcular Sueldo";
            this.btn_CalcularSueldo.UseVisualStyleBackColor = true;
            this.btn_CalcularSueldo.Click += new System.EventHandler(this.btn_CalcularSueldo_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_CalcularSueldo);
            this.Controls.Add(this.txt_SueldoNeto);
            this.Controls.Add(this.txt_TotalDesc);
            this.Controls.Add(this.txt_SFS);
            this.Controls.Add(this.txt_AFP);
            this.Controls.Add(this.txt_SueldoBruto);
            this.Controls.Add(this.txt_HorasTrabajadas);
            this.Controls.Add(this.txt_PagoHoras);
            this.Controls.Add(this.lblSueldoNeto);
            this.Controls.Add(this.lblTotalDesc);
            this.Controls.Add(this.lblSFS);
            this.Controls.Add(this.lblAFP);
            this.Controls.Add(this.lblSueldoBruto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Sueldo Neto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSueldoBruto;
        private System.Windows.Forms.Label lblAFP;
        private System.Windows.Forms.Label lblSFS;
        private System.Windows.Forms.Label lblTotalDesc;
        private System.Windows.Forms.Label lblSueldoNeto;
        private System.Windows.Forms.TextBox txt_PagoHoras;
        private System.Windows.Forms.TextBox txt_HorasTrabajadas;
        private System.Windows.Forms.TextBox txt_SueldoBruto;
        private System.Windows.Forms.TextBox txt_AFP;
        private System.Windows.Forms.TextBox txt_SFS;
        private System.Windows.Forms.TextBox txt_TotalDesc;
        private System.Windows.Forms.TextBox txt_SueldoNeto;
        private System.Windows.Forms.Button btn_CalcularSueldo;
    }
}

