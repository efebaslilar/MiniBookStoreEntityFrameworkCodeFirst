using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MiniBookStoreEntityFrameworkCodeFirstBussinesLogicLyr;
using MiniBookStoreEntityFrameworkCodeFirstEnttiesLayer.Entities;

namespace MiniBookStoreEntityFrameworkCodeFirstWinFormUI
{
    public partial class FrmTurler : Form
    {
        public FrmTurler()
        {
            InitializeComponent();
        }

        private BookGenreMenager menager = new BookGenreMenager();
        private void FrmTurler_Load(object sender, EventArgs e)
        {
            TumTurleriGrideGetir();
        }
        private void TumTurleriGrideGetir()
        {
            try
            {
             dataGridViewTurlar.DataSource = menager.BringAlltheBookGenres();
            }
            catch (Exception hata)
            {

                MessageBox.Show("Beklenmedik bir hata oluştu" + hata.Message) ;
            }
            
        }

        private void btnTurKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtTur.Text))
                {
                    MessageBox.Show("Tür adı boş geçilemez.");
                    return;
                }
                BookGenre bg = new BookGenre()
                {
                    GenreName = txtTur.Text,
                    CreatedDate = DateTime.Now,
                    IsDeleted = false
                 
                };
                menager.AddNewBookGenre(bg);
                MessageBox.Show("Yeni tür tür sisteme eklendi.");
                TumTurleriGrideGetir();

            }
            catch (Exception hata)
            {

                MessageBox.Show("Beklenmedik bir hata oluştu"+hata.Message);
            }
        }
    }
}
