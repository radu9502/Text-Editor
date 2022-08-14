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
        string dataPath = Application.StartupPath + "\\data.ini";
        string currentFile = string.Empty;

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
            if(MessageBox.Show("Do you want to save the current file?", "Save file", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                save_Click(sender, e);
            }
            currentFile = string.Empty;
            ClearText();
        }
        private void menuExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to save the current file?", "Save file", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                save_Click( sender,  e);
            }
            Close();
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

        private void Open_Click(object sender, EventArgs e)
        {
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                StreamReader file = new StreamReader(openFile.FileName);
                textBox.Text = file.ReadToEnd();
                currentFile = openFile.FileName;
                file.Close();
            }
        }

        private void saveAs_Click(object sender, EventArgs e)
        {
            if (saveAsFile.ShowDialog() == DialogResult.OK)
            {
                StreamWriter file = new StreamWriter(saveAsFile.FileName);
                file.Write(textBox.Text);
                currentFile = saveAsFile.FileName;
                file.Close();
            }

        }

        private void save_Click(object sender, EventArgs e)
        {
            if (currentFile == string.Empty) saveAs_Click(sender, e);
            else
            {
                StreamWriter file = new StreamWriter(currentFile);
                file.Write(textBox.Text);
                file.Close();

            }
        }


        #endregion
        #region events
        private void TextEditorForm_Load(object sender, EventArgs e)
        {
            try
            {
                StreamReader file = new StreamReader(dataPath);

                menuBold.Checked = Convert.ToBoolean(file.ReadLine());
                menuUnderline.Checked = Convert.ToBoolean(file.ReadLine());
                menuItalic.Checked = Convert.ToBoolean(file.ReadLine());
                int size = Convert.ToInt32(file.ReadLine());
                switch (size)
                {
                    case 1:
                        menuSizeSmall.PerformClick();
                        break;
                    case 2:
                        menuSizeMedium.PerformClick();
                        break;
                    case 3:
                        menuSizeLarge.PerformClick();
                        break;

                }
                file.Close();
                ChangeFont();
            }
            catch
            {
                MessageBox.Show("Could not load the data! We will fix this for you!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Question);
                FileStream file = File.Create(dataPath);
            }
        }

        private void OnClosing(object sender, FormClosingEventArgs e)
        {
            StreamWriter file = new StreamWriter(dataPath);
            file.WriteLine(menuBold.Checked.ToString());
            file.WriteLine(menuUnderline.Checked.ToString());
            file.WriteLine(menuItalic.Checked.ToString());
            int i;
            if (menuSizeSmall.Checked) i = 1;
            else if (menuSizeMedium.Checked) i = 2;
            else i = 3;
            file.WriteLine(i.ToString());
            file.Close();
            

        }

        #endregion

    }
}
