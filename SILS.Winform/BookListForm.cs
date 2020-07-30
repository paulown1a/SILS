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

        private string _name;
        private string searchResult="";


        protected override async void OnShown(EventArgs e)
        {
            base.OnShown(e);

            bdsBook.DataSource = await DataRepository.Book.GetAllNameAsync(_name);
        }

        public BookListForm(string name) : this()
        {
            _name = name;
            lblSearchText.Text = $"\"{name}\" 검색 결과";
        }

        public BookListForm(string name, string publisher, string author, string publishedYear) : this()
        {
            bdsBook.DataSource = DataRepository.Book.GetAllName(name, author, publisher, publishedYear);
            string[] info = new string[4] { name, author, publisher, publishedYear };

            for (int i = 0; i < info.Length; i++)
            {
                if(info[i] != null)
                 searchResult += info[i] + " ";
            }
            

           lblSearchText.Text = $"{searchResult} 검색 결과";
            searchResult = "";

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