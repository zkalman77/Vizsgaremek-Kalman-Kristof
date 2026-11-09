namespace orszagok
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TextBox txtOrszag;
        private System.Windows.Forms.TextBox txtFovaros;
        private System.Windows.Forms.TextBox txtLakossag;
        private System.Windows.Forms.TextBox txtKereses;
        private System.Windows.Forms.Button btnHozzaadas;
        private System.Windows.Forms.Button btnBeolvasas;
        private System.Windows.Forms.Button btnKereses;
        private System.Windows.Forms.Button btnRendezes;
        private System.Windows.Forms.DataGridView dgvOrszagok;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtOrszag = new System.Windows.Forms.TextBox();
            this.txtFovaros = new System.Windows.Forms.TextBox();
            this.txtLakossag = new System.Windows.Forms.TextBox();
            this.txtKereses = new System.Windows.Forms.TextBox();
            this.btnHozzaadas = new System.Windows.Forms.Button();
            this.btnBeolvasas = new System.Windows.Forms.Button();
            this.btnKereses = new System.Windows.Forms.Button();
            this.btnRendezes = new System.Windows.Forms.Button();
            this.dgvOrszagok = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrszagok)).BeginInit();
            this.SuspendLayout();
            // 
            // txtOrszag
            // 
            this.txtOrszag.Location = new System.Drawing.Point(30, 40);
            this.txtOrszag.Name = "txtOrszag";
            this.txtOrszag.Size = new System.Drawing.Size(180, 23);
            this.txtOrszag.TabIndex = 0;
            // 
            // txtFovaros
            // 
            this.txtFovaros.Location = new System.Drawing.Point(230, 40);
            this.txtFovaros.Name = "txtFovaros";
            this.txtFovaros.Size = new System.Drawing.Size(180, 23);
            this.txtFovaros.TabIndex = 1;
            // 
            // txtLakossag
            // 
            this.txtLakossag.Location = new System.Drawing.Point(430, 40);
            this.txtLakossag.Name = "txtLakossag";
            this.txtLakossag.Size = new System.Drawing.Size(150, 23);
            this.txtLakossag.TabIndex = 2;
            // 
            // txtKereses
            // 
            this.txtKereses.Location = new System.Drawing.Point(600, 40);
            this.txtKereses.Name = "txtKereses";
            this.txtKereses.Size = new System.Drawing.Size(240, 23);
            this.txtKereses.TabIndex = 3;
            // 
            // btnHozzaadas
            // 
            this.btnHozzaadas.Location = new System.Drawing.Point(30, 80);
            this.btnHozzaadas.Name = "btnHozzaadas";
            this.btnHozzaadas.Size = new System.Drawing.Size(180, 35);
            this.btnHozzaadas.TabIndex = 4;
            this.btnHozzaadas.Text = "Hozzáadás";
            this.btnHozzaadas.UseVisualStyleBackColor = true;
            this.btnHozzaadas.Click += new System.EventHandler(this.btnHozzaadas_Click);
            // 
            // btnBeolvasas
            // 
            this.btnBeolvasas.Location = new System.Drawing.Point(230, 80);
            this.btnBeolvasas.Name = "btnBeolvasas";
            this.btnBeolvasas.Size = new System.Drawing.Size(180, 35);
            this.btnBeolvasas.TabIndex = 5;
            this.btnBeolvasas.Text = "Beolvasás";
            this.btnBeolvasas.UseVisualStyleBackColor = true;
            this.btnBeolvasas.Click += new System.EventHandler(this.btnBeolvasas_Click);
            // 
            // btnKereses
            // 
            this.btnKereses.Location = new System.Drawing.Point(430, 80);
            this.btnKereses.Name = "btnKereses";
            this.btnKereses.Size = new System.Drawing.Size(150, 35);
            this.btnKereses.TabIndex = 6;
            this.btnKereses.Text = "Keresés";
            this.btnKereses.UseVisualStyleBackColor = true;
            this.btnKereses.Click += new System.EventHandler(this.btnKereses_Click);
            // 
            // btnRendezes
            // 
            this.btnRendezes.Location = new System.Drawing.Point(600, 80);
            this.btnRendezes.Name = "btnRendezes";
            this.btnRendezes.Size = new System.Drawing.Size(240, 35);
            this.btnRendezes.TabIndex = 7;
            this.btnRendezes.Text = "Rendezés (Lakosság)";
            this.btnRendezes.UseVisualStyleBackColor = true;
            this.btnRendezes.Click += new System.EventHandler(this.btnRendezes_Click);
            // 
            // dgvOrszagok
            // 
            this.dgvOrszagok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrszagok.Location = new System.Drawing.Point(30, 135);
            this.dgvOrszagok.Name = "dgvOrszagok";
            this.dgvOrszagok.Size = new System.Drawing.Size(810, 400);
            this.dgvOrszagok.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.dgvOrszagok);
            this.Controls.Add(this.btnRendezes);
            this.Controls.Add(this.btnKereses);
            this.Controls.Add(this.btnBeolvasas);
            this.Controls.Add(this.btnHozzaadas);
            this.Controls.Add(this.txtKereses);
            this.Controls.Add(this.txtLakossag);
            this.Controls.Add(this.txtFovaros);
            this.Controls.Add(this.txtOrszag);
            this.Name = "Form1";
            this.Text = "Országok nyilvántartása";
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrszagok)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}