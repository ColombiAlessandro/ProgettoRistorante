
namespace ProgettoRistorante
{
    partial class Aggiunta
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
            this.ingredientiText = new System.Windows.Forms.RichTextBox();
            this.prezzoText = new System.Windows.Forms.TextBox();
            this.nomeText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.portataBox = new System.Windows.Forms.ComboBox();
            this.indietroBottone = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // confermaButton
            // 
            this.confermaButton.Location = new System.Drawing.Point(334, 344);
            this.confermaButton.Name = "confermaButton";
            this.confermaButton.Size = new System.Drawing.Size(90, 29);
            this.confermaButton.TabIndex = 0;
            this.confermaButton.Text = "Aggiungi";
            this.confermaButton.UseVisualStyleBackColor = true;
            this.confermaButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // ingredientiText
            // 
            this.ingredientiText.Location = new System.Drawing.Point(593, 146);
            this.ingredientiText.Name = "ingredientiText";
            this.ingredientiText.Size = new System.Drawing.Size(124, 147);
            this.ingredientiText.TabIndex = 1;
            this.ingredientiText.Text = "";
            this.ingredientiText.TextChanged += new System.EventHandler(this.ingredientiText_TextChanged);
            // 
            // prezzoText
            // 
            this.prezzoText.Location = new System.Drawing.Point(347, 146);
            this.prezzoText.Name = "prezzoText";
            this.prezzoText.Size = new System.Drawing.Size(106, 20);
            this.prezzoText.TabIndex = 2;
            // 
            // nomeText
            // 
            this.nomeText.Location = new System.Drawing.Point(122, 146);
            this.nomeText.Name = "nomeText";
            this.nomeText.Size = new System.Drawing.Size(100, 20);
            this.nomeText.TabIndex = 3;
            this.nomeText.TextChanged += new System.EventHandler(this.nomeText_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nome pasto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(344, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Prezzo (in decimale)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(590, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ingredienti";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(533, 296);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(224, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Gli ingredienti vanno separati andando a capo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(119, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Portata";
            // 
            // portataBox
            // 
            this.portataBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.portataBox.FormattingEnabled = true;
            this.portataBox.Items.AddRange(new object[] {
            "Antipasto",
            "Primo",
            "Secondo",
            "Dessert"});
            this.portataBox.Location = new System.Drawing.Point(122, 246);
            this.portataBox.Name = "portataBox";
            this.portataBox.Size = new System.Drawing.Size(121, 21);
            this.portataBox.TabIndex = 0;
            // 
            // indietroBottone
            // 
            this.indietroBottone.Location = new System.Drawing.Point(13, 13);
            this.indietroBottone.Name = "indietroBottone";
            this.indietroBottone.Size = new System.Drawing.Size(75, 23);
            this.indietroBottone.TabIndex = 10;
            this.indietroBottone.Text = "Indietro";
            this.indietroBottone.UseVisualStyleBackColor = true;
            this.indietroBottone.Click += new System.EventHandler(this.indietroBottone_Click);
            // 
            // Aggiunta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.indietroBottone);
            this.Controls.Add(this.portataBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nomeText);
            this.Controls.Add(this.prezzoText);
            this.Controls.Add(this.ingredientiText);
            this.Controls.Add(this.confermaButton);
            this.Name = "Aggiunta";
            this.Text = "Aggiunta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button confermaButton;
        private System.Windows.Forms.RichTextBox ingredientiText;
        private System.Windows.Forms.TextBox prezzoText;
        private System.Windows.Forms.TextBox nomeText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox portataBox;
        private System.Windows.Forms.Button indietroBottone;
    }
}