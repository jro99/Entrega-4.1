namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.grados = new System.Windows.Forms.TextBox();
            this.celtofar = new System.Windows.Forms.RadioButton();
            this.fartocel = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(111, 146);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "Convertir";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Grados";
            // 
            // grados
            // 
            this.grados.Location = new System.Drawing.Point(145, 40);
            this.grados.Name = "grados";
            this.grados.Size = new System.Drawing.Size(100, 26);
            this.grados.TabIndex = 4;
            // 
            // celtofar
            // 
            this.celtofar.AutoSize = true;
            this.celtofar.Location = new System.Drawing.Point(145, 72);
            this.celtofar.Name = "celtofar";
            this.celtofar.Size = new System.Drawing.Size(192, 24);
            this.celtofar.TabIndex = 5;
            this.celtofar.TabStop = true;
            this.celtofar.Text = "de Celsius a Farenheit";
            this.celtofar.UseVisualStyleBackColor = true;
            // 
            // fartocel
            // 
            this.fartocel.AutoSize = true;
            this.fartocel.Location = new System.Drawing.Point(145, 116);
            this.fartocel.Name = "fartocel";
            this.fartocel.Size = new System.Drawing.Size(192, 24);
            this.fartocel.TabIndex = 6;
            this.fartocel.TabStop = true;
            this.fartocel.Text = "de Farenheit a Celsius";
            this.fartocel.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 345);
            this.Controls.Add(this.fartocel);
            this.Controls.Add(this.celtofar);
            this.Controls.Add(this.grados);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox grados;
        private System.Windows.Forms.RadioButton celtofar;
        private System.Windows.Forms.RadioButton fartocel;
    }
}

