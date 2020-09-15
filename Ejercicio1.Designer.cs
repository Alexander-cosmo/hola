namespace TP1
{
    partial class Ejercicio1
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
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.btnagregar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lbnum1 = new System.Windows.Forms.ListBox();
            this.lbnumero2 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(188, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese un Nombre";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(316, 20);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(142, 20);
            this.txtnombre.TabIndex = 1;
            // 
            // btnagregar
            // 
            this.btnagregar.Location = new System.Drawing.Point(464, 18);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(75, 23);
            this.btnagregar.TabIndex = 2;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(345, 135);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 32);
            this.button2.TabIndex = 3;
            this.button2.Text = ">";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(345, 216);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 33);
            this.button3.TabIndex = 4;
            this.button3.Text = ">>";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lbnum1
            // 
            this.lbnum1.FormattingEnabled = true;
            this.lbnum1.Location = new System.Drawing.Point(145, 90);
            this.lbnum1.Name = "lbnum1";
            this.lbnum1.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbnum1.Size = new System.Drawing.Size(165, 212);
            this.lbnum1.TabIndex = 5;
            // 
            // lbnumero2
            // 
            this.lbnumero2.FormattingEnabled = true;
            this.lbnumero2.Location = new System.Drawing.Point(446, 90);
            this.lbnumero2.Name = "lbnumero2";
            this.lbnumero2.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lbnumero2.Size = new System.Drawing.Size(184, 212);
            this.lbnumero2.TabIndex = 6;
            this.lbnumero2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // Ejercicio1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbnumero2);
            this.Controls.Add(this.lbnum1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.label1);
            this.Name = "Ejercicio1";
            this.Text = "Ejercicio1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListBox lbnum1;
        private System.Windows.Forms.ListBox lbnumero2;
    }
}