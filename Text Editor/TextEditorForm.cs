using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Text_Editor
{
    public partial class TextEditorForm : Form
    {
        public TextEditorForm()
        {
            InitializeComponent();
        }

        /*     private void TextEditorForm_Load(object sender, EventArgs e)
             {

             }*/
        #region fields
        int fontSize = 8;
        string fontName = "MS Sans Serif";
        FontStyle newFont = FontStyle.Regular;
        #endregion

        #region methodes

        public void ClearText()
        {
            textBox.Text = string.Empty;
        }
        public void ChangeFont()
        {
       
            if (menuBold.Checked)
            {
               newFont = newFont | FontStyle.Bold;
            } 

            if (menuItalic.Checked)
            {
                newFont = newFont | FontStyle.Italic;
            }
            if (menuUnderline.Checked)
            {
                newFont = newFont | FontStyle.Underline;
            }
           
            textBox.Font = new Font(fontName, fontSize, newFont);
        }
        public void ChangeSize()
        {
            if (menuSizeSmall.Checked)
            {
                fontSize = 8;
            }
            if (menuSizeMedium.Checked)
            {
                fontSize = 12;
                menuSizeSmall.Checked = false;
                menuSizeLarge.Checked = false;
            }
            if (menuSizeLarge.Checked)
            {
                fontSize = 16;
                menuSizeMedium.Checked = false;
                menuSizeSmall.Checked = false;
            }
            textBox.Font = new Font(fontName, fontSize, newFont);

        }
        #endregion

        #region onClickEvents
        private void menuBold_Click(object sender, EventArgs e)
        {
            ChangeFont();
        }

        private void menuItalic_Click(object sender, EventArgs e)
        {
            ChangeFont();
        }

        private void menuSizeSmall_Click(object sender, EventArgs e)
        {   
            if(!menuSizeSmall.Checked) menuSizeSmall.Checked = true;
            else
            {

                menuSizeMedium.Checked = false;
                menuSizeLarge.Checked = false;
                ChangeSize();
            }
            
        }
   
        private void menuSizeMedium_Click(object sender, EventArgs e)
        {
            if (!menuSizeMedium.Checked) menuSizeMedium.Checked = true;
            else
            {

                menuSizeSmall.Checked = false;
                menuSizeLarge.Checked = false;
                ChangeSize();
            }
        }

        private void menuSizeLarge_Click(object sender, EventArgs e)
        {
            if (!menuSizeLarge.Checked) menuSizeLarge.Checked = true;
            else
            {

                menuSizeSmall.Checked = false;
                menuSizeMedium.Checked = false;
                ChangeSize();
            }
        }
        private void menuNew_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to start a new file?", "New File", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ClearText();
            }
        }

        #endregion

        private void menuExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit the application?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
