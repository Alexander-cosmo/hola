namespace TP1
{
    partial class Ejercicio3
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbsoltero = new System.Windows.Forms.RadioButton();
            this.rbMasculino = new System.Windows.Forms.RadioButton();
            this.cbloficio = new System.Windows.Forms.CheckedListBox();
            this.rbCasado = new System.Windows.Forms.RadioButton();
            this.rbFemenino = new System.Windows.Forms.RadioButton();
            this.btnmostrar = new System.Windows.Forms.Button();
            this.lblresultado = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbFemenino);
            this.groupBox1.Controls.Add(this.rbMasculino);
            this.groupBox1.Location = new System.Drawing.Point(42, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(153, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sexo";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbCasado);
            this.groupBox2.Controls.Add(this.rbsoltero);
            this.groupBox2.Location = new System.Drawing.Point(303, 40);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(149, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Estado Civil";
            // 
            // rbsoltero
            // 
            this.rbsoltero.AutoSize = true;
            this.rbsoltero.Checked = true;
            this.rbsoltero.Location = new System.Drawing.Point(23, 20);
            this.rbsoltero.Name = "rbsoltero";
            this.rbsoltero.Size = new System.Drawing.Size(58, 17);
            this.rbsoltero.TabIndex = 0;
            this.rbsoltero.TabStop = true;
            this.rbsoltero.Tag = "";
            this.rbsoltero.Text = "Soltero";
            this.rbsoltero.UseVisualStyleBackColor = true;
            // 
            // rbMasculino
            // 
            this.rbMasculino.AutoSize = true;
            this.rbMasculino.Checked = true;
            this.rbMasculino.Location = new System.Drawing.Point(22, 20);
            this.rbMasculino.Name = "rbMasculino";
            this.rbMasculino.Size = new System.Drawing.Size(73, 17);
            this.rbMasculino.TabIndex = 0;
            this.rbMasculino.TabStop = true;
            this.rbMasculino.Text = "Masculino";
            this.rbMasculino.UseVisualStyleBackColor = true;
            // 
            // cbloficio
            // 
            this.cbloficio.FormattingEnabled = true;
            this.cbloficio.Items.AddRange(new object[] {
            "Data Entry",
            "Operador de PC",
            "Programador",
            "Reparador de PC",
            "Tester"});
            this.cbloficio.Location = new System.Drawing.Point(149, 146);
            this.cbloficio.Name = "cbloficio";
            this.cbloficio.Size = new System.Drawing.Size(206, 94);
            this.cbloficio.TabIndex = 3;
            // 
            // rbCasado
            // 
            this.rbCasado.AutoSize = true;
            this.rbCasado.Location = new System.Drawing.Point(23, 44);
            this.rbCasado.Name = "rbCasado";
            this.rbCasado.Size = new System.Drawing.Size(61, 17);
            this.rbCasado.TabIndex = 1;
            this.rbCasado.Text = "Casado";
            this.rbCasado.UseVisualStyleBackColor = true;
            // 
            // rbFemenino
            // 
            this.rbFemenino.AutoSize = true;
            this.rbFemenino.Location = new System.Drawing.Point(22, 44);
            this.rbFemenino.Name = "rbFemenino";
            this.rbFemenino.Size = new System.Drawing.Size(71, 17);
            this.rbFemenino.TabIndex = 1;
            this.rbFemenino.Text = "Femenino";
            this.rbFemenino.UseVisualStyleBackColor = true;
            // 
            // btnmostrar
            // 
            this.btnmostrar.Location = new System.Drawing.Point(197, 246);
            this.btnmostrar.Name = "btnmostrar";
            this.btnmostrar.Size = new System.Drawing.Size(106, 46);
            this.btnmostrar.TabIndex = 4;
            this.btnmostrar.Text = "Mostrar Seleccionados";
            this.btnmostrar.UseVisualStyleBackColor = true;
            this.btnmostrar.Click += new System.EventHandler(this.btnmostrar_Click);
            // 
            // lblresultado
            // 
            this.lblresultado.AutoSize = true;
            this.lblresultado.Location = new System.Drawing.Point(61, 304);
            this.lblresultado.Name = "lblresultado";
            this.lblresultado.Size = new System.Drawing.Size(171, 13);
            this.lblresultado.TabIndex = 5;
            this.lblresultado.Text = "Los elementos Seleccionados son:";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(64, 321);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(0, 13);
            this.lbl1.TabIndex = 6;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(64, 334);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(0, 13);
            this.lbl2.TabIndex = 7;
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(64, 347);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(0, 13);
            this.lbl3.TabIndex = 8;
            this.lbl3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Ejercicio3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 384);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.lblresultado);
            this.Controls.Add(this.btnmostrar);
            this.Controls.Add(this.cbloficio);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Ejercicio3";
            this.Text = "Ejercicio3";
            this.Load += new System.EventHandler(this.Ejercicio3_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbMasculino;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbsoltero;
        private System.Windows.Forms.CheckedListBox cbloficio;
        private System.Windows.Forms.RadioButton rbFemenino;
        private System.Windows.Forms.RadioButton rbCasado;
        private System.Windows.Forms.Button btnmostrar;
        private System.Windows.Forms.Label lblresultado;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
    }
}