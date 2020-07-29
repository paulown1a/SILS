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
    public partial class BookDetailForm : Form
    {
        private BookDetailForm()
        {
            InitializeComponent();
        }

        public BookDetailForm(Book book) : this()
        {
            lblName.Text = book.Name;
            lblAuthor.Text = book.Author;
            lblPublisher.Text = book.Publisher;
            lblPublishedYear.Text = book.PublicationYear;
            lblISBN.Text = book.ISBN;
            lblKDC.Text = DataRepository.Code.Get(book.KDCId).Name;
            bdsLibrary.DataSource = DataRepository.Library.GetByBook(book.BookId);
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            Library library = bdsLibrary.Current as Library;

            if (library == null)
                return;

            LibraryDetailForm libraryDetailForm = new LibraryDetailForm(library);
            libraryDetailForm.ShowDialog();
        }
    }
}
