using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SILS.Winform.Controls
{
    
    public partial class TextBoxEx : TextBox
    {
        string innerText;
        public TextBoxEx(string innerText)
        {
            InitializeComponent();
            Enter += TextBoxEx_Enter;
            Leave += TextBoxEx_Leave;

            this.innerText = innerText;
        }

        private void TextBoxEx_Enter(object sender, EventArgs e)
        {
            if(this.Text == innerText)
                this.Text = "";
        }


        private void TextBoxEx_Leave(object sender, EventArgs e)
        {
            if (this.Text == "")
                this.Text = innerText;
        }

        

    }
}
