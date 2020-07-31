using SILS.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SILS.Winform
{
    public partial class LibraryListForm : Form
    {
        public LibraryListForm()
        {
            InitializeComponent();
            bdsSiDo.DataSource = DataRepository.Code.GetLocation();
            bdsGuGun.DataSource = DataRepository.Code.GetLocation("L100");
            bdsLibrary.DataSource = DataRepository.Library.GetByLocation("L101");
        }

        private void cbbSiDo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbSiDo.SelectedValue == null)
                return;
            bdsGuGun.DataSource = DataRepository.Code.GetLocation(cbbSiDo.SelectedValue.ToString());
            bdsLibrary.DataSource = DataRepository.Library.GetByLocation(cbbSiDo.SelectedValue.ToString().Substring(0,3)+"1");
        }

        private void cbbGuGun_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbGuGun.SelectedValue == null)
                return;
            bdsLibrary.DataSource = DataRepository.Library.GetByLocation(cbbGuGun.SelectedValue.ToString());
        }

        private void grvLibrary_DoubleClick(object sender, EventArgs e)
        {
            Library library = bdsLibrary.Current as Library;

            if (library == null)
                return;

            LibraryDetailForm libraryDetailForm = new LibraryDetailForm(library);
            libraryDetailForm.Show();
        }
    }
}
