
namespace ProgettoRistorante
{
    partial class Elimina
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
            this.confermaButton = new System.Windows.Forms.Button();
            this.indietroButton = new System.Windows.Forms.Button();
            this.nomeText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.eliminaButton = new System.Windows.Forms.Button();
            this.ricompattaButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // confermaButton
            // 
            this.confermaButton.Location = new System.Drawing.Point(344, 319);
            this.confermaButton.Name = "confermaButton";
            this.confermaButton.Size = new System.Drawing.Size(75, 23);
            this.confermaButton.TabIndex = 0;
            this.confermaButton.Text = "Conferma";
            this.confermaButton.UseVisualStyleBackColor = true;
            this.confermaButton.Visible = false;
            this.confermaButton.Click += new System.EventHandler(this.confermaButton_Click);
            // 
            // indietroButton
            // 
            this.indietroButton.Location = new System.Drawing.Point(12, 12);
            this.indietroButton.Name = "indietroButton";
            this.indietroButton.Size = new System.Drawing.Size(75, 23);
            this.indietroButton.TabIndex = 1;
            this.indietroButton.Text = "Indietro";
            this.indietroButton.UseVisualStyleBackColor = true;
            this.indietroButton.Click += new System.EventHandler(this.indietroButton_Click);
            // 
            // nomeText
            // 
            this.nomeText.Location = new System.Drawing.Point(328, 149);
            this.nomeText.Name = "nomeText";
            this.nomeText.Size = new System.Drawing.Size(100, 20);
            this.nomeText.TabIndex = 2;
            this.nomeText.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(313, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome del piatto da eliminare";
            this.label1.Visible = false;
            // 
            // eliminaButton
            // 
            this.eliminaButton.Location = new System.Drawing.Point(168, 215);
            this.eliminaButton.Name = "eliminaButton";
            this.eliminaButton.Size = new System.Drawing.Size(101, 36);
            this.eliminaButton.TabIndex = 4;
            this.eliminaButton.Text = "Elimina piatto";
            this.eliminaButton.UseVisualStyleBackColor = true;
            this.eliminaButton.Click += new System.EventHandler(this.eliminaButton_Click);
            // 
            // ricompattaButton
            // 
            this.ricompattaButton.Location = new System.Drawing.Point(488, 215);
            this.ricompattaButton.Name = "ricompattaButton";
            this.ricompattaButton.Size = new System.Drawing.Size(101, 36);
            this.ricompattaButton.TabIndex = 5;
            this.ricompattaButton.Text = "Ricompatta File";
            this.ricompattaButton.UseVisualStyleBackColor = true;
            this.ricompattaButton.Click += new System.EventHandler(this.ricompattaButton_Click);
            // 
            // Elimina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ricompattaButton);
            this.Controls.Add(this.eliminaButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nomeText);
            this.Controls.Add(this.indietroButton);
            this.Controls.Add(this.confermaButton);
            this.Name = "Elimina";
            this.Text = "Elimina";
            this.Load += new System.EventHandler(this.Elimina_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button confermaButton;
        private System.Windows.Forms.Button indietroButton;
        private System.Windows.Forms.TextBox nomeText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button eliminaButton;
        private System.Windows.Forms.Button ricompattaButton;
    }
}