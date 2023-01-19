namespace Presentacion
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
            this.gridPacientes = new System.Windows.Forms.DataGridView();
            this.gridMedicos = new System.Windows.Forms.DataGridView();
            this.listMedicos = new System.Windows.Forms.ListBox();
            this.listHabitaciones = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridPacientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMedicos)).BeginInit();
            this.SuspendLayout();
            // 
            // gridPacientes
            // 
            this.gridPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPacientes.Location = new System.Drawing.Point(68, 47);
            this.gridPacientes.Name = "gridPacientes";
            this.gridPacientes.RowHeadersWidth = 51;
            this.gridPacientes.Size = new System.Drawing.Size(240, 150);
            this.gridPacientes.TabIndex = 0;
            // 
            // gridMedicos
            // 
            this.gridMedicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridMedicos.Location = new System.Drawing.Point(68, 236);
            this.gridMedicos.Name = "gridMedicos";
            this.gridMedicos.RowHeadersWidth = 51;
            this.gridMedicos.Size = new System.Drawing.Size(240, 150);
            this.gridMedicos.TabIndex = 1;
            // 
            // listMedicos
            // 
            this.listMedicos.FormattingEnabled = true;
            this.listMedicos.ItemHeight = 16;
            this.listMedicos.Location = new System.Drawing.Point(369, 65);
            this.listMedicos.Name = "listMedicos";
            this.listMedicos.Size = new System.Drawing.Size(359, 132);
            this.listMedicos.TabIndex = 2;
            // 
            // listHabitaciones
            // 
            this.listHabitaciones.FormattingEnabled = true;
            this.listHabitaciones.ItemHeight = 16;
            this.listHabitaciones.Location = new System.Drawing.Point(369, 254);
            this.listHabitaciones.Name = "listHabitaciones";
            this.listHabitaciones.Size = new System.Drawing.Size(359, 132);
            this.listHabitaciones.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listHabitaciones);
            this.Controls.Add(this.listMedicos);
            this.Controls.Add(this.gridMedicos);
            this.Controls.Add(this.gridPacientes);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.gridPacientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMedicos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridPacientes;
        private System.Windows.Forms.DataGridView gridMedicos;
        private System.Windows.Forms.ListBox listMedicos;
        private System.Windows.Forms.ListBox listHabitaciones;
    }
}

