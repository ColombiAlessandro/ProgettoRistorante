
namespace ProgettoRistorante
{
    partial class Gestore
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
            this.bottoneAggiunta = new System.Windows.Forms.Button();
            this.bottoneRicerca = new System.Windows.Forms.Button();
            this.bottoneVisualizza = new System.Windows.Forms.Button();
            this.bottoneModifica = new System.Windows.Forms.Button();
            this.bottoneElimina = new System.Windows.Forms.Button();
            this.indietro1 = new System.Windows.Forms.Button();
            this.recuperaButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bottoneAggiunta
            // 
            this.bottoneAggiunta.Location = new System.Drawing.Point(65, 204);
            this.bottoneAggiunta.Name = "bottoneAggiunta";
            this.bottoneAggiunta.Size = new System.Drawing.Size(103, 33);
            this.bottoneAggiunta.TabIndex = 0;
            this.bottoneAggiunta.Text = "Aggiunta";
            this.bottoneAggiunta.UseVisualStyleBackColor = true;
            this.bottoneAggiunta.Click += new System.EventHandler(this.bottoneAggiunta_Click);
            // 
            // bottoneRicerca
            // 
            this.bottoneRicerca.Location = new System.Drawing.Point(174, 204);
            this.bottoneRicerca.Name = "bottoneRicerca";
            this.bottoneRicerca.Size = new System.Drawing.Size(103, 33);
            this.bottoneRicerca.TabIndex = 1;
            this.bottoneRicerca.Text = "Ricerca";
            this.bottoneRicerca.UseVisualStyleBackColor = true;
            this.bottoneRicerca.Click += new System.EventHandler(this.bottoneRicerca_Click);
            // 
            // bottoneVisualizza
            // 
            this.bottoneVisualizza.Location = new System.Drawing.Point(283, 204);
            this.bottoneVisualizza.Name = "bottoneVisualizza";
            this.bottoneVisualizza.Size = new System.Drawing.Size(103, 33);
            this.bottoneVisualizza.TabIndex = 2;
            this.bottoneVisualizza.Text = "Visualizza totale";
            this.bottoneVisualizza.UseVisualStyleBackColor = true;
            this.bottoneVisualizza.Click += new System.EventHandler(this.bottoneVisualizza_Click);
            // 
            // bottoneModifica
            // 
            this.bottoneModifica.Location = new System.Drawing.Point(391, 204);
            this.bottoneModifica.Name = "bottoneModifica";
            this.bottoneModifica.Size = new System.Drawing.Size(103, 33);
            this.bottoneModifica.TabIndex = 3;
            this.bottoneModifica.Text = "Modifica";
            this.bottoneModifica.UseVisualStyleBackColor = true;
            this.bottoneModifica.Click += new System.EventHandler(this.bottoneModifica_Click);
            // 
            // bottoneElimina
            // 
            this.bottoneElimina.Location = new System.Drawing.Point(500, 204);
            this.bottoneElimina.Name = "bottoneElimina";
            this.bottoneElimina.Size = new System.Drawing.Size(103, 33);
            this.bottoneElimina.TabIndex = 4;
            this.bottoneElimina.Text = "Elimina";
            this.bottoneElimina.UseVisualStyleBackColor = true;
            this.bottoneElimina.Click += new System.EventHandler(this.bottoneElimina_Click);
            // 
            // indietro1
            // 
            this.indietro1.Location = new System.Drawing.Point(12, 12);
            this.indietro1.Name = "indietro1";
            this.indietro1.Size = new System.Drawing.Size(103, 33);
            this.indietro1.TabIndex = 5;
            this.indietro1.Text = "Indietro";
            this.indietro1.UseVisualStyleBackColor = true;
            this.indietro1.Click += new System.EventHandler(this.indietro1_Click);
            // 
            // recuperaButton
            // 
            this.recuperaButton.Location = new System.Drawing.Point(609, 204);
            this.recuperaButton.Name = "recuperaButton";
            this.recuperaButton.Size = new System.Drawing.Size(103, 33);
            this.recuperaButton.TabIndex = 10;
            this.recuperaButton.Text = "Recupera piatto";
            this.recuperaButton.UseVisualStyleBackColor = true;
            this.recuperaButton.Click += new System.EventHandler(this.recuperaButton_Click);
            // 
            // Gestore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.recuperaButton);
            this.Controls.Add(this.indietro1);
            this.Controls.Add(this.bottoneElimina);
            this.Controls.Add(this.bottoneModifica);
            this.Controls.Add(this.bottoneVisualizza);
            this.Controls.Add(this.bottoneRicerca);
            this.Controls.Add(this.bottoneAggiunta);
            this.Name = "Gestore";
            this.Text = "Gestore";
            this.Load += new System.EventHandler(this.Gestore_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bottoneAggiunta;
        private System.Windows.Forms.Button bottoneRicerca;
        private System.Windows.Forms.Button bottoneVisualizza;
        private System.Windows.Forms.Button bottoneModifica;
        private System.Windows.Forms.Button bottoneElimina;
        private System.Windows.Forms.Button indietro1;
        private System.Windows.Forms.Button recuperaButton;
    }
}