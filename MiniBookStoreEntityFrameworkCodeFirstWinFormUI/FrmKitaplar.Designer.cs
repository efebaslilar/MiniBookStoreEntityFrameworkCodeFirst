
namespace MiniBookStoreEntityFrameworkCodeFirstWinFormUI
{
    partial class FrmKitaplar
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageBookAdd = new System.Windows.Forms.TabPage();
            this.numericUpDownStock = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.btnBookAdd = new System.Windows.Forms.Button();
            this.numericUpDownBookPage = new System.Windows.Forms.NumericUpDown();
            this.cmbBoxAuthor = new System.Windows.Forms.ComboBox();
            this.cmbBoxGenre = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIsbn = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbookname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageBookSale = new System.Windows.Forms.TabPage();
            this.txtBookSearch = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.BtnBookBuy = new System.Windows.Forms.Button();
            this.listBoxBooks = new System.Windows.Forms.ListBox();
            this.numericUpDownBookCount = new System.Windows.Forms.NumericUpDown();
            this.tabControl1.SuspendLayout();
            this.tabPageBookAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBookPage)).BeginInit();
            this.tabPageBookSale.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBookCount)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageBookAdd);
            this.tabControl1.Controls.Add(this.tabPageBookSale);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(6);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(957, 520);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageBookAdd
            // 
            this.tabPageBookAdd.Controls.Add(this.numericUpDownStock);
            this.tabPageBookAdd.Controls.Add(this.label6);
            this.tabPageBookAdd.Controls.Add(this.btnBookAdd);
            this.tabPageBookAdd.Controls.Add(this.numericUpDownBookPage);
            this.tabPageBookAdd.Controls.Add(this.cmbBoxAuthor);
            this.tabPageBookAdd.Controls.Add(this.cmbBoxGenre);
            this.tabPageBookAdd.Controls.Add(this.label5);
            this.tabPageBookAdd.Controls.Add(this.label4);
            this.tabPageBookAdd.Controls.Add(this.label3);
            this.tabPageBookAdd.Controls.Add(this.txtIsbn);
            this.tabPageBookAdd.Controls.Add(this.label2);
            this.tabPageBookAdd.Controls.Add(this.txtbookname);
            this.tabPageBookAdd.Controls.Add(this.label1);
            this.tabPageBookAdd.Location = new System.Drawing.Point(4, 33);
            this.tabPageBookAdd.Margin = new System.Windows.Forms.Padding(6);
            this.tabPageBookAdd.Name = "tabPageBookAdd";
            this.tabPageBookAdd.Padding = new System.Windows.Forms.Padding(6);
            this.tabPageBookAdd.Size = new System.Drawing.Size(949, 483);
            this.tabPageBookAdd.TabIndex = 0;
            this.tabPageBookAdd.Text = "Yeni Kitap Ekle";
            this.tabPageBookAdd.UseVisualStyleBackColor = true;
            // 
            // numericUpDownStock
            // 
            this.numericUpDownStock.Location = new System.Drawing.Point(611, 191);
            this.numericUpDownStock.Name = "numericUpDownStock";
            this.numericUpDownStock.Size = new System.Drawing.Size(120, 29);
            this.numericUpDownStock.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(437, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 24);
            this.label6.TabIndex = 13;
            this.label6.Text = "Stok Adedi :";
            // 
            // btnBookAdd
            // 
            this.btnBookAdd.Location = new System.Drawing.Point(333, 300);
            this.btnBookAdd.Name = "btnBookAdd";
            this.btnBookAdd.Size = new System.Drawing.Size(273, 109);
            this.btnBookAdd.TabIndex = 12;
            this.btnBookAdd.Text = "KİTAP EKLE ";
            this.btnBookAdd.UseVisualStyleBackColor = true;
            this.btnBookAdd.Click += new System.EventHandler(this.btnBookAdd_Click);
            // 
            // numericUpDownBookPage
            // 
            this.numericUpDownBookPage.Location = new System.Drawing.Point(611, 120);
            this.numericUpDownBookPage.Name = "numericUpDownBookPage";
            this.numericUpDownBookPage.Size = new System.Drawing.Size(120, 29);
            this.numericUpDownBookPage.TabIndex = 11;
            // 
            // cmbBoxAuthor
            // 
            this.cmbBoxAuthor.FormattingEnabled = true;
            this.cmbBoxAuthor.Location = new System.Drawing.Point(611, 40);
            this.cmbBoxAuthor.Name = "cmbBoxAuthor";
            this.cmbBoxAuthor.Size = new System.Drawing.Size(197, 32);
            this.cmbBoxAuthor.TabIndex = 10;
            // 
            // cmbBoxGenre
            // 
            this.cmbBoxGenre.FormattingEnabled = true;
            this.cmbBoxGenre.Location = new System.Drawing.Point(188, 191);
            this.cmbBoxGenre.Name = "cmbBoxGenre";
            this.cmbBoxGenre.Size = new System.Drawing.Size(197, 32);
            this.cmbBoxGenre.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(437, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "Sayfa Sayısı :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(437, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Yazar :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tür : ";
            // 
            // txtIsbn
            // 
            this.txtIsbn.Location = new System.Drawing.Point(188, 115);
            this.txtIsbn.Name = "txtIsbn";
            this.txtIsbn.Size = new System.Drawing.Size(197, 29);
            this.txtIsbn.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "ISBN : ";
            // 
            // txtbookname
            // 
            this.txtbookname.Location = new System.Drawing.Point(188, 46);
            this.txtbookname.Name = "txtbookname";
            this.txtbookname.Size = new System.Drawing.Size(197, 29);
            this.txtbookname.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kitap Adı : ";
            // 
            // tabPageBookSale
            // 
            this.tabPageBookSale.Controls.Add(this.numericUpDownBookCount);
            this.tabPageBookSale.Controls.Add(this.listBoxBooks);
            this.tabPageBookSale.Controls.Add(this.BtnBookBuy);
            this.tabPageBookSale.Controls.Add(this.label);
            this.tabPageBookSale.Controls.Add(this.txtBookSearch);
            this.tabPageBookSale.Location = new System.Drawing.Point(4, 33);
            this.tabPageBookSale.Margin = new System.Windows.Forms.Padding(6);
            this.tabPageBookSale.Name = "tabPageBookSale";
            this.tabPageBookSale.Padding = new System.Windows.Forms.Padding(6);
            this.tabPageBookSale.Size = new System.Drawing.Size(949, 483);
            this.tabPageBookSale.TabIndex = 1;
            this.tabPageBookSale.Text = "Kitap Satış İşlemi";
            this.tabPageBookSale.UseVisualStyleBackColor = true;
            // 
            // txtBookSearch
            // 
            this.txtBookSearch.Location = new System.Drawing.Point(93, 48);
            this.txtBookSearch.Name = "txtBookSearch";
            this.txtBookSearch.Size = new System.Drawing.Size(356, 29);
            this.txtBookSearch.TabIndex = 0;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(595, 115);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(96, 24);
            this.label.TabIndex = 2;
            this.label.Text = "Kaç Adet :";
            // 
            // BtnBookBuy
            // 
            this.BtnBookBuy.Location = new System.Drawing.Point(543, 239);
            this.BtnBookBuy.Name = "BtnBookBuy";
            this.BtnBookBuy.Size = new System.Drawing.Size(237, 102);
            this.BtnBookBuy.TabIndex = 3;
            this.BtnBookBuy.Text = "Kitap Satışı Yap";
            this.BtnBookBuy.UseVisualStyleBackColor = true;
            this.BtnBookBuy.Click += new System.EventHandler(this.BtnBookBuy_Click);
            // 
            // listBoxBooks
            // 
            this.listBoxBooks.FormattingEnabled = true;
            this.listBoxBooks.ItemHeight = 24;
            this.listBoxBooks.Location = new System.Drawing.Point(93, 115);
            this.listBoxBooks.Name = "listBoxBooks";
            this.listBoxBooks.Size = new System.Drawing.Size(356, 340);
            this.listBoxBooks.TabIndex = 4;
            // 
            // numericUpDownBookCount
            // 
            this.numericUpDownBookCount.Location = new System.Drawing.Point(599, 166);
            this.numericUpDownBookCount.Name = "numericUpDownBookCount";
            this.numericUpDownBookCount.Size = new System.Drawing.Size(120, 29);
            this.numericUpDownBookCount.TabIndex = 5;
            // 
            // FrmKitaplar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 520);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FrmKitaplar";
            this.Text = "FrmKitaplar";
            this.Load += new System.EventHandler(this.FrmKitaplar_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageBookAdd.ResumeLayout(false);
            this.tabPageBookAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBookPage)).EndInit();
            this.tabPageBookSale.ResumeLayout(false);
            this.tabPageBookSale.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBookCount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageBookAdd;
        private System.Windows.Forms.TabPage tabPageBookSale;
        private System.Windows.Forms.NumericUpDown numericUpDownBookPage;
        private System.Windows.Forms.ComboBox cmbBoxAuthor;
        private System.Windows.Forms.ComboBox cmbBoxGenre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIsbn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbookname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBookAdd;
        private System.Windows.Forms.NumericUpDown numericUpDownStock;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox listBoxBooks;
        private System.Windows.Forms.Button BtnBookBuy;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox txtBookSearch;
        private System.Windows.Forms.NumericUpDown numericUpDownBookCount;
    }
}