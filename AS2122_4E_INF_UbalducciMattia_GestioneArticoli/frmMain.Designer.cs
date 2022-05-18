namespace AS2122_4E_INF_UbalducciMattia_GestioneArticoli
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblCodice = new System.Windows.Forms.Label();
            this.lblDescrizione = new System.Windows.Forms.Label();
            this.lblUnitaDiMisura = new System.Windows.Forms.Label();
            this.lblPrezzo = new System.Windows.Forms.Label();
            this.txtCodice = new System.Windows.Forms.TextBox();
            this.txtDescrizione = new System.Windows.Forms.TextBox();
            this.txtPrezzo = new System.Windows.Forms.TextBox();
            this.cmbUnitaDiMisura = new System.Windows.Forms.ComboBox();
            this.btnAggiungiModifica = new System.Windows.Forms.Button();
            this.lblArticolo = new System.Windows.Forms.Label();
            this.cmbVisualizza = new System.Windows.Forms.ComboBox();
            this.lstVisualizza = new System.Windows.Forms.ListBox();
            this.btnVisualizza = new System.Windows.Forms.Button();
            this.grbDettagliArticolo = new System.Windows.Forms.GroupBox();
            this.grbDettagliArticolo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCodice
            // 
            this.lblCodice.AutoSize = true;
            this.lblCodice.Location = new System.Drawing.Point(67, 56);
            this.lblCodice.Name = "lblCodice";
            this.lblCodice.Size = new System.Drawing.Size(44, 15);
            this.lblCodice.TabIndex = 0;
            this.lblCodice.Text = "Codice";
            // 
            // lblDescrizione
            // 
            this.lblDescrizione.AutoSize = true;
            this.lblDescrizione.Location = new System.Drawing.Point(67, 117);
            this.lblDescrizione.Name = "lblDescrizione";
            this.lblDescrizione.Size = new System.Drawing.Size(67, 15);
            this.lblDescrizione.TabIndex = 1;
            this.lblDescrizione.Text = "Descrizione";
            // 
            // lblUnitaDiMisura
            // 
            this.lblUnitaDiMisura.AutoSize = true;
            this.lblUnitaDiMisura.Location = new System.Drawing.Point(58, 176);
            this.lblUnitaDiMisura.Name = "lblUnitaDiMisura";
            this.lblUnitaDiMisura.Size = new System.Drawing.Size(88, 15);
            this.lblUnitaDiMisura.TabIndex = 2;
            this.lblUnitaDiMisura.Text = "Unità Di Misura";
            // 
            // lblPrezzo
            // 
            this.lblPrezzo.AutoSize = true;
            this.lblPrezzo.Location = new System.Drawing.Point(58, 248);
            this.lblPrezzo.Name = "lblPrezzo";
            this.lblPrezzo.Size = new System.Drawing.Size(41, 15);
            this.lblPrezzo.TabIndex = 3;
            this.lblPrezzo.Text = "Prezzo";
            // 
            // txtCodice
            // 
            this.txtCodice.Location = new System.Drawing.Point(145, 48);
            this.txtCodice.Name = "txtCodice";
            this.txtCodice.Size = new System.Drawing.Size(100, 23);
            this.txtCodice.TabIndex = 4;
            // 
            // txtDescrizione
            // 
            this.txtDescrizione.Location = new System.Drawing.Point(145, 109);
            this.txtDescrizione.Name = "txtDescrizione";
            this.txtDescrizione.Size = new System.Drawing.Size(100, 23);
            this.txtDescrizione.TabIndex = 5;
            // 
            // txtPrezzo
            // 
            this.txtPrezzo.Location = new System.Drawing.Point(145, 240);
            this.txtPrezzo.Name = "txtPrezzo";
            this.txtPrezzo.Size = new System.Drawing.Size(100, 23);
            this.txtPrezzo.TabIndex = 6;
            // 
            // cmbUnitaDiMisura
            // 
            this.cmbUnitaDiMisura.FormattingEnabled = true;
            this.cmbUnitaDiMisura.Items.AddRange(new object[] {
            "NR",
            "KG",
            "Q",
            "T"});
            this.cmbUnitaDiMisura.Location = new System.Drawing.Point(170, 168);
            this.cmbUnitaDiMisura.Name = "cmbUnitaDiMisura";
            this.cmbUnitaDiMisura.Size = new System.Drawing.Size(121, 23);
            this.cmbUnitaDiMisura.TabIndex = 7;
            // 
            // btnAggiungiModifica
            // 
            this.btnAggiungiModifica.Location = new System.Drawing.Point(118, 310);
            this.btnAggiungiModifica.Name = "btnAggiungiModifica";
            this.btnAggiungiModifica.Size = new System.Drawing.Size(147, 58);
            this.btnAggiungiModifica.TabIndex = 8;
            this.btnAggiungiModifica.Text = "Aggiungi/modifica articolo";
            this.btnAggiungiModifica.UseVisualStyleBackColor = true;
            this.btnAggiungiModifica.Click += new System.EventHandler(this.btnAggiungiModifica_Click);
            // 
            // lblArticolo
            // 
            this.lblArticolo.AutoSize = true;
            this.lblArticolo.Location = new System.Drawing.Point(68, 405);
            this.lblArticolo.Name = "lblArticolo";
            this.lblArticolo.Size = new System.Drawing.Size(63, 15);
            this.lblArticolo.TabIndex = 9;
            this.lblArticolo.Text = "Articolo(0)";
            // 
            // cmbVisualizza
            // 
            this.cmbVisualizza.FormattingEnabled = true;
            this.cmbVisualizza.Items.AddRange(new object[] {
            "Visualizza Articoli"});
            this.cmbVisualizza.Location = new System.Drawing.Point(551, 93);
            this.cmbVisualizza.Name = "cmbVisualizza";
            this.cmbVisualizza.Size = new System.Drawing.Size(121, 23);
            this.cmbVisualizza.TabIndex = 10;
            // 
            // lstVisualizza
            // 
            this.lstVisualizza.FormattingEnabled = true;
            this.lstVisualizza.ItemHeight = 15;
            this.lstVisualizza.Location = new System.Drawing.Point(551, 154);
            this.lstVisualizza.Name = "lstVisualizza";
            this.lstVisualizza.Size = new System.Drawing.Size(201, 229);
            this.lstVisualizza.TabIndex = 12;
            // 
            // btnVisualizza
            // 
            this.btnVisualizza.Location = new System.Drawing.Point(691, 93);
            this.btnVisualizza.Name = "btnVisualizza";
            this.btnVisualizza.Size = new System.Drawing.Size(75, 23);
            this.btnVisualizza.TabIndex = 13;
            this.btnVisualizza.Text = "...";
            this.btnVisualizza.UseVisualStyleBackColor = true;
            this.btnVisualizza.Click += new System.EventHandler(this.btnVisualizza_Click);
            // 
            // grbDettagliArticolo
            // 
            this.grbDettagliArticolo.Controls.Add(this.btnAggiungiModifica);
            this.grbDettagliArticolo.Controls.Add(this.cmbUnitaDiMisura);
            this.grbDettagliArticolo.Controls.Add(this.txtPrezzo);
            this.grbDettagliArticolo.Controls.Add(this.txtDescrizione);
            this.grbDettagliArticolo.Controls.Add(this.txtCodice);
            this.grbDettagliArticolo.Controls.Add(this.lblPrezzo);
            this.grbDettagliArticolo.Controls.Add(this.lblUnitaDiMisura);
            this.grbDettagliArticolo.Controls.Add(this.lblDescrizione);
            this.grbDettagliArticolo.Controls.Add(this.lblCodice);
            this.grbDettagliArticolo.Location = new System.Drawing.Point(10, 15);
            this.grbDettagliArticolo.Name = "grbDettagliArticolo";
            this.grbDettagliArticolo.Size = new System.Drawing.Size(419, 387);
            this.grbDettagliArticolo.TabIndex = 14;
            this.grbDettagliArticolo.TabStop = false;
            this.grbDettagliArticolo.Text = "Dettagli Articoli";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grbDettagliArticolo);
            this.Controls.Add(this.btnVisualizza);
            this.Controls.Add(this.lstVisualizza);
            this.Controls.Add(this.cmbVisualizza);
            this.Controls.Add(this.lblArticolo);
            this.Name = "frmMain";
            this.Text = " Prova singola 4E Ubalducci Mattia lab 2.2 18/05/2022 su form e dizionari, classi" +
    " e utilizzo di GIT";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.grbDettagliArticolo.ResumeLayout(false);
            this.grbDettagliArticolo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblCodice;
        private Label lblDescrizione;
        private Label lblUnitaDiMisura;
        private Label lblPrezzo;
        private TextBox txtCodice;
        private TextBox txtDescrizione;
        private TextBox txtPrezzo;
        private ComboBox cmbUnitaDiMisura;
        private Button btnAggiungiModifica;
        private Label lblArticolo;
        private ComboBox cmbVisualizza;
        private ListBox lstVisualizza;
        private Button btnVisualizza;
        private GroupBox grbDettagliArticolo;
    }
}