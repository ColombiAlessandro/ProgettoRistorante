
namespace ProgettoRistorante
{
    partial class Modifica
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
            this.indietroBottone = new System.Windows.Forms.Button();
            this.nomeText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nuovoNomeText = new System.Windows.Forms.TextBox();
            this.nuovoPrezzoText = new System.Windows.Forms.TextBox();
            this.portataBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ingredientiTextBox = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.confermaBottone = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // indietroBottone
            // 
            this.indietroBottone.Location = new System.Drawing.Point(13, 13);
            this.indietroBottone.Name = "indietroBottone";
            this.indietroBottone.Size = new System.Drawing.Size(75, 23);
            this.indietroBottone.TabIndex = 0;
            this.indietroBottone.Text = "Indietro";
            this.indietroBottone.UseVisualStyleBackColor = true;
            // 
            // nomeText
            // 
            this.nomeText.Location = new System.Drawing.Point(29, 106);
            this.nomeText.Name = "nomeText";
            this.nomeText.Size = new System.Drawing.Size(100, 20);
            this.nomeText.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nome del piatto da modificare";
            // 
            // nuovoNomeText
            // 
            this.nuovoNomeText.Location = new System.Drawing.Point(178, 182);
            this.nuovoNomeText.Name = "nuovoNomeText";
            this.nuovoNomeText.Size = new System.Drawing.Size(100, 20);
            this.nuovoNomeText.TabIndex = 6;
            // 
            // nuovoPrezzoText
            // 
            this.nuovoPrezzoText.Location = new System.Drawing.Point(340, 182);
            this.nuovoPrezzoText.Name = "nuovoPrezzoText";
            this.nuovoPrezzoText.Size = new System.Drawing.Size(100, 20);
            this.nuovoPrezzoText.TabIndex = 7;
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
            this.portataBox.Location = new System.Drawing.Point(508, 181);
            this.portataBox.Name = "portataBox";
            this.portataBox.Size = new System.Drawing.Size(121, 21);
            this.portataBox.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(178, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nuovo nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(337, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Nuovo prezzo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(505, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Portata";
            // 
            // ingredientiTextBox
            // 
            this.ingredientiTextBox.Location = new System.Drawing.Point(178, 265);
            this.ingredientiTextBox.Name = "ingredientiTextBox";
            this.ingredientiTextBox.Size = new System.Drawing.Size(136, 153);
            this.ingredientiTextBox.TabIndex = 12;
            this.ingredientiTextBox.Text = "";
            this.ingredientiTextBox.TextChanged += new System.EventHandler(this.ingredientiTextBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(181, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(213, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Nuovi ingredienti (separati andando a capo)";
            // 
            // confermaBottone
            // 
            this.confermaBottone.Location = new System.Drawing.Point(508, 395);
            this.confermaBottone.Name = "confermaBottone";
            this.confermaBottone.Size = new System.Drawing.Size(75, 23);
            this.confermaBottone.TabIndex = 14;
            this.confermaBottone.Text = "Conferma";
            this.confermaBottone.UseVisualStyleBackColor = true;
            this.confermaBottone.Click += new System.EventHandler(this.confermaBottone_Click);
            // 
            // Modifica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.confermaBottone);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ingredientiTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.portataBox);
            this.Controls.Add(this.nuovoPrezzoText);
            this.Controls.Add(this.nuovoNomeText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nomeText);
            this.Controls.Add(this.indietroBottone);
            this.Name = "Modifica";
            this.Text = "Modifica";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button indietroBottone;
        private System.Windows.Forms.TextBox nomeText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nuovoNomeText;
        private System.Windows.Forms.TextBox nuovoPrezzoText;
        private System.Windows.Forms.ComboBox portataBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox ingredientiTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button confermaBottone;
    }
}