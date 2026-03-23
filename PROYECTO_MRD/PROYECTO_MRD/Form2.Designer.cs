namespace PROYECTO_MRD
{
    partial class Form2
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
            this.panelP1 = new System.Windows.Forms.Panel();
            this.btnDP1 = new System.Windows.Forms.Button();
            this.btnCP1 = new System.Windows.Forms.Button();
            this.btnBP1 = new System.Windows.Forms.Button();
            this.btnAP1 = new System.Windows.Forms.Button();
            this.lblP1 = new System.Windows.Forms.Label();
            this.btnSalirMamahuevo = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.panelP1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelP1
            // 
            this.panelP1.Controls.Add(this.btnDP1);
            this.panelP1.Controls.Add(this.btnCP1);
            this.panelP1.Controls.Add(this.btnBP1);
            this.panelP1.Controls.Add(this.btnAP1);
            this.panelP1.Controls.Add(this.lblP1);
            this.panelP1.Location = new System.Drawing.Point(175, 82);
            this.panelP1.Name = "panelP1";
            this.panelP1.Size = new System.Drawing.Size(451, 287);
            this.panelP1.TabIndex = 6;
            // 
            // btnDP1
            // 
            this.btnDP1.Location = new System.Drawing.Point(228, 204);
            this.btnDP1.Name = "btnDP1";
            this.btnDP1.Size = new System.Drawing.Size(217, 48);
            this.btnDP1.TabIndex = 9;
            this.btnDP1.Text = "d)";
            this.btnDP1.UseVisualStyleBackColor = true;
            this.btnDP1.Click += new System.EventHandler(this.btnDP1_Click);
            // 
            // btnCP1
            // 
            this.btnCP1.Location = new System.Drawing.Point(228, 150);
            this.btnCP1.Name = "btnCP1";
            this.btnCP1.Size = new System.Drawing.Size(217, 48);
            this.btnCP1.TabIndex = 8;
            this.btnCP1.Text = "c)";
            this.btnCP1.UseVisualStyleBackColor = true;
            this.btnCP1.Click += new System.EventHandler(this.btnCP1_Click);
            // 
            // btnBP1
            // 
            this.btnBP1.Location = new System.Drawing.Point(5, 204);
            this.btnBP1.Name = "btnBP1";
            this.btnBP1.Size = new System.Drawing.Size(217, 48);
            this.btnBP1.TabIndex = 7;
            this.btnBP1.Text = "b)";
            this.btnBP1.UseVisualStyleBackColor = true;
            this.btnBP1.Click += new System.EventHandler(this.btnBP1_Click);
            // 
            // btnAP1
            // 
            this.btnAP1.Location = new System.Drawing.Point(5, 150);
            this.btnAP1.Name = "btnAP1";
            this.btnAP1.Size = new System.Drawing.Size(217, 48);
            this.btnAP1.TabIndex = 6;
            this.btnAP1.Text = "a)";
            this.btnAP1.UseVisualStyleBackColor = true;
            this.btnAP1.Click += new System.EventHandler(this.btnAP1_Click);
            // 
            // lblP1
            // 
            this.lblP1.AutoSize = true;
            this.lblP1.Font = new System.Drawing.Font("Imprint MT Shadow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblP1.Location = new System.Drawing.Point(65, 66);
            this.lblP1.Name = "lblP1";
            this.lblP1.Size = new System.Drawing.Size(157, 25);
            this.lblP1.TabIndex = 5;
            this.lblP1.Text = "PREGUNTA 1 ";
            this.lblP1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnSalirMamahuevo
            // 
            this.btnSalirMamahuevo.Location = new System.Drawing.Point(148, 408);
            this.btnSalirMamahuevo.Name = "btnSalirMamahuevo";
            this.btnSalirMamahuevo.Size = new System.Drawing.Size(118, 30);
            this.btnSalirMamahuevo.TabIndex = 10;
            this.btnSalirMamahuevo.Text = "&Salir mamahuevo";
            this.btnSalirMamahuevo.UseVisualStyleBackColor = true;
            this.btnSalirMamahuevo.Click += new System.EventHandler(this.btnSalirMamahuevo_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(15, 408);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(118, 30);
            this.btnRegresar.TabIndex = 11;
            this.btnRegresar.Text = "&Regresar al inicio\r\n";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnSalirMamahuevo);
            this.Controls.Add(this.panelP1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUESTIONS";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panelP1.ResumeLayout(false);
            this.panelP1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelP1;
        private System.Windows.Forms.Button btnDP1;
        private System.Windows.Forms.Button btnCP1;
        private System.Windows.Forms.Button btnBP1;
        private System.Windows.Forms.Button btnAP1;
        private System.Windows.Forms.Label lblP1;
        private System.Windows.Forms.Button btnSalirMamahuevo;
        private System.Windows.Forms.Button btnRegresar;
    }
}