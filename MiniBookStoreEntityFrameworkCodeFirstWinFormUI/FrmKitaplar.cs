using MiniBookStoreEntityFrameworkCodeFirstBussinesLogicLyr;
using MiniBookStoreEntityFrameworkCodeFirstEnttiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniBookStoreEntityFrameworkCodeFirstWinFormUI
{
    public partial class FrmKitaplar : Form
    {
        public FrmKitaplar()
        {
            InitializeComponent();
        }
        //menagerlar // şuanda bağımlı işlemler yapıyoruz.
        //ilerleyen zamanlarda dependecy injectionla bağımlılıktan kurtulacağız
        AuthorMenager authorMenager = new AuthorMenager();
        BookGenreMenager bookGenreMenager = new BookGenreMenager();
        BookMenager bookMenager = new BookMenager();
        BookSaleMenager bookSaleMenager = new BookSaleMenager();
        private void FrmKitaplar_Load(object sender, EventArgs e)
        {
            //comboboxlara databaseden tür ve yazarlar gelmelidir.
            GetAllBookGenresToCombo();
            GetAllAuthorsToCombo();
            numericUpDownBookPage.Maximum = 1500;
            getAllBooktoListBox();
        }

        private void getAllBooktoListBox()
        {
            try
            {
                listBoxBooks.DataSource = null;
                listBoxBooks.DataSource = bookMenager.GetAllBooks();
            }
            catch (Exception hata)
            {
                MessageBox.Show("Beklenmedik bir hata oluştu."+hata.Message);
            }
        }

        private void GetAllAuthorsToCombo()
        {
            try
            {
                var authors = authorMenager.GetAllAuthors();
                cmbBoxAuthor.DisplayMember = "Name Surname"; //burda Name Surname diye bir string olmadığı için default string alıyor o yüzden ovveride etitk.
                cmbBoxAuthor.ValueMember = "Id";
                cmbBoxAuthor.DataSource = authors;
                cmbBoxAuthor.SelectedIndex = -1;
                cmbBoxAuthor.Text = "Yazar Seçiniz...";
            }
            catch (Exception hata)
            {
                MessageBox.Show("Beklenmedik Bir Hata oluştu."+ hata.Message);
            }
        }

        private void GetAllBookGenresToCombo()
        {
            try
            {
                var bookGenre = bookGenreMenager.BringAlltheBookGenres();
                cmbBoxGenre.DataSource = bookGenre;
                cmbBoxGenre.DisplayMember = "GenreName";
                cmbBoxGenre.ValueMember = "Id";
                cmbBoxGenre.SelectedIndex = -1;
                cmbBoxGenre.Text = "Tür Seçiniz...";
            }
            catch (Exception hata)
            {

                MessageBox.Show("Beklenmedik Bir hata oluştu." + hata.Message);
            }
        }

        private void btnBookAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Book b = new Book()
                {
                    BookName = txtbookname.Text,
                    ISBN = txtIsbn.Text,
                    AuthorId = Convert.ToInt32(cmbBoxAuthor.SelectedValue),
                    GenreId = Convert.ToByte(cmbBoxGenre.SelectedValue),
                    CreatedDate = DateTime.Now,
                    IsDeleted = false,
                    Page= Convert.ToInt32(numericUpDownBookPage.Value),
                    PublicationYear=2022,
                    Stock = Convert.ToInt32(numericUpDownStock.Value)
               };
                bookMenager.AddNewBook(b);
                MessageBox.Show("Yeni Kitap Eklendi.");
                

                //temizlik işlemi todo
            }
            catch (Exception hata)
            {

                MessageBox.Show("Beklenmedik bir hata oluştu!"+hata.Message);
            }
        }

        private void BtnBookBuy_Click(object sender, EventArgs e)
        {
            try
            {
                Book SelectedBook = listBoxBooks.SelectedItem as Book;
                if (SelectedBook.Stock==0)
                {
                    MessageBox.Show($"{SelectedBook.BookName} adlı kitap stokta tükenmiştir.");
                    return;
                }
                if (SelectedBook.Stock<numericUpDownBookCount.Value)
                {
                    MessageBox.Show($"{SelectedBook.Stock} adet alabilirisiniz!");
                    return;
                }
                BookSale bs = new BookSale()
                {
                    BookId = SelectedBook.Id,
                    Count = Convert.ToInt32(numericUpDownBookCount.Value),
                    CreatedDate = DateTime.Now,
                    IsDeleted = false
                };
                bookSaleMenager.AddBookSale(bs);
                MessageBox.Show("Satış Yapıldı!");
                getAllBooktoListBox();
                //temizlik todo
            }
            catch (Exception hata)
            {

                MessageBox.Show("Beklenmedik Bir hata oluştu."+ hata.Message);
            }
        }
    }
}
