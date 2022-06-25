
namespace MiniBookStoreEntityFrameworkCodeFirstWinFormUI
{
    partial class FrmGiris
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
            this.btnTurler = new System.Windows.Forms.Button();
            this.btnYazar = new System.Windows.Forms.Button();
            this.btnKitapIslemleri = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTurler
            // 
            this.btnTurler.Location = new System.Drawing.Point(88, 36);
            this.btnTurler.Name = "btnTurler";
            this.btnTurler.Size = new System.Drawing.Size(227, 115);
            this.btnTurler.TabIndex = 0;
            this.btnTurler.Text = "Tür İşlemleri";
            this.btnTurler.UseVisualStyleBackColor = true;
            this.btnTurler.Click += new System.EventHandler(this.btnTurler_Click);
            // 
            // btnYazar
            // 
            this.btnYazar.Location = new System.Drawing.Point(88, 190);
            this.btnYazar.Name = "btnYazar";
            this.btnYazar.Size = new System.Drawing.Size(227, 115);
            this.btnYazar.TabIndex = 2;
            this.btnYazar.Text = "YAZAR İŞLEMLERİ";
            this.btnYazar.UseVisualStyleBackColor = true;
            // 
            // btnKitapIslemleri
            // 
            this.btnKitapIslemleri.Location = new System.Drawing.Point(88, 349);
            this.btnKitapIslemleri.Name = "btnKitapIslemleri";
            this.btnKitapIslemleri.Size = new System.Drawing.Size(227, 115);
            this.btnKitapIslemleri.TabIndex = 3;
            this.btnKitapIslemleri.Text = "KİTAP İŞLEMLERİ";
            this.btnKitapIslemleri.UseVisualStyleBackColor = true;
            this.btnKitapIslemleri.Click += new System.EventHandler(this.btnKitapIslemleri_Click);
            // 
            // FrmGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 545);
            this.Controls.Add(this.btnKitapIslemleri);
            this.Controls.Add(this.btnYazar);
            this.Controls.Add(this.btnTurler);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FrmGiris";
            this.Text = "Mini Book Store";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTurler;
        private System.Windows.Forms.Button btnYazar;
        private System.Windows.Forms.Button btnKitapIslemleri;
    }
}

