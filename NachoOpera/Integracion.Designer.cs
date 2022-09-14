
namespace NachoOpera
{
    partial class Integracion
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
            this.cmdSuma = new System.Windows.Forms.Button();
            this.cmdResta = new System.Windows.Forms.Button();
            this.cmdMultiplicacion = new System.Windows.Forms.Button();
            this.cmdDivision = new System.Windows.Forms.Button();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmdSuma
            // 
            this.cmdSuma.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSuma.Location = new System.Drawing.Point(42, 93);
            this.cmdSuma.Name = "cmdSuma";
            this.cmdSuma.Size = new System.Drawing.Size(70, 29);
            this.cmdSuma.TabIndex = 0;
            this.cmdSuma.Text = "SUMA";
            this.cmdSuma.UseVisualStyleBackColor = true;
            // 
            // cmdResta
            // 
            this.cmdResta.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdResta.Location = new System.Drawing.Point(42, 159);
            this.cmdResta.Name = "cmdResta";
            this.cmdResta.Size = new System.Drawing.Size(70, 29);
            this.cmdResta.TabIndex = 1;
            this.cmdResta.Text = "RESTA";
            this.cmdResta.UseVisualStyleBackColor = true;
            // 
            // cmdMultiplicacion
            // 
            this.cmdMultiplicacion.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdMultiplicacion.Location = new System.Drawing.Point(42, 223);
            this.cmdMultiplicacion.Name = "cmdMultiplicacion";
            this.cmdMultiplicacion.Size = new System.Drawing.Size(70, 29);
            this.cmdMultiplicacion.TabIndex = 2;
            this.cmdMultiplicacion.Text = "MULTIP";
            this.cmdMultiplicacion.UseVisualStyleBackColor = true;
            // 
            // cmdDivision
            // 
            this.cmdDivision.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdDivision.Location = new System.Drawing.Point(42, 288);
            this.cmdDivision.Name = "cmdDivision";
            this.cmdDivision.Size = new System.Drawing.Size(70, 29);
            this.cmdDivision.TabIndex = 3;
            this.cmdDivision.Text = "DIVIS";
            this.cmdDivision.UseVisualStyleBackColor = true;
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(231, 140);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(100, 20);
            this.txtNum1.TabIndex = 4;
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(231, 223);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(100, 20);
            this.txtNum2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(402, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 22);
            this.label1.TabIndex = 6;
            // 
            // Integracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 486);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.txtNum1);
            this.Controls.Add(this.cmdDivision);
            this.Controls.Add(this.cmdMultiplicacion);
            this.Controls.Add(this.cmdResta);
            this.Controls.Add(this.cmdSuma);
            this.Name = "Integracion";
            this.Text = "Operaciones";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdSuma;
        private System.Windows.Forms.Button cmdResta;
        private System.Windows.Forms.Button cmdMultiplicacion;
        private System.Windows.Forms.Button cmdDivision;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.Label label1;
    }
}

