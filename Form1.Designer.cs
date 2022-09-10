namespace WindowForms_proycto_del_video
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAlmacenar = new System.Windows.Forms.Button();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtidentificacion = new System.Windows.Forms.TextBox();
            this.txtasignaciondia = new System.Windows.Forms.TextBox();
            this.txtdiaslaborados = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDevengado = new System.Windows.Forms.TextBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.error1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.error1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(178, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(493, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calculo de la nomina del trabajo";
            // 
            // btnAlmacenar
            // 
            this.btnAlmacenar.Location = new System.Drawing.Point(236, 344);
            this.btnAlmacenar.Name = "btnAlmacenar";
            this.btnAlmacenar.Size = new System.Drawing.Size(263, 48);
            this.btnAlmacenar.TabIndex = 1;
            this.btnAlmacenar.Text = "Guardar registro de empleado";
            this.btnAlmacenar.UseVisualStyleBackColor = true;
            this.btnAlmacenar.Click += new System.EventHandler(this.btnAlmacenar_Click);
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(309, 99);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(203, 27);
            this.txtnombre.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(94, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Identificacion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(94, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Asignacion saldo dia";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(94, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Dias laborados";
            // 
            // txtidentificacion
            // 
            this.txtidentificacion.Location = new System.Drawing.Point(309, 143);
            this.txtidentificacion.Name = "txtidentificacion";
            this.txtidentificacion.Size = new System.Drawing.Size(203, 27);
            this.txtidentificacion.TabIndex = 2;
            // 
            // txtasignaciondia
            // 
            this.txtasignaciondia.Location = new System.Drawing.Point(309, 212);
            this.txtasignaciondia.Name = "txtasignaciondia";
            this.txtasignaciondia.Size = new System.Drawing.Size(203, 27);
            this.txtasignaciondia.TabIndex = 7;
            this.txtasignaciondia.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtdiaslaborados
            // 
            this.txtdiaslaborados.Location = new System.Drawing.Point(309, 271);
            this.txtdiaslaborados.Name = "txtdiaslaborados";
            this.txtdiaslaborados.Size = new System.Drawing.Size(203, 27);
            this.txtdiaslaborados.TabIndex = 8;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(236, 406);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(263, 36);
            this.btnCalcular.TabIndex = 9;
            this.btnCalcular.Text = "Calcular salario";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(94, 470);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Valor total Devengado";
            // 
            // txtDevengado
            // 
            this.txtDevengado.Location = new System.Drawing.Point(273, 467);
            this.txtDevengado.Name = "txtDevengado";
            this.txtDevengado.Size = new System.Drawing.Size(203, 27);
            this.txtDevengado.TabIndex = 11;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(531, 470);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(94, 29);
            this.btnNuevo.TabIndex = 12;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(668, 470);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(94, 29);
            this.btnsalir.TabIndex = 13;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // error1
            // 
            this.error1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 534);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.txtDevengado);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtdiaslaborados);
            this.Controls.Add(this.txtasignaciondia);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtidentificacion);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.btnAlmacenar);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "x";
            ((System.ComponentModel.ISupportInitialize)(this.error1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button btnAlmacenar;
        private TextBox txtnombre;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtidentificacion;
        private TextBox txtasignaciondia;
        private TextBox txtdiaslaborados;
        private Button btnCalcular;
        private Label label6;
        private TextBox txtDevengado;
        private Button btnNuevo;
        private Button btnsalir;
        private ErrorProvider error1;
    }
}