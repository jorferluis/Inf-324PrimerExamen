namespace WindowsFormsApplication1
{
    partial class FormAgregarPropiedad
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
            this.btnAgregarPropiedad = new System.Windows.Forms.Button();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.Direccion = new System.Windows.Forms.Label();
            this.Descripcion = new System.Windows.Forms.Label();
            this.txtDistrito = new System.Windows.Forms.TextBox();
            this.txtZona = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtYFin = new System.Windows.Forms.TextBox();
            this.txtXFin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtYIni = new System.Windows.Forms.TextBox();
            this.txtXIni = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCi = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSuperficie = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textId = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAgregarPropiedad
            // 
            this.btnAgregarPropiedad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarPropiedad.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAgregarPropiedad.Location = new System.Drawing.Point(22, 469);
            this.btnAgregarPropiedad.Name = "btnAgregarPropiedad";
            this.btnAgregarPropiedad.Size = new System.Drawing.Size(226, 27);
            this.btnAgregarPropiedad.TabIndex = 15;
            this.btnAgregarPropiedad.Text = "Registrar Propiedad";
            this.btnAgregarPropiedad.UseVisualStyleBackColor = true;
            this.btnAgregarPropiedad.Click += new System.EventHandler(this.btnAgregarPropiedad_Click);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(202, 111);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.PasswordChar = '*';
            this.txtDireccion.Size = new System.Drawing.Size(232, 20);
            this.txtDireccion.TabIndex = 14;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(202, 77);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(232, 20);
            this.txtDescripcion.TabIndex = 13;
            // 
            // Direccion
            // 
            this.Direccion.AutoSize = true;
            this.Direccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Direccion.Location = new System.Drawing.Point(8, 111);
            this.Direccion.Name = "Direccion";
            this.Direccion.Size = new System.Drawing.Size(95, 24);
            this.Direccion.TabIndex = 12;
            this.Direccion.Text = "Dirección:";
            // 
            // Descripcion
            // 
            this.Descripcion.AutoSize = true;
            this.Descripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Descripcion.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Descripcion.Location = new System.Drawing.Point(7, 76);
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Size = new System.Drawing.Size(115, 24);
            this.Descripcion.TabIndex = 11;
            this.Descripcion.Text = "Descripción:";
            // 
            // txtDistrito
            // 
            this.txtDistrito.Location = new System.Drawing.Point(202, 175);
            this.txtDistrito.Name = "txtDistrito";
            this.txtDistrito.PasswordChar = '*';
            this.txtDistrito.Size = new System.Drawing.Size(232, 20);
            this.txtDistrito.TabIndex = 19;
            // 
            // txtZona
            // 
            this.txtZona.Location = new System.Drawing.Point(202, 145);
            this.txtZona.Name = "txtZona";
            this.txtZona.Size = new System.Drawing.Size(232, 20);
            this.txtZona.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 24);
            this.label1.TabIndex = 17;
            this.label1.Text = "Distrito:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(10, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 24);
            this.label2.TabIndex = 16;
            this.label2.Text = "Zona:";
            // 
            // txtYFin
            // 
            this.txtYFin.Location = new System.Drawing.Point(202, 317);
            this.txtYFin.Name = "txtYFin";
            this.txtYFin.PasswordChar = '*';
            this.txtYFin.Size = new System.Drawing.Size(232, 20);
            this.txtYFin.TabIndex = 27;
            // 
            // txtXFin
            // 
            this.txtXFin.Location = new System.Drawing.Point(202, 282);
            this.txtXFin.Name = "txtXFin";
            this.txtXFin.Size = new System.Drawing.Size(232, 20);
            this.txtXFin.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 317);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 24);
            this.label3.TabIndex = 25;
            this.label3.Text = "Coordenada Y Final:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(10, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 24);
            this.label4.TabIndex = 24;
            this.label4.Text = "Coordenada X Final:";
            // 
            // txtYIni
            // 
            this.txtYIni.Location = new System.Drawing.Point(202, 249);
            this.txtYIni.Name = "txtYIni";
            this.txtYIni.PasswordChar = '*';
            this.txtYIni.Size = new System.Drawing.Size(232, 20);
            this.txtYIni.TabIndex = 23;
            // 
            // txtXIni
            // 
            this.txtXIni.Location = new System.Drawing.Point(202, 218);
            this.txtXIni.Name = "txtXIni";
            this.txtXIni.Size = new System.Drawing.Size(232, 20);
            this.txtXIni.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(189, 24);
            this.label5.TabIndex = 21;
            this.label5.Text = "Coordenada Y Inicial:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(8, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(191, 24);
            this.label6.TabIndex = 20;
            this.label6.Text = "Coordenada X Inicial:";
            // 
            // txtCi
            // 
            this.txtCi.Location = new System.Drawing.Point(199, 420);
            this.txtCi.Name = "txtCi";
            this.txtCi.PasswordChar = '*';
            this.txtCi.Size = new System.Drawing.Size(232, 20);
            this.txtCi.TabIndex = 33;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(199, 385);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(232, 20);
            this.txtPrecio.TabIndex = 32;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(7, 420);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(158, 24);
            this.label7.TabIndex = 31;
            this.label7.Text = "CI del Propietario:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(7, 385);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 24);
            this.label8.TabIndex = 30;
            this.label8.Text = "Precio:";
            // 
            // txtSuperficie
            // 
            this.txtSuperficie.Location = new System.Drawing.Point(199, 352);
            this.txtSuperficie.Name = "txtSuperficie";
            this.txtSuperficie.PasswordChar = '*';
            this.txtSuperficie.Size = new System.Drawing.Size(232, 20);
            this.txtSuperficie.TabIndex = 29;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 352);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(164, 24);
            this.label9.TabIndex = 28;
            this.label9.Text = "Superficie (en m²):";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(197, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(249, 26);
            this.label10.TabIndex = 34;
            this.label10.Text = "Registro de Propiedad";
            // 
            // textId
            // 
            this.textId.Location = new System.Drawing.Point(201, 43);
            this.textId.Name = "textId";
            this.textId.Size = new System.Drawing.Size(232, 20);
            this.textId.TabIndex = 36;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label11.Location = new System.Drawing.Point(6, 42);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 24);
            this.label11.TabIndex = 35;
            this.label11.Text = "ID:";
            // 
            // FormAgregarPropiedad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 499);
            this.Controls.Add(this.textId);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtCi);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtSuperficie);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtYFin);
            this.Controls.Add(this.txtXFin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtYIni);
            this.Controls.Add(this.txtXIni);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDistrito);
            this.Controls.Add(this.txtZona);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAgregarPropiedad);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.Direccion);
            this.Controls.Add(this.Descripcion);
            this.Name = "FormAgregarPropiedad";
            this.Text = "FormAgregarPropiedad";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarPropiedad;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label Direccion;
        private System.Windows.Forms.Label Descripcion;
        private System.Windows.Forms.TextBox txtDistrito;
        private System.Windows.Forms.TextBox txtZona;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtYFin;
        private System.Windows.Forms.TextBox txtXFin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtYIni;
        private System.Windows.Forms.TextBox txtXIni;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCi;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSuperficie;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textId;
        private System.Windows.Forms.Label label11;
    }
}