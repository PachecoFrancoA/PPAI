namespace PPAI.Interfaces
{
    partial class FormularioSeleccionRT
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
            this.btn_confirmarSeleccionRT = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.grid11 = new PPAI.Elementos.grid1();
            ((System.ComponentModel.ISupportInitialize)(this.grid11)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Recursos Tecnologicos Disponibles";
            // 
            // btn_confirmarSeleccionRT
            // 
            this.btn_confirmarSeleccionRT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_confirmarSeleccionRT.Location = new System.Drawing.Point(596, 428);
            this.btn_confirmarSeleccionRT.Name = "btn_confirmarSeleccionRT";
            this.btn_confirmarSeleccionRT.Size = new System.Drawing.Size(99, 29);
            this.btn_confirmarSeleccionRT.TabIndex = 2;
            this.btn_confirmarSeleccionRT.Text = "Confirmar";
            this.btn_confirmarSeleccionRT.UseVisualStyleBackColor = true;
            this.btn_confirmarSeleccionRT.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salir.Location = new System.Drawing.Point(54, 428);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(99, 29);
            this.btn_salir.TabIndex = 3;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            // 
            // grid11
            // 
            this.grid11.AllowUserToAddRows = false;
            this.grid11.AllowUserToDeleteRows = false;
            this.grid11.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid11.Location = new System.Drawing.Point(33, 87);
            this.grid11.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grid11.Name = "grid11";
            this.grid11.RowHeadersWidth = 51;
            this.grid11.RowTemplate.Height = 24;
            this.grid11.Size = new System.Drawing.Size(706, 302);
            this.grid11.TabIndex = 4;
            // 
            // FormularioSeleccionRT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 503);
            this.Controls.Add(this.grid11);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_confirmarSeleccionRT);
            this.Controls.Add(this.label1);
            this.Name = "FormularioSeleccionRT";
            this.Text = "FormularioSeleccionRT";
            this.Load += new System.EventHandler(this.FormularioSeleccionRT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid11)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_confirmarSeleccionRT;
        private System.Windows.Forms.Button btn_salir;
        private Elementos.grid1 grid11;
    }
}