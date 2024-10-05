namespace WindowsFormsApplication1
{
    partial class DashboardRootForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewUsuarios = new System.Windows.Forms.DataGridView();
            this.dataGridViewPropiedades = new System.Windows.Forms.DataGridView();
            this.btnEditarUsuario = new System.Windows.Forms.Button();
            this.btnEliminarUsuario = new System.Windows.Forms.Button();
            this.btnEliminarPropiedad = new System.Windows.Forms.Button();
            this.btnEditarPropiedad = new System.Windows.Forms.Button();
            this.txtNewRol = new System.Windows.Forms.TextBox();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.txtNewUsername = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtPrecioPropiedad = new System.Windows.Forms.TextBox();
            this.usuario = new System.Windows.Forms.Label();
            this.Contraseña = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.Direccion = new System.Windows.Forms.Label();
            this.Descripcion = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtDistrito = new System.Windows.Forms.TextBox();
            this.txtZona = new System.Windows.Forms.TextBox();
            this.txtYFin = new System.Windows.Forms.TextBox();
            this.txtXFin = new System.Windows.Forms.TextBox();
            this.txtYIni = new System.Windows.Forms.TextBox();
            this.txtXIni = new System.Windows.Forms.TextBox();
            this.txtSuperficie = new System.Windows.Forms.TextBox();
            this.txtCI = new System.Windows.Forms.TextBox();
            this.btnCerrarSesión = new System.Windows.Forms.Button();
            this.btnAgregarUsuario = new System.Windows.Forms.Button();
            this.btnAgregarPropiedad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPropiedades)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuarios Registrados";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Registros de Propiedades";
            // 
            // dataGridViewUsuarios
            // 
            this.dataGridViewUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsuarios.Location = new System.Drawing.Point(41, 36);
            this.dataGridViewUsuarios.Name = "dataGridViewUsuarios";
            this.dataGridViewUsuarios.Size = new System.Drawing.Size(370, 150);
            this.dataGridViewUsuarios.TabIndex = 2;
            // 
            // dataGridViewPropiedades
            // 
            this.dataGridViewPropiedades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPropiedades.Location = new System.Drawing.Point(40, 305);
            this.dataGridViewPropiedades.Name = "dataGridViewPropiedades";
            this.dataGridViewPropiedades.Size = new System.Drawing.Size(872, 150);
            this.dataGridViewPropiedades.TabIndex = 3;
            // 
            // btnEditarUsuario
            // 
            this.btnEditarUsuario.Location = new System.Drawing.Point(60, 246);
            this.btnEditarUsuario.Name = "btnEditarUsuario";
            this.btnEditarUsuario.Size = new System.Drawing.Size(87, 23);
            this.btnEditarUsuario.TabIndex = 4;
            this.btnEditarUsuario.Text = "Editar Usuario";
            this.btnEditarUsuario.UseVisualStyleBackColor = true;
            this.btnEditarUsuario.Click += new System.EventHandler(this.btnEditarUsuario_Click_1);
            // 
            // btnEliminarUsuario
            // 
            this.btnEliminarUsuario.Location = new System.Drawing.Point(163, 246);
            this.btnEliminarUsuario.Name = "btnEliminarUsuario";
            this.btnEliminarUsuario.Size = new System.Drawing.Size(109, 23);
            this.btnEliminarUsuario.TabIndex = 5;
            this.btnEliminarUsuario.Text = "Eliminar Usuario";
            this.btnEliminarUsuario.UseVisualStyleBackColor = true;
            this.btnEliminarUsuario.Click += new System.EventHandler(this.btnEliminarUsuario_Click_1);
            // 
            // btnEliminarPropiedad
            // 
            this.btnEliminarPropiedad.Location = new System.Drawing.Point(370, 550);
            this.btnEliminarPropiedad.Name = "btnEliminarPropiedad";
            this.btnEliminarPropiedad.Size = new System.Drawing.Size(109, 23);
            this.btnEliminarPropiedad.TabIndex = 7;
            this.btnEliminarPropiedad.Text = "Eliminar Propiedad";
            this.btnEliminarPropiedad.UseVisualStyleBackColor = true;
            this.btnEliminarPropiedad.Click += new System.EventHandler(this.btnEliminarPropiedad_Click_1);
            // 
            // btnEditarPropiedad
            // 
            this.btnEditarPropiedad.Location = new System.Drawing.Point(267, 550);
            this.btnEditarPropiedad.Name = "btnEditarPropiedad";
            this.btnEditarPropiedad.Size = new System.Drawing.Size(87, 23);
            this.btnEditarPropiedad.TabIndex = 6;
            this.btnEditarPropiedad.Text = "Editar Propiedad";
            this.btnEditarPropiedad.UseVisualStyleBackColor = true;
            this.btnEditarPropiedad.Click += new System.EventHandler(this.btnEditarPropiedad_Click_1);
            // 
            // txtNewRol
            // 
            this.txtNewRol.Location = new System.Drawing.Point(303, 210);
            this.txtNewRol.Name = "txtNewRol";
            this.txtNewRol.Size = new System.Drawing.Size(108, 20);
            this.txtNewRol.TabIndex = 8;
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Location = new System.Drawing.Point(165, 210);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(132, 20);
            this.txtNewPassword.TabIndex = 9;
            // 
            // txtNewUsername
            // 
            this.txtNewUsername.Location = new System.Drawing.Point(40, 210);
            this.txtNewUsername.Name = "txtNewUsername";
            this.txtNewUsername.Size = new System.Drawing.Size(119, 20);
            this.txtNewUsername.TabIndex = 10;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(60, 476);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(89, 20);
            this.txtDescripcion.TabIndex = 12;
            // 
            // txtPrecioPropiedad
            // 
            this.txtPrecioPropiedad.Location = new System.Drawing.Point(421, 517);
            this.txtPrecioPropiedad.Name = "txtPrecioPropiedad";
            this.txtPrecioPropiedad.Size = new System.Drawing.Size(58, 20);
            this.txtPrecioPropiedad.TabIndex = 11;
            // 
            // usuario
            // 
            this.usuario.AutoSize = true;
            this.usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuario.ForeColor = System.Drawing.SystemColors.ControlText;
            this.usuario.Location = new System.Drawing.Point(37, 192);
            this.usuario.Name = "usuario";
            this.usuario.Size = new System.Drawing.Size(118, 15);
            this.usuario.TabIndex = 13;
            this.usuario.Text = "Nombre de Usuario:";
            // 
            // Contraseña
            // 
            this.Contraseña.AutoSize = true;
            this.Contraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Contraseña.Location = new System.Drawing.Point(162, 190);
            this.Contraseña.Name = "Contraseña";
            this.Contraseña.Size = new System.Drawing.Size(85, 17);
            this.Contraseña.TabIndex = 14;
            this.Contraseña.Text = "Contraseña:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(303, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Rol:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(499, 499);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 15);
            this.label7.TabIndex = 42;
            this.label7.Text = "CI del Propietario:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(422, 499);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 15);
            this.label8.TabIndex = 41;
            this.label8.Text = "Precio:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(304, 499);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 15);
            this.label9.TabIndex = 40;
            this.label9.Text = "Superficie (en m²):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(778, 460);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 39;
            this.label4.Text = "Coordenada Y Final:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(669, 460);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 13);
            this.label5.TabIndex = 38;
            this.label5.Text = "Coordenada X Final:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(555, 459);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 13);
            this.label6.TabIndex = 37;
            this.label6.Text = "Coordenada Y Inicial:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(437, 459);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 13);
            this.label10.TabIndex = 36;
            this.label10.Text = "Coordenada X Inicial:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(344, 458);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 15);
            this.label11.TabIndex = 35;
            this.label11.Text = "Distrito:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label12.Location = new System.Drawing.Point(251, 458);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 15);
            this.label12.TabIndex = 34;
            this.label12.Text = "Zona:";
            // 
            // Direccion
            // 
            this.Direccion.AutoSize = true;
            this.Direccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Direccion.Location = new System.Drawing.Point(157, 458);
            this.Direccion.Name = "Direccion";
            this.Direccion.Size = new System.Drawing.Size(62, 15);
            this.Direccion.TabIndex = 33;
            this.Direccion.Text = "Dirección:";
            // 
            // Descripcion
            // 
            this.Descripcion.AutoSize = true;
            this.Descripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Descripcion.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Descripcion.Location = new System.Drawing.Point(57, 458);
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Size = new System.Drawing.Size(75, 15);
            this.Descripcion.TabIndex = 32;
            this.Descripcion.Text = "Descripción:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(156, 476);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(89, 20);
            this.txtDireccion.TabIndex = 43;
            // 
            // txtDistrito
            // 
            this.txtDistrito.Location = new System.Drawing.Point(347, 476);
            this.txtDistrito.Name = "txtDistrito";
            this.txtDistrito.Size = new System.Drawing.Size(89, 20);
            this.txtDistrito.TabIndex = 45;
            // 
            // txtZona
            // 
            this.txtZona.Location = new System.Drawing.Point(251, 476);
            this.txtZona.Name = "txtZona";
            this.txtZona.Size = new System.Drawing.Size(89, 20);
            this.txtZona.TabIndex = 44;
            // 
            // txtYFin
            // 
            this.txtYFin.Location = new System.Drawing.Point(781, 476);
            this.txtYFin.Name = "txtYFin";
            this.txtYFin.Size = new System.Drawing.Size(89, 20);
            this.txtYFin.TabIndex = 49;
            // 
            // txtXFin
            // 
            this.txtXFin.Location = new System.Drawing.Point(672, 476);
            this.txtXFin.Name = "txtXFin";
            this.txtXFin.Size = new System.Drawing.Size(89, 20);
            this.txtXFin.TabIndex = 48;
            // 
            // txtYIni
            // 
            this.txtYIni.Location = new System.Drawing.Point(574, 476);
            this.txtYIni.Name = "txtYIni";
            this.txtYIni.Size = new System.Drawing.Size(89, 20);
            this.txtYIni.TabIndex = 47;
            // 
            // txtXIni
            // 
            this.txtXIni.Location = new System.Drawing.Point(452, 476);
            this.txtXIni.Name = "txtXIni";
            this.txtXIni.Size = new System.Drawing.Size(89, 20);
            this.txtXIni.TabIndex = 46;
            // 
            // txtSuperficie
            // 
            this.txtSuperficie.Location = new System.Drawing.Point(314, 517);
            this.txtSuperficie.Name = "txtSuperficie";
            this.txtSuperficie.Size = new System.Drawing.Size(89, 20);
            this.txtSuperficie.TabIndex = 50;
            // 
            // txtCI
            // 
            this.txtCI.Location = new System.Drawing.Point(502, 517);
            this.txtCI.Name = "txtCI";
            this.txtCI.Size = new System.Drawing.Size(89, 20);
            this.txtCI.TabIndex = 51;
            // 
            // btnCerrarSesión
            // 
            this.btnCerrarSesión.Location = new System.Drawing.Point(609, 550);
            this.btnCerrarSesión.Name = "btnCerrarSesión";
            this.btnCerrarSesión.Size = new System.Drawing.Size(100, 23);
            this.btnCerrarSesión.TabIndex = 77;
            this.btnCerrarSesión.Text = "Cerrar Sesión";
            this.btnCerrarSesión.UseVisualStyleBackColor = true;
            this.btnCerrarSesión.Click += new System.EventHandler(this.btnCerrarSesión_Click);
            // 
            // btnAgregarUsuario
            // 
            this.btnAgregarUsuario.Location = new System.Drawing.Point(284, 246);
            this.btnAgregarUsuario.Name = "btnAgregarUsuario";
            this.btnAgregarUsuario.Size = new System.Drawing.Size(108, 23);
            this.btnAgregarUsuario.TabIndex = 78;
            this.btnAgregarUsuario.Text = "Agregar Usuario";
            this.btnAgregarUsuario.UseVisualStyleBackColor = true;
            this.btnAgregarUsuario.Click += new System.EventHandler(this.btnAgregarUsuario_Click);
            // 
            // btnAgregarPropiedad
            // 
            this.btnAgregarPropiedad.Location = new System.Drawing.Point(485, 550);
            this.btnAgregarPropiedad.Name = "btnAgregarPropiedad";
            this.btnAgregarPropiedad.Size = new System.Drawing.Size(108, 23);
            this.btnAgregarPropiedad.TabIndex = 79;
            this.btnAgregarPropiedad.Text = "Agregar Propiedad";
            this.btnAgregarPropiedad.UseVisualStyleBackColor = true;
            this.btnAgregarPropiedad.Click += new System.EventHandler(this.btnAgregarPropiedad_Click);
            // 
            // DashboardRootForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 585);
            this.Controls.Add(this.btnAgregarPropiedad);
            this.Controls.Add(this.btnAgregarUsuario);
            this.Controls.Add(this.btnCerrarSesión);
            this.Controls.Add(this.txtCI);
            this.Controls.Add(this.txtSuperficie);
            this.Controls.Add(this.txtYFin);
            this.Controls.Add(this.txtXFin);
            this.Controls.Add(this.txtYIni);
            this.Controls.Add(this.txtXIni);
            this.Controls.Add(this.txtDistrito);
            this.Controls.Add(this.txtZona);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.Direccion);
            this.Controls.Add(this.Descripcion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Contraseña);
            this.Controls.Add(this.usuario);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtPrecioPropiedad);
            this.Controls.Add(this.txtNewUsername);
            this.Controls.Add(this.txtNewPassword);
            this.Controls.Add(this.txtNewRol);
            this.Controls.Add(this.btnEliminarPropiedad);
            this.Controls.Add(this.btnEditarPropiedad);
            this.Controls.Add(this.btnEliminarUsuario);
            this.Controls.Add(this.btnEditarUsuario);
            this.Controls.Add(this.dataGridViewPropiedades);
            this.Controls.Add(this.dataGridViewUsuarios);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DashboardRootForm";
            this.Text = "DashboardRootForm";
            this.Load += new System.EventHandler(this.DashboardRootForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPropiedades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewUsuarios;
        private System.Windows.Forms.DataGridView dataGridViewPropiedades;
        private System.Windows.Forms.Button btnEditarUsuario;
        private System.Windows.Forms.Button btnEliminarUsuario;
        private System.Windows.Forms.Button btnEliminarPropiedad;
        private System.Windows.Forms.Button btnEditarPropiedad;
        private System.Windows.Forms.TextBox txtNewRol;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.TextBox txtNewUsername;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtPrecioPropiedad;
        private System.Windows.Forms.Label usuario;
        private System.Windows.Forms.Label Contraseña;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label Direccion;
        private System.Windows.Forms.Label Descripcion;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtDistrito;
        private System.Windows.Forms.TextBox txtZona;
        private System.Windows.Forms.TextBox txtYFin;
        private System.Windows.Forms.TextBox txtXFin;
        private System.Windows.Forms.TextBox txtYIni;
        private System.Windows.Forms.TextBox txtXIni;
        private System.Windows.Forms.TextBox txtSuperficie;
        private System.Windows.Forms.TextBox txtCI;
        private System.Windows.Forms.Button btnCerrarSesión;
        private System.Windows.Forms.Button btnAgregarUsuario;
        private System.Windows.Forms.Button btnAgregarPropiedad;
    }
}