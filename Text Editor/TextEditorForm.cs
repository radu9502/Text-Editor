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
        
        #endregion

        #region methodes

        public void ClearText()
        {
            textBox.Text = string.Empty;
        }
        public void ChangeFont()
        {
            FontStyle newFont = FontStyle.Regular;
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
       
        #endregion

        #region onClickEvents

        private void menuNew_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to start a new file?", "New File", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ClearText();
            }
        }
        private void menuExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit the application?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void OnSizeChnage(object sender, EventArgs e)
        {
            ToolStripMenuItem checkedSize = (ToolStripMenuItem)sender;
            menuSizeSmall.Checked = false;
            menuSizeMedium.Checked = false;
            menuSizeLarge.Checked = false;
            checkedSize.Checked = true;
            if (checkedSize == menuSizeSmall) fontSize = 8;
            if (checkedSize == menuSizeMedium) fontSize = 12;
            if (checkedSize == menuSizeLarge) fontSize = 16;
            ChangeFont();


        }
        private void OnChangeStyle(object sender, EventArgs e)
        {
            ChangeFont();
        }

        #endregion


    }
}
