using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SILS.Winform
{
    public partial class BookSearch : DevExpress.XtraEditors.XtraForm
    {
        public BookSearch()
        {
            InitializeComponent();
        }

        private void btnSimpleSearch_Click(object sender, EventArgs e)
        {
            if (txbSimpleName.Text == "도서 검색")
                return;
            BookListForm searchedForm = new BookListForm(txbSimpleName.Text);
            ShowInTaskbar = false;
            Opacity = 0;
            searchedForm.ShowDialog();
            ShowInTaskbar = true;
            Opacity = 100;
        }

        private void chbUnclicked_CheckedChanged(object sender, EventArgs e)
        {
            pnSimpleSearch.Visible = false;
            chbClicked.Checked = true;
        }

        private void btnDetailSearch_Click(object sender, EventArgs e)
        {
            if (txbName.Text == "도서 검색")
                return;
            BookListForm bookListForm = new BookListForm(txbName.Text, txbPublisher.Text == "출판사"?null:txbPublisher.Text, txbAuthor.Text == "저자 검색" ? null : txbAuthor.Text, txbPublishedYear.Text == "출판 연도" ? null : txbPublishedYear.Text);
            ShowInTaskbar = false;
            Opacity = 0;
            bookListForm.ShowDialog();
            ShowInTaskbar = true;
            Opacity = 100;
        }

        private void chbClicked_CheckedChanged(object sender, EventArgs e)
        {
            pnSimpleSearch.Visible = true;
            chbUnclicked.Checked = false;
        }

    }
}
