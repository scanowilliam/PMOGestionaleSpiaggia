namespace PMOgestionale
{
    partial class FormGestionale
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnSalva = new System.Windows.Forms.Button();
            this.dtDataGridView = new System.Windows.Forms.DataGridView();
            this.gbOperazioni = new System.Windows.Forms.GroupBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.btnElimina = new System.Windows.Forms.Button();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtRicercaID = new System.Windows.Forms.TextBox();
            this.lblRicercaID = new System.Windows.Forms.Label();
            this.txtCognome = new System.Windows.Forms.TextBox();
            this.lblCognome = new System.Windows.Forms.Label();
            this.lblDataFine = new System.Windows.Forms.Label();
            this.cmbOfferta = new System.Windows.Forms.ComboBox();
            this.lblOfferte = new System.Windows.Forms.Label();
            this.lblDataInizio = new System.Windows.Forms.Label();
            this.dtpFine = new PMOgestionale.CustomDTP();
            this.dtpInizio = new PMOgestionale.CustomDTP();
            ((System.ComponentModel.ISupportInitialize)(this.dtDataGridView)).BeginInit();
            this.gbOperazioni.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblNome.Location = new System.Drawing.Point(647, 43);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(49, 17);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.SystemColors.MenuText;
            this.txtNome.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtNome.Location = new System.Drawing.Point(741, 39);
            this.txtNome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(471, 22);
            this.txtNome.TabIndex = 1;
            this.txtNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNome_KeyPress);
            // 
            // btnSalva
            // 
            this.btnSalva.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSalva.FlatAppearance.BorderSize = 0;
            this.btnSalva.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Sienna;
            this.btnSalva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalva.Font = new System.Drawing.Font("Garamond", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalva.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSalva.Location = new System.Drawing.Point(785, 158);
            this.btnSalva.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSalva.Name = "btnSalva";
            this.btnSalva.Size = new System.Drawing.Size(185, 33);
            this.btnSalva.TabIndex = 2;
            this.btnSalva.Text = "SALVA";
            this.btnSalva.UseVisualStyleBackColor = false;
            this.btnSalva.Click += new System.EventHandler(this.btnSalva_Click);
            // 
            // dtDataGridView
            // 
            this.dtDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dtDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtDataGridView.Location = new System.Drawing.Point(57, 412);
            this.dtDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtDataGridView.Name = "dtDataGridView";
            this.dtDataGridView.RowHeadersWidth = 51;
            this.dtDataGridView.RowTemplate.Height = 24;
            this.dtDataGridView.Size = new System.Drawing.Size(1232, 226);
            this.dtDataGridView.TabIndex = 3;
            this.dtDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtDataGridView_CellContentClick);
            this.dtDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtDataGridView_CellDoubleClick);
            // 
            // gbOperazioni
            // 
            this.gbOperazioni.Controls.Add(this.dtpFine);
            this.gbOperazioni.Controls.Add(this.dtpInizio);
            this.gbOperazioni.Controls.Add(this.lblTelefono);
            this.gbOperazioni.Controls.Add(this.btnElimina);
            this.gbOperazioni.Controls.Add(this.txtTelefono);
            this.gbOperazioni.Controls.Add(this.txtRicercaID);
            this.gbOperazioni.Controls.Add(this.lblRicercaID);
            this.gbOperazioni.Controls.Add(this.lblNome);
            this.gbOperazioni.Controls.Add(this.txtNome);
            this.gbOperazioni.Controls.Add(this.txtCognome);
            this.gbOperazioni.Controls.Add(this.lblCognome);
            this.gbOperazioni.Controls.Add(this.lblDataFine);
            this.gbOperazioni.Controls.Add(this.cmbOfferta);
            this.gbOperazioni.Controls.Add(this.btnSalva);
            this.gbOperazioni.Controls.Add(this.lblOfferte);
            this.gbOperazioni.Controls.Add(this.lblDataInizio);
            this.gbOperazioni.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.gbOperazioni.Location = new System.Drawing.Point(57, 203);
            this.gbOperazioni.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbOperazioni.Name = "gbOperazioni";
            this.gbOperazioni.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbOperazioni.Size = new System.Drawing.Size(1232, 203);
            this.gbOperazioni.TabIndex = 4;
            this.gbOperazioni.TabStop = false;
            this.gbOperazioni.Text = "Operazioni";
            this.gbOperazioni.Enter += new System.EventHandler(this.gbOperazioni_Enter);
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTelefono.Location = new System.Drawing.Point(647, 130);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(68, 17);
            this.lblTelefono.TabIndex = 22;
            this.lblTelefono.Text = "Telefono:";
            // 
            // btnElimina
            // 
            this.btnElimina.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnElimina.FlatAppearance.BorderSize = 0;
            this.btnElimina.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Sienna;
            this.btnElimina.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnElimina.Font = new System.Drawing.Font("Garamond", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnElimina.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnElimina.Location = new System.Drawing.Point(977, 158);
            this.btnElimina.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnElimina.Name = "btnElimina";
            this.btnElimina.Size = new System.Drawing.Size(185, 33);
            this.btnElimina.TabIndex = 4;
            this.btnElimina.Text = "ELIMINA";
            this.btnElimina.UseVisualStyleBackColor = false;
            this.btnElimina.Click += new System.EventHandler(this.btnElimina_Click);
            // 
            // txtTelefono
            // 
            this.txtTelefono.BackColor = System.Drawing.SystemColors.MenuText;
            this.txtTelefono.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtTelefono.Location = new System.Drawing.Point(741, 126);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(471, 22);
            this.txtTelefono.TabIndex = 21;
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            // 
            // txtRicercaID
            // 
            this.txtRicercaID.BackColor = System.Drawing.SystemColors.MenuText;
            this.txtRicercaID.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtRicercaID.Location = new System.Drawing.Point(217, 39);
            this.txtRicercaID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRicercaID.Name = "txtRicercaID";
            this.txtRicercaID.Size = new System.Drawing.Size(408, 22);
            this.txtRicercaID.TabIndex = 7;
            this.txtRicercaID.TextChanged += new System.EventHandler(this.txtRicercaID_TextChanged);
            this.txtRicercaID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRicercaID_KeyPress);
            // 
            // lblRicercaID
            // 
            this.lblRicercaID.AutoSize = true;
            this.lblRicercaID.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblRicercaID.Location = new System.Drawing.Point(107, 43);
            this.lblRicercaID.Name = "lblRicercaID";
            this.lblRicercaID.Size = new System.Drawing.Size(77, 17);
            this.lblRicercaID.TabIndex = 6;
            this.lblRicercaID.Text = "Ricerca ID:";
            // 
            // txtCognome
            // 
            this.txtCognome.BackColor = System.Drawing.SystemColors.MenuText;
            this.txtCognome.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtCognome.Location = new System.Drawing.Point(741, 82);
            this.txtCognome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCognome.Name = "txtCognome";
            this.txtCognome.Size = new System.Drawing.Size(471, 22);
            this.txtCognome.TabIndex = 10;
            this.txtCognome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCognome_KeyPress);
            // 
            // lblCognome
            // 
            this.lblCognome.AutoSize = true;
            this.lblCognome.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblCognome.Location = new System.Drawing.Point(647, 85);
            this.lblCognome.Name = "lblCognome";
            this.lblCognome.Size = new System.Drawing.Size(72, 17);
            this.lblCognome.TabIndex = 9;
            this.lblCognome.Text = "Cognome:";
            // 
            // lblDataFine
            // 
            this.lblDataFine.AutoSize = true;
            this.lblDataFine.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblDataFine.Location = new System.Drawing.Point(107, 174);
            this.lblDataFine.Name = "lblDataFine";
            this.lblDataFine.Size = new System.Drawing.Size(73, 17);
            this.lblDataFine.TabIndex = 12;
            this.lblDataFine.Text = "Data Fine:";
            // 
            // cmbOfferta
            // 
            this.cmbOfferta.BackColor = System.Drawing.SystemColors.MenuText;
            this.cmbOfferta.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cmbOfferta.FormattingEnabled = true;
            this.cmbOfferta.Items.AddRange(new object[] {
            "lettino",
            "ombrellone",
            "ombrellone+lettino extra"});
            this.cmbOfferta.Location = new System.Drawing.Point(217, 82);
            this.cmbOfferta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbOfferta.Name = "cmbOfferta";
            this.cmbOfferta.Size = new System.Drawing.Size(408, 24);
            this.cmbOfferta.TabIndex = 17;
            // 
            // lblOfferte
            // 
            this.lblOfferte.AutoSize = true;
            this.lblOfferte.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblOfferte.Location = new System.Drawing.Point(107, 89);
            this.lblOfferte.Name = "lblOfferte";
            this.lblOfferte.Size = new System.Drawing.Size(56, 17);
            this.lblOfferte.TabIndex = 18;
            this.lblOfferte.Text = "Offerte:";
            // 
            // lblDataInizio
            // 
            this.lblDataInizio.AutoSize = true;
            this.lblDataInizio.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblDataInizio.Location = new System.Drawing.Point(107, 128);
            this.lblDataInizio.Name = "lblDataInizio";
            this.lblDataInizio.Size = new System.Drawing.Size(78, 17);
            this.lblDataInizio.TabIndex = 11;
            this.lblDataInizio.Text = "Data Inizio:";
            // 
            // dtpFine
            // 
            this.dtpFine.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.dtpFine.BorderSize = 1;
            this.dtpFine.CustomFormat = "dd/MM/yyyy";
            this.dtpFine.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFine.Location = new System.Drawing.Point(217, 168);
            this.dtpFine.Name = "dtpFine";
            this.dtpFine.Size = new System.Drawing.Size(408, 22);
            this.dtpFine.SkinColor = System.Drawing.Color.Black;
            this.dtpFine.TabIndex = 24;
            this.dtpFine.TextColor = System.Drawing.Color.WhiteSmoke;
            // 
            // dtpInizio
            // 
            this.dtpInizio.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.dtpInizio.BorderSize = 1;
            this.dtpInizio.CustomFormat = "dd/MM/yyyy";
            this.dtpInizio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpInizio.Location = new System.Drawing.Point(217, 125);
            this.dtpInizio.Name = "dtpInizio";
            this.dtpInizio.Size = new System.Drawing.Size(408, 22);
            this.dtpInizio.SkinColor = System.Drawing.Color.Black;
            this.dtpInizio.TabIndex = 23;
            this.dtpInizio.TextColor = System.Drawing.Color.WhiteSmoke;
            // 
            // FormGestionale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuText;
            this.ClientSize = new System.Drawing.Size(1341, 650);
            this.Controls.Add(this.gbOperazioni);
            this.Controls.Add(this.dtDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "FormGestionale";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dtDataGridView)).EndInit();
            this.gbOperazioni.ResumeLayout(false);
            this.gbOperazioni.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnSalva;
        private System.Windows.Forms.DataGridView dtDataGridView;
        private System.Windows.Forms.GroupBox gbOperazioni;
        private System.Windows.Forms.Button btnElimina;
        private System.Windows.Forms.Label lblRicercaID;
        private System.Windows.Forms.TextBox txtRicercaID;
        private System.Windows.Forms.Label lblCognome;
        private System.Windows.Forms.TextBox txtCognome;
        private System.Windows.Forms.Label lblDataInizio;
        private System.Windows.Forms.Label lblDataFine;
        private System.Windows.Forms.ComboBox cmbOfferta;
        private System.Windows.Forms.Label lblOfferte;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblTelefono;     
        private CustomDTP dtpFine;
        private CustomDTP dtpInizio;
    }
}

