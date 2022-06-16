namespace PPAI.Interfaces
{
    partial class FrmVisulizarCambios
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
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.grid12 = new PPAI.Elementos.grid1();
            this.grid11 = new PPAI.Elementos.grid1();
            ((System.ComponentModel.ISupportInitialize)(this.grid12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid11)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(503, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Visualizando Cambios De Estados";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 87);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Turnos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(612, 91);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Recursos Tecnologicos";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(956, 416);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 43);
            this.button1.TabIndex = 5;
            this.button1.Text = "EnviarNotificacion";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(761, 416);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(157, 43);
            this.button2.TabIndex = 6;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // grid12
            // 
            this.grid12.AllowUserToAddRows = false;
            this.grid12.AllowUserToDeleteRows = false;
            this.grid12.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid12.Location = new System.Drawing.Point(616, 134);
            this.grid12.Margin = new System.Windows.Forms.Padding(4);
            this.grid12.MultiSelect = false;
            this.grid12.Name = "grid12";
            this.grid12.ReadOnly = true;
            this.grid12.RowHeadersWidth = 51;
            this.grid12.Size = new System.Drawing.Size(497, 123);
            this.grid12.TabIndex = 4;
            // 
            // grid11
            // 
            this.grid11.AllowUserToAddRows = false;
            this.grid11.AllowUserToDeleteRows = false;
            this.grid11.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid11.Location = new System.Drawing.Point(36, 134);
            this.grid11.Margin = new System.Windows.Forms.Padding(4);
            this.grid11.MultiSelect = false;
            this.grid11.Name = "grid11";
            this.grid11.ReadOnly = true;
            this.grid11.RowHeadersWidth = 51;
            this.grid11.Size = new System.Drawing.Size(468, 218);
            this.grid11.TabIndex = 2;
            // 
            // FrmVisulizarCambios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 474);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.grid12);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.grid11);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmVisulizarCambios";
            this.Text = "FrmVisulizarCambios";
            ((System.ComponentModel.ISupportInitialize)(this.grid12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid11)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Elementos.grid1 grid11;
        private System.Windows.Forms.Label label3;
        private Elementos.grid1 grid12;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}