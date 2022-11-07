namespace pryHerreraSP4
{
    partial class frmTriatlon
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTriatlon));
            this.label1 = new System.Windows.Forms.Label();
            this.dgvParticipantes = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAsignarParticipantes = new System.Windows.Forms.Button();
            this.btnDeterminarGanadores = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvPosiciones = new System.Windows.Forms.DataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvGanadores = new System.Windows.Forms.DataGridView();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.picGanadores = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParticipantes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPosiciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGanadores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGanadores)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Participantes";
            // 
            // dgvParticipantes
            // 
            this.dgvParticipantes.AllowUserToAddRows = false;
            this.dgvParticipantes.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvParticipantes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvParticipantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParticipantes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvParticipantes.Location = new System.Drawing.Point(12, 25);
            this.dgvParticipantes.Name = "dgvParticipantes";
            this.dgvParticipantes.RowHeadersVisible = false;
            this.dgvParticipantes.Size = new System.Drawing.Size(557, 150);
            this.dgvParticipantes.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Número";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre";
            this.Column2.Name = "Column2";
            this.Column2.Width = 250;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "País";
            this.Column3.Name = "Column3";
            this.Column3.Width = 200;
            // 
            // btnAsignarParticipantes
            // 
            this.btnAsignarParticipantes.Location = new System.Drawing.Point(605, 25);
            this.btnAsignarParticipantes.Name = "btnAsignarParticipantes";
            this.btnAsignarParticipantes.Size = new System.Drawing.Size(104, 40);
            this.btnAsignarParticipantes.TabIndex = 2;
            this.btnAsignarParticipantes.Text = "&Asignar Participantes";
            this.btnAsignarParticipantes.UseVisualStyleBackColor = true;
            this.btnAsignarParticipantes.Click += new System.EventHandler(this.btnAsignarParticipantes_Click);
            // 
            // btnDeterminarGanadores
            // 
            this.btnDeterminarGanadores.Location = new System.Drawing.Point(605, 80);
            this.btnDeterminarGanadores.Name = "btnDeterminarGanadores";
            this.btnDeterminarGanadores.Size = new System.Drawing.Size(104, 40);
            this.btnDeterminarGanadores.TabIndex = 3;
            this.btnDeterminarGanadores.Text = "&Determinar Ganadores";
            this.btnDeterminarGanadores.UseVisualStyleBackColor = true;
            this.btnDeterminarGanadores.Click += new System.EventHandler(this.btnDeterminarGanadores_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(605, 135);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(104, 40);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Posiciones";
            // 
            // dgvPosiciones
            // 
            this.dgvPosiciones.AllowUserToAddRows = false;
            this.dgvPosiciones.AllowUserToDeleteRows = false;
            this.dgvPosiciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPosiciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10});
            this.dgvPosiciones.Location = new System.Drawing.Point(12, 216);
            this.dgvPosiciones.Name = "dgvPosiciones";
            this.dgvPosiciones.RowHeadersVisible = false;
            this.dgvPosiciones.Size = new System.Drawing.Size(706, 103);
            this.dgvPosiciones.TabIndex = 6;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Prueba";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Participante 1";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Participante 2";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Participante 3";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Participante 4";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Participante 5";
            this.Column9.Name = "Column9";
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Participante 6";
            this.Column10.Name = "Column10";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 370);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ganadores";
            // 
            // dgvGanadores
            // 
            this.dgvGanadores.AllowUserToAddRows = false;
            this.dgvGanadores.AllowUserToDeleteRows = false;
            this.dgvGanadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGanadores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column11,
            this.Column12,
            this.Column13,
            this.Column14});
            this.dgvGanadores.Location = new System.Drawing.Point(12, 386);
            this.dgvGanadores.Name = "dgvGanadores";
            this.dgvGanadores.ReadOnly = true;
            this.dgvGanadores.RowHeadersVisible = false;
            this.dgvGanadores.Size = new System.Drawing.Size(507, 107);
            this.dgvGanadores.TabIndex = 8;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Puesto";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            // 
            // Column12
            // 
            this.Column12.HeaderText = "Nombre";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            this.Column12.Width = 200;
            // 
            // Column13
            // 
            this.Column13.HeaderText = "País";
            this.Column13.Name = "Column13";
            this.Column13.ReadOnly = true;
            // 
            // Column14
            // 
            this.Column14.HeaderText = "Puntos";
            this.Column14.Name = "Column14";
            this.Column14.ReadOnly = true;
            // 
            // picGanadores
            // 
            this.picGanadores.Image = global::pryHerreraSP4.Properties.Resources.podio;
            this.picGanadores.Location = new System.Drawing.Point(547, 343);
            this.picGanadores.Name = "picGanadores";
            this.picGanadores.Size = new System.Drawing.Size(171, 150);
            this.picGanadores.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGanadores.TabIndex = 9;
            this.picGanadores.TabStop = false;
            // 
            // frmTriatlon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 509);
            this.Controls.Add(this.picGanadores);
            this.Controls.Add(this.dgvGanadores);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvPosiciones);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnDeterminarGanadores);
            this.Controls.Add(this.btnAsignarParticipantes);
            this.Controls.Add(this.dgvParticipantes);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmTriatlon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Triatlón";
            this.Load += new System.EventHandler(this.frmTriatlon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvParticipantes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPosiciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGanadores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGanadores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAsignarParticipantes;
        private System.Windows.Forms.Button btnDeterminarGanadores;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvPosiciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvGanadores;
        private System.Windows.Forms.PictureBox picGanadores;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.DataGridView dgvParticipantes;
    }
}

