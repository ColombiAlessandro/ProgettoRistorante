
namespace ProgettoRistorante
{
    partial class Ordina
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
            this.piattiBox = new System.Windows.Forms.ComboBox();
            this.confermaButton = new System.Windows.Forms.Button();
            this.ingredientiBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.prezzoBox = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tuttiButton = new System.Windows.Forms.Button();
            this.antipastiButton = new System.Windows.Forms.Button();
            this.primiButton = new System.Windows.Forms.Button();
            this.secondiButton = new System.Windows.Forms.Button();
            this.dessertButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // indietroButton
            // 
            this.indietroButton.Location = new System.Drawing.Point(13, 13);
            this.indietroButton.Name = "indietroButton";
            this.indietroButton.Size = new System.Drawing.Size(75, 23);
            this.indietroButton.TabIndex = 0;
            this.indietroButton.Text = "Indietro";
            this.indietroButton.UseVisualStyleBackColor = true;
            this.indietroButton.Click += new System.EventHandler(this.indietroButton_Click);
            // 
            // piattiBox
            // 
            this.piattiBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.piattiBox.FormattingEnabled = true;
            this.piattiBox.Location = new System.Drawing.Point(184, 169);
            this.piattiBox.Name = "piattiBox";
            this.piattiBox.Size = new System.Drawing.Size(121, 21);
            this.piattiBox.TabIndex = 1;
            this.piattiBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // confermaButton
            // 
            this.confermaButton.Location = new System.Drawing.Point(326, 341);
            this.confermaButton.Name = "confermaButton";
            this.confermaButton.Size = new System.Drawing.Size(75, 23);
            this.confermaButton.TabIndex = 2;
            this.confermaButton.Text = "Conferma";
            this.confermaButton.UseVisualStyleBackColor = true;
            this.confermaButton.Click += new System.EventHandler(this.confermaButton_Click);
            // 
            // ingredientiBox
            // 
            this.ingredientiBox.Location = new System.Drawing.Point(604, 157);
            this.ingredientiBox.Name = "ingredientiBox";
            this.ingredientiBox.ReadOnly = true;
            this.ingredientiBox.Size = new System.Drawing.Size(126, 145);
            this.ingredientiBox.TabIndex = 3;
            this.ingredientiBox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(213, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Filtro piatti:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(601, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ingredienti:";
            // 
            // prezzoBox
            // 
            this.prezzoBox.Location = new System.Drawing.Point(184, 280);
            this.prezzoBox.Name = "prezzoBox";
            this.prezzoBox.ReadOnly = true;
            this.prezzoBox.Size = new System.Drawing.Size(121, 22);
            this.prezzoBox.TabIndex = 6;
            this.prezzoBox.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(213, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Prezzo:";
            // 
            // tuttiButton
            // 
            this.tuttiButton.Location = new System.Drawing.Point(13, 106);
            this.tuttiButton.Name = "tuttiButton";
            this.tuttiButton.Size = new System.Drawing.Size(75, 23);
            this.tuttiButton.TabIndex = 8;
            this.tuttiButton.Text = "Tutti";
            this.tuttiButton.UseVisualStyleBackColor = true;
            this.tuttiButton.Click += new System.EventHandler(this.tuttiButton_Click);
            // 
            // antipastiButton
            // 
            this.antipastiButton.Location = new System.Drawing.Point(109, 106);
            this.antipastiButton.Name = "antipastiButton";
            this.antipastiButton.Size = new System.Drawing.Size(75, 23);
            this.antipastiButton.TabIndex = 9;
            this.antipastiButton.Text = "Antipasti";
            this.antipastiButton.UseVisualStyleBackColor = true;
            this.antipastiButton.Click += new System.EventHandler(this.antipastiButton_Click);
            // 
            // primiButton
            // 
            this.primiButton.Location = new System.Drawing.Point(207, 106);
            this.primiButton.Name = "primiButton";
            this.primiButton.Size = new System.Drawing.Size(75, 23);
            this.primiButton.TabIndex = 10;
            this.primiButton.Text = "Primi";
            this.primiButton.UseVisualStyleBackColor = true;
            this.primiButton.Click += new System.EventHandler(this.primiButton_Click);
            // 
            // secondiButton
            // 
            this.secondiButton.Location = new System.Drawing.Point(313, 106);
            this.secondiButton.Name = "secondiButton";
            this.secondiButton.Size = new System.Drawing.Size(75, 23);
            this.secondiButton.TabIndex = 11;
            this.secondiButton.Text = "Secondi";
            this.secondiButton.UseVisualStyleBackColor = true;
            this.secondiButton.Click += new System.EventHandler(this.secondiButton_Click);
            // 
            // dessertButton
            // 
            this.dessertButton.Location = new System.Drawing.Point(417, 106);
            this.dessertButton.Name = "dessertButton";
            this.dessertButton.Size = new System.Drawing.Size(75, 23);
            this.dessertButton.TabIndex = 12;
            this.dessertButton.Text = "Dessert";
            this.dessertButton.UseVisualStyleBackColor = true;
            this.dessertButton.Click += new System.EventHandler(this.dessertButton_Click);
            // 
            // Ordina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dessertButton);
            this.Controls.Add(this.secondiButton);
            this.Controls.Add(this.primiButton);
            this.Controls.Add(this.antipastiButton);
            this.Controls.Add(this.tuttiButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.prezzoBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ingredientiBox);
            this.Controls.Add(this.confermaButton);
            this.Controls.Add(this.piattiBox);
            this.Controls.Add(this.indietroButton);
            this.Name = "Ordina";
            this.Text = "Ordina";
            this.Load += new System.EventHandler(this.Ordina_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button indietroButton;
        private System.Windows.Forms.ComboBox piattiBox;
        private System.Windows.Forms.Button confermaButton;
        private System.Windows.Forms.RichTextBox ingredientiBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox prezzoBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button tuttiButton;
        private System.Windows.Forms.Button antipastiButton;
        private System.Windows.Forms.Button primiButton;
        private System.Windows.Forms.Button secondiButton;
        private System.Windows.Forms.Button dessertButton;
    }
}