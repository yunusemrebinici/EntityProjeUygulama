namespace EntityProjeUygulama
{
    partial class FrmAnaForm
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
            this.BtnKategori = new System.Windows.Forms.Button();
            this.BtnUrun = new System.Windows.Forms.Button();
            this.BtnIstatıstık = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnKategori
            // 
            this.BtnKategori.Location = new System.Drawing.Point(23, 27);
            this.BtnKategori.Name = "BtnKategori";
            this.BtnKategori.Size = new System.Drawing.Size(151, 98);
            this.BtnKategori.TabIndex = 0;
            this.BtnKategori.Text = "KATEGORİ İŞLEMLERİ";
            this.BtnKategori.UseVisualStyleBackColor = true;
            this.BtnKategori.Click += new System.EventHandler(this.BtnKategori_Click);
            // 
            // BtnUrun
            // 
            this.BtnUrun.Location = new System.Drawing.Point(196, 27);
            this.BtnUrun.Name = "BtnUrun";
            this.BtnUrun.Size = new System.Drawing.Size(151, 98);
            this.BtnUrun.TabIndex = 1;
            this.BtnUrun.Text = "ÜRÜN İŞLEMLERİ";
            this.BtnUrun.UseVisualStyleBackColor = true;
            this.BtnUrun.Click += new System.EventHandler(this.BtnUrun_Click);
            // 
            // BtnIstatıstık
            // 
            this.BtnIstatıstık.Location = new System.Drawing.Point(384, 27);
            this.BtnIstatıstık.Name = "BtnIstatıstık";
            this.BtnIstatıstık.Size = new System.Drawing.Size(176, 98);
            this.BtnIstatıstık.TabIndex = 2;
            this.BtnIstatıstık.Text = "İSTATİSTİKLER";
            this.BtnIstatıstık.UseVisualStyleBackColor = true;
            this.BtnIstatıstık.Click += new System.EventHandler(this.BtnIstatıstık_Click);
            // 
            // FrmAnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 150);
            this.Controls.Add(this.BtnIstatıstık);
            this.Controls.Add(this.BtnUrun);
            this.Controls.Add(this.BtnKategori);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmAnaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAnaForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnKategori;
        private System.Windows.Forms.Button BtnUrun;
        private System.Windows.Forms.Button BtnIstatıstık;
    }
}