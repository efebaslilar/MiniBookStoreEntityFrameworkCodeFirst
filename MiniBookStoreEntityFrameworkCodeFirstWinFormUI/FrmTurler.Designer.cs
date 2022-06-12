
namespace MiniBookStoreEntityFrameworkCodeFirstWinFormUI
{
    partial class FrmTurler
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnTurKaydet = new System.Windows.Forms.Button();
            this.txtTur = new System.Windows.Forms.TextBox();
            this.dataGridViewTurlar = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTurlar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tür Adı :";
            // 
            // btnTurKaydet
            // 
            this.btnTurKaydet.Location = new System.Drawing.Point(516, 42);
            this.btnTurKaydet.Name = "btnTurKaydet";
            this.btnTurKaydet.Size = new System.Drawing.Size(118, 59);
            this.btnTurKaydet.TabIndex = 1;
            this.btnTurKaydet.Text = "Kaydet";
            this.btnTurKaydet.UseVisualStyleBackColor = true;
            this.btnTurKaydet.Click += new System.EventHandler(this.btnTurKaydet_Click);
            // 
            // txtTur
            // 
            this.txtTur.Location = new System.Drawing.Point(212, 59);
            this.txtTur.Name = "txtTur";
            this.txtTur.Size = new System.Drawing.Size(253, 31);
            this.txtTur.TabIndex = 2;
            // 
            // dataGridViewTurlar
            // 
            this.dataGridViewTurlar.AllowUserToAddRows = false;
            this.dataGridViewTurlar.AllowUserToDeleteRows = false;
            this.dataGridViewTurlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTurlar.Location = new System.Drawing.Point(45, 149);
            this.dataGridViewTurlar.Name = "dataGridViewTurlar";
            this.dataGridViewTurlar.ReadOnly = true;
            this.dataGridViewTurlar.Size = new System.Drawing.Size(654, 315);
            this.dataGridViewTurlar.TabIndex = 3;
            // 
            // FrmTurler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 523);
            this.Controls.Add(this.dataGridViewTurlar);
            this.Controls.Add(this.txtTur);
            this.Controls.Add(this.btnTurKaydet);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FrmTurler";
            this.Text = "s";
            this.Load += new System.EventHandler(this.FrmTurler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTurlar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTurKaydet;
        private System.Windows.Forms.TextBox txtTur;
        private System.Windows.Forms.DataGridView dataGridViewTurlar;
    }
}