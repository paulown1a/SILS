using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using SILS.Data;

namespace SILS.Winform
{
    public partial class BookListForm : DevExpress.XtraEditors.XtraForm
    {
        private BookListForm()
        {
            InitializeComponent();
        }

        public BookListForm(string name) : this()
        {
            bdsBook.DataSource = DataRepository.Book.GetAllName(name);
            lblSearchText.Text = $"\"{name}\" 검색 결과";
        }
        
        public BookListForm(string name, string publisher, string author, string publishedYear) : this()
        {
            bdsBook.DataSource = DataRepository.Book.GetAllName(name, publisher, author, publishedYear);
            lblSearchText.Text = $"\"{name}\" 검색 결과";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txbName.Text == "도서 검색")
                return;
            bdsBook.DataSource = DataRepository.Book.GetAllName(txbName.Text);
            lblSearchText.Text = $"\"{txbName.Text}\" 검색 결과";
        }

        private void grvBooks_DoubleClick(object sender, EventArgs e)
        {
            Book book = bdsBook.Current as Book;
            
            if (book == null)
                return;

            BookDetailForm bookDetailForm = new BookDetailForm(book);
            bookDetailForm.ShowDialog();
        }

        private void txbName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnSearch_Click(this, e);
        }
    }
}