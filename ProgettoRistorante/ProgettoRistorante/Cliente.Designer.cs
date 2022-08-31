
namespace ProgettoRistorante
{
    partial class Cliente
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
            this.indietroButton = new System.Windows.Forms.Button();
            this.aggiungiButton = new System.Windows.Forms.Button();
            this.eliminaButton = new System.Windows.Forms.Button();
            this.scontrinoButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // indietroButton
            // 
            this.indietroButton.Location = new System.Drawing.Point(12, 12);
            this.indietroButton.Name = "indietroButton";
            this.indietroButton.Size = new System.Drawing.Size(75, 23);
            this.indietroButton.TabIndex = 0;
            this.indietroButton.Text = "Indietro";
            this.indietroButton.UseVisualStyleBackColor = true;
            // 
            // aggiungiButton
            // 
            this.aggiungiButton.Location = new System.Drawing.Point(118, 210);
            this.aggiungiButton.Name = "aggiungiButton";
            this.aggiungiButton.Size = new System.Drawing.Size(107, 33);
            this.aggiungiButton.TabIndex = 1;
            this.aggiungiButton.Text = "Ordina piatto";
            this.aggiungiButton.UseVisualStyleBackColor = true;
            this.aggiungiButton.Click += new System.EventHandler(this.aggiungiButton_Click);
            // 
            // eliminaButton
            // 
            this.eliminaButton.Location = new System.Drawing.Point(320, 210);
            this.eliminaButton.Name = "eliminaButton";
            this.eliminaButton.Size = new System.Drawing.Size(107, 33);
            this.eliminaButton.TabIndex = 2;
            this.eliminaButton.Text = "Elimina piatto";
            this.eliminaButton.UseVisualStyleBackColor = true;
            this.eliminaButton.Click += new System.EventHandler(this.eliminaButton_Click);
            // 
            // scontrinoButton
            // 
            this.scontrinoButton.Location = new System.Drawing.Point(528, 210);
            this.scontrinoButton.Name = "scontrinoButton";
            this.scontrinoButton.Size = new System.Drawing.Size(107, 33);
            this.scontrinoButton.TabIndex = 3;
            this.scontrinoButton.Text = "Scontrino";
            this.scontrinoButton.UseVisualStyleBackColor = true;
            this.scontrinoButton.Click += new System.EventHandler(this.scontrinoButton_Click);
            // 
            // Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.scontrinoButton);
            this.Controls.Add(this.eliminaButton);
            this.Controls.Add(this.aggiungiButton);
            this.Controls.Add(this.indietroButton);
            this.Name = "Cliente";
            this.Text = "Cliente";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button indietroButton;
        private System.Windows.Forms.Button aggiungiButton;
        private System.Windows.Forms.Button eliminaButton;
        private System.Windows.Forms.Button scontrinoButton;
    }
}