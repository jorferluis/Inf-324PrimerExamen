namespace WindowsFormsApplication1
{
    partial class PropiedadesUsuarioForm
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
            this.dataGridViewPropiedades = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCerrarSesión = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPropiedades)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPropiedades
            // 
            this.dataGridViewPropiedades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPropiedades.Location = new System.Drawing.Point(12, 77);
            this.dataGridViewPropiedades.Name = "dataGridViewPropiedades";
            this.dataGridViewPropiedades.Size = new System.Drawing.Size(620, 150);
            this.dataGridViewPropiedades.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Registros de Propiedades";
            // 
            // btnCerrarSesión
            // 
            this.btnCerrarSesión.Location = new System.Drawing.Point(283, 261);
            this.btnCerrarSesión.Name = "btnCerrarSesión";
            this.btnCerrarSesión.Size = new System.Drawing.Size(100, 23);
            this.btnCerrarSesión.TabIndex = 13;
            this.btnCerrarSesión.Text = "Cerrar Sesión";
            this.btnCerrarSesión.UseVisualStyleBackColor = true;
            this.btnCerrarSesión.Click += new System.EventHandler(this.btnCerrarSesión_Click);
            // 
            // PropiedadesUsuarioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 319);
            this.Controls.Add(this.btnCerrarSesión);
            this.Controls.Add(this.dataGridViewPropiedades);
            this.Controls.Add(this.label2);
            this.Name = "PropiedadesUsuarioForm";
            this.Text = "PropiedadesUsuarioForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPropiedades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPropiedades;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCerrarSesión;
    }
}