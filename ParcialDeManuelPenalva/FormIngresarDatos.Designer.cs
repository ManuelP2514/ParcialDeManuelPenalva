
namespace ParcialDeManuelPenalva
{
    partial class FormIngresarDatos
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
            this.Radio = new System.Windows.Forms.Label();
            this.textBoxRadio = new System.Windows.Forms.TextBox();
            this.ButtonAceppt = new System.Windows.Forms.Button();
            this.ButtonCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Radio
            // 
            this.Radio.AutoSize = true;
            this.Radio.Location = new System.Drawing.Point(12, 9);
            this.Radio.Name = "Radio";
            this.Radio.Size = new System.Drawing.Size(120, 20);
            this.Radio.TabIndex = 0;
            this.Radio.Text = "Valor Del Radio";
            this.Radio.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxRadio
            // 
            this.textBoxRadio.Location = new System.Drawing.Point(138, 9);
            this.textBoxRadio.Name = "textBoxRadio";
            this.textBoxRadio.Size = new System.Drawing.Size(131, 26);
            this.textBoxRadio.TabIndex = 1;
            this.textBoxRadio.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ButtonAceppt
            // 
            this.ButtonAceppt.Location = new System.Drawing.Point(27, 84);
            this.ButtonAceppt.Name = "ButtonAceppt";
            this.ButtonAceppt.Size = new System.Drawing.Size(105, 62);
            this.ButtonAceppt.TabIndex = 2;
            this.ButtonAceppt.Text = "Aceptar";
            this.ButtonAceppt.UseVisualStyleBackColor = true;
            this.ButtonAceppt.Click += new System.EventHandler(this.ButtonAceppt_Click);
            // 
            // ButtonCancelar
            // 
            this.ButtonCancelar.Location = new System.Drawing.Point(194, 84);
            this.ButtonCancelar.Name = "ButtonCancelar";
            this.ButtonCancelar.Size = new System.Drawing.Size(102, 62);
            this.ButtonCancelar.TabIndex = 3;
            this.ButtonCancelar.Text = "Cancelar";
            this.ButtonCancelar.UseVisualStyleBackColor = true;
            // 
            // FormIngresarDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ButtonCancelar);
            this.Controls.Add(this.ButtonAceppt);
            this.Controls.Add(this.textBoxRadio);
            this.Controls.Add(this.Radio);
            this.Name = "FormIngresarDatos";
            this.Text = "FormIngresarDatos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Radio;
        private System.Windows.Forms.TextBox textBoxRadio;
        private System.Windows.Forms.Button ButtonAceppt;
        private System.Windows.Forms.Button ButtonCancelar;
    }
}