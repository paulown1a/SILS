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
    public partial class LibraryDetailForm : DevExpress.XtraEditors.XtraForm
    {
        private LibraryDetailForm()
        {
            InitializeComponent();
        }

        public LibraryDetailForm(Library library) : this()
        {
            lblName.Text = library.Name;
            lblPhoneNumber.Text = library.PhoneNumber;
            lblAddress.Text = library.Address;
            lblWebSite.Text = library.Website;
        }

        private void lblWebSite_DoubleClick(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(lblWebSite.Text);
        }
    }
}
