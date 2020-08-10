using DevExpress.XtraEditors.Controls;
using Newtonsoft.Json;
using SILS.API;
using SILS.Console;
using SILS.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SILS.Winform
{
    public partial class BookDetailForm : Form
    {
        int bookId;
        private BookDetailForm()
        {
            InitializeComponent();
        }

        public BookDetailForm(Book book) : this()
        {
            bookId = book.BookId;
            lblName.Text = book.Name;
            lblAuthor.Text = book.Author;
            lblPublisher.Text = book.Publisher;
            lblPublishedYear.Text = book.PublicationYear;
            lblISBN.Text = book.ISBN;
            lblKDC.Text = DataRepository.Code.Get(book.KDCId).Name;
            bdsLibrary.DataSource = DataRepository.Library.GetByBook(book.BookId);
            this.pePicture.EditValue = PictureAPI.Instance.WebImageView(book.ISBN);
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            Library library = bdsLibrary.Current as Library;

            if (library == null)
                return;

            LibraryDetailForm libraryDetailForm = new LibraryDetailForm(library);
            libraryDetailForm.ShowDialog();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            BookReportForm bookReportForm= new BookReportForm(bookId);
            bookReportForm.ShowDialog();
        }
    }
}
