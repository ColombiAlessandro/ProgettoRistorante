
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
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.indietro1 = new System.Windows.Forms.Button();
            this.indietro2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bottoneAggiunta
            // 
            this.bottoneAggiunta.Location = new System.Drawing.Point(109, 204);
            this.bottoneAggiunta.Name = "bottoneAggiunta";
            this.bottoneAggiunta.Size = new System.Drawing.Size(103, 33);
            this.bottoneAggiunta.TabIndex = 0;
            this.bottoneAggiunta.Text = "Aggiunta";
            this.bottoneAggiunta.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(218, 204);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 33);
            this.button2.TabIndex = 1;
            this.button2.Text = "Ricerca";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(327, 204);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(103, 33);
            this.button3.TabIndex = 2;
            this.button3.Text = "Visualizza totale";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(436, 204);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(103, 33);
            this.button4.TabIndex = 3;
            this.button4.Text = "Modifica";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(545, 204);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(103, 33);
            this.button5.TabIndex = 4;
            this.button5.Text = "Elimina";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // indietro1
            // 
            this.indietro1.Location = new System.Drawing.Point(12, 12);
            this.indietro1.Name = "indietro1";
            this.indietro1.Size = new System.Drawing.Size(103, 33);
            this.indietro1.TabIndex = 5;
            this.indietro1.Text = "Indietro";
            this.indietro1.UseVisualStyleBackColor = true;
            // 
            // indietro2
            // 
            this.indietro2.Location = new System.Drawing.Point(12, 12);
            this.indietro2.Name = "indietro2";
            this.indietro2.Size = new System.Drawing.Size(103, 33);
            this.indietro2.TabIndex = 6;
            this.indietro2.Text = "Indietro";
            this.indietro2.UseVisualStyleBackColor = true;
            this.indietro2.Visible = false;
            // 
            // Gestore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.indietro2);
            this.Controls.Add(this.indietro1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.bottoneAggiunta);
            this.Name = "Gestore";
            this.Text = "Gestore";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bottoneAggiunta;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button indietro1;
        private System.Windows.Forms.Button indietro2;
    }
}