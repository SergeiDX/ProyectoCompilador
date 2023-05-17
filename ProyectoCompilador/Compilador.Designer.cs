namespace ProyectoCompilador
{
    partial class Compilador
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.ListEntrada = new System.Windows.Forms.ListBox();
            this.ListSalida = new System.Windows.Forms.ListBox();
            this.ListPreservada = new System.Windows.Forms.ListBox();
            this.btnCargarArchivo = new System.Windows.Forms.Button();
            this.btnCompilar = new System.Windows.Forms.Button();
            this.cmbxLenguajes = new System.Windows.Forms.ComboBox();
            this.btnTXT = new System.Windows.Forms.Button();
            this.btnCSV = new System.Windows.Forms.Button();
            this.btnXLSX = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnReporte = new System.Windows.Forms.Button();
            this.btnclean = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // ListEntrada
            // 
            this.ListEntrada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.ListEntrada.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListEntrada.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListEntrada.FormattingEnabled = true;
            this.ListEntrada.ItemHeight = 17;
            this.ListEntrada.Location = new System.Drawing.Point(15, 42);
            this.ListEntrada.Name = "ListEntrada";
            this.ListEntrada.Size = new System.Drawing.Size(193, 340);
            this.ListEntrada.TabIndex = 0;
            // 
            // ListSalida
            // 
            this.ListSalida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.ListSalida.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListSalida.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListSalida.FormattingEnabled = true;
            this.ListSalida.ItemHeight = 17;
            this.ListSalida.Location = new System.Drawing.Point(228, 42);
            this.ListSalida.Name = "ListSalida";
            this.ListSalida.Size = new System.Drawing.Size(367, 340);
            this.ListSalida.TabIndex = 1;
            // 
            // ListPreservada
            // 
            this.ListPreservada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.ListPreservada.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListPreservada.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListPreservada.FormattingEnabled = true;
            this.ListPreservada.ItemHeight = 17;
            this.ListPreservada.Location = new System.Drawing.Point(614, 42);
            this.ListPreservada.Name = "ListPreservada";
            this.ListPreservada.Size = new System.Drawing.Size(172, 340);
            this.ListPreservada.TabIndex = 2;
            // 
            // btnCargarArchivo
            // 
            this.btnCargarArchivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btnCargarArchivo.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarArchivo.ForeColor = System.Drawing.Color.White;
            this.btnCargarArchivo.Location = new System.Drawing.Point(15, 442);
            this.btnCargarArchivo.Name = "btnCargarArchivo";
            this.btnCargarArchivo.Size = new System.Drawing.Size(260, 50);
            this.btnCargarArchivo.TabIndex = 7;
            this.btnCargarArchivo.Text = "Cargar Archivo";
            this.btnCargarArchivo.UseVisualStyleBackColor = false;
            this.btnCargarArchivo.Click += new System.EventHandler(this.btnCargarArchivo_Click_1);
            // 
            // btnCompilar
            // 
            this.btnCompilar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btnCompilar.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompilar.ForeColor = System.Drawing.Color.White;
            this.btnCompilar.Location = new System.Drawing.Point(15, 386);
            this.btnCompilar.Name = "btnCompilar";
            this.btnCompilar.Size = new System.Drawing.Size(260, 50);
            this.btnCompilar.TabIndex = 8;
            this.btnCompilar.Text = "Compilar";
            this.btnCompilar.UseVisualStyleBackColor = false;
            this.btnCompilar.Click += new System.EventHandler(this.btnCompilar_Click_1);
            // 
            // cmbxLenguajes
            // 
            this.cmbxLenguajes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.cmbxLenguajes.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbxLenguajes.FormattingEnabled = true;
            this.cmbxLenguajes.Location = new System.Drawing.Point(299, 422);
            this.cmbxLenguajes.Name = "cmbxLenguajes";
            this.cmbxLenguajes.Size = new System.Drawing.Size(148, 25);
            this.cmbxLenguajes.TabIndex = 9;
            this.cmbxLenguajes.SelectedIndexChanged += new System.EventHandler(this.cmbxLenguajes_SelectedIndexChanged);
            this.cmbxLenguajes.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cmbxLenguajes_MouseClick);
            // 
            // btnTXT
            // 
            this.btnTXT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btnTXT.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTXT.ForeColor = System.Drawing.Color.White;
            this.btnTXT.Location = new System.Drawing.Point(462, 499);
            this.btnTXT.Name = "btnTXT";
            this.btnTXT.Size = new System.Drawing.Size(324, 42);
            this.btnTXT.TabIndex = 10;
            this.btnTXT.Text = "TXT";
            this.btnTXT.UseVisualStyleBackColor = false;
            this.btnTXT.Click += new System.EventHandler(this.btnTXT_Click_1);
            // 
            // btnCSV
            // 
            this.btnCSV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btnCSV.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCSV.ForeColor = System.Drawing.Color.White;
            this.btnCSV.Location = new System.Drawing.Point(462, 386);
            this.btnCSV.Name = "btnCSV";
            this.btnCSV.Size = new System.Drawing.Size(324, 42);
            this.btnCSV.TabIndex = 11;
            this.btnCSV.Text = "CSV";
            this.btnCSV.UseVisualStyleBackColor = false;
            this.btnCSV.Click += new System.EventHandler(this.btncCSV);
            // 
            // btnXLSX
            // 
            this.btnXLSX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btnXLSX.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXLSX.ForeColor = System.Drawing.Color.White;
            this.btnXLSX.Location = new System.Drawing.Point(462, 442);
            this.btnXLSX.Name = "btnXLSX";
            this.btnXLSX.Size = new System.Drawing.Size(324, 42);
            this.btnXLSX.TabIndex = 12;
            this.btnXLSX.Text = "XLSX";
            this.btnXLSX.UseVisualStyleBackColor = false;
            this.btnXLSX.Click += new System.EventHandler(this.btnXLSX_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(326, 455);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 30);
            this.label1.TabIndex = 13;
            this.label1.Text = "Exportar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(322, 389);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 30);
            this.label2.TabIndex = 14;
            this.label2.Text = "Lenguaje";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.label3.Location = new System.Drawing.Point(28, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 30);
            this.label3.TabIndex = 15;
            this.label3.Text = "Archivo Entrada";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.label4.Location = new System.Drawing.Point(322, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 30);
            this.label4.TabIndex = 16;
            this.label4.Text = "Archivo Salida";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.label5.Location = new System.Drawing.Point(605, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(189, 25);
            this.label5.TabIndex = 17;
            this.label5.Text = "Palabras Reservadas\r\n";
            // 
            // btnReporte
            // 
            this.btnReporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btnReporte.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporte.ForeColor = System.Drawing.Color.White;
            this.btnReporte.Location = new System.Drawing.Point(15, 495);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(260, 50);
            this.btnReporte.TabIndex = 18;
            this.btnReporte.Text = "Reporte";
            this.btnReporte.UseVisualStyleBackColor = false;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // btnclean
            // 
            this.btnclean.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btnclean.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclean.ForeColor = System.Drawing.Color.White;
            this.btnclean.Location = new System.Drawing.Point(299, 495);
            this.btnclean.Name = "btnclean";
            this.btnclean.Size = new System.Drawing.Size(148, 50);
            this.btnclean.TabIndex = 19;
            this.btnclean.Text = "Limpiar";
            this.btnclean.UseVisualStyleBackColor = false;
            this.btnclean.Click += new System.EventHandler(this.btnclean_Click);
            // 
            // Compilador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 551);
            this.Controls.Add(this.btnclean);
            this.Controls.Add(this.btnReporte);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnXLSX);
            this.Controls.Add(this.btnCSV);
            this.Controls.Add(this.btnTXT);
            this.Controls.Add(this.cmbxLenguajes);
            this.Controls.Add(this.btnCompilar);
            this.Controls.Add(this.btnCargarArchivo);
            this.Controls.Add(this.ListPreservada);
            this.Controls.Add(this.ListSalida);
            this.Controls.Add(this.ListEntrada);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Compilador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Compilador";
            this.Load += new System.EventHandler(this.Compilador_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ListBox ListEntrada;
        private System.Windows.Forms.ListBox ListSalida;
        private System.Windows.Forms.ListBox ListPreservada;
        private System.Windows.Forms.Button btnCargarArchivo;
        private System.Windows.Forms.Button btnCompilar;
        private System.Windows.Forms.ComboBox cmbxLenguajes;
        private System.Windows.Forms.Button btnTXT;
        private System.Windows.Forms.Button btnCSV;
        private System.Windows.Forms.Button btnXLSX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.Button btnclean;
    }
}

