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
    public partial class BookSearchForm : DevExpress.XtraEditors.XtraForm
    {
        public BookSearchForm()
        {
            InitializeComponent();
        }

        private void btnSimpleSearch_Click(object sender, EventArgs e)
        {
            if (txbSimpleName.Text == "도서 검색")
                return;
            BookListForm bookListForm = new BookListForm(txbSimpleName.Text);
            ShowInTaskbar = false;
            Opacity = 0;
            bookListForm.ShowDialog();
            ShowInTaskbar = true;
            Opacity = 100;
            
        }

        private void chbUnclicked_CheckedChanged(object sender, EventArgs e)
        {
            chbUnclicked.Checked = false;
            txbSimpleName.Text = "도서 검색";
            pnDetailSearch.BringToFront();
            chbClicked.Checked = true;

        }

        private void txbSimpleName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnSimpleSearch_Click(this, e);
        }

        private void btnDetailSearch_Click(object sender, EventArgs e)
        {
           
            if (txbName.Text == "도서 검색" && txbAuthor.Text == "저자 검색" &&
                txbPublisher.Text == "출판사" && txbPublishedYear.Text == "출판 연도")
                return;

            BookListForm bookListForm = new BookListForm(txbName.Text == "도서 검색"?"":txbName.Text, txbPublisher.Text == "출판사"?null:txbPublisher.Text, txbAuthor.Text == "저자 검색" ? null : txbAuthor.Text, txbPublishedYear.Text == "출판 연도" ? null : txbPublishedYear.Text);
            ShowInTaskbar = false;
            Opacity = 0;
            bookListForm.ShowDialog();
            ShowInTaskbar = true;
            Opacity = 100;
        }
        //
        private void chbClicked_CheckedChanged(object sender, EventArgs e)
        {
            pnSimpleSearch.BringToFront();
            txbName.Text = "도서 검색";
            txbPublisher.Text = "출판사";
            txbAuthor.Text = "저자 검색";
            txbPublishedYear.Text = "출판 연도";
        }

        private void txbName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnDetailSearch_Click(this, e);
        }

        private void txbAuthor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnDetailSearch_Click(this, e);
        }

        private void txbPublisher_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnDetailSearch_Click(this, e);
        }

        private void txbPublishedYear_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnDetailSearch_Click(this, e);
        }

        private void btnLibraryList_Click(object sender, EventArgs e)
        {
            LibraryListForm libraryListForm = new LibraryListForm();
            libraryListForm.ShowDialog();
        }

        private void txbSimpleName_Click(object sender, EventArgs e)
        {
            txbSimpleName.Text = null;
        }

        private void txbName_Click(object sender, EventArgs e)
        {
            txbName.Text = null;
        }

        private void txbAuthor_Click(object sender, EventArgs e)
        {
            txbAuthor.Text = null;
        }

        private void txbPublisher_Click(object sender, EventArgs e)
        {
            txbPublisher.Text = null;
        }

        private void txbPublishedYear_Click(object sender, EventArgs e)
        {
            txbPublishedYear.Text = null;
        }

    }
}
