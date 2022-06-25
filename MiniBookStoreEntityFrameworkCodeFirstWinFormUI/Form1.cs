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
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
            
        }

        private void btnTurler_Click(object sender, EventArgs e)
        {
            FrmTurler frm = new FrmTurler();
            frm.ShowDialog();
        }

        private void btnKitapIslemleri_Click(object sender, EventArgs e)
        {
            FrmKitaplar frm = new FrmKitaplar();
            frm.ShowDialog();
        }
    }
}
