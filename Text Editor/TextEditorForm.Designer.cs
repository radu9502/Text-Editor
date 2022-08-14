namespace Text_Editor
{
    partial class textEditorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuNew = new System.Windows.Forms.ToolStripMenuItem();
            this.open = new System.Windows.Forms.ToolStripMenuItem();
            this.save = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.formatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBold = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItalic = new System.Windows.Forms.ToolStripMenuItem();
            this.menuUnderline = new System.Windows.Forms.ToolStripMenuItem();
            this.sizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSizeSmall = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSizeMedium = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSizeLarge = new System.Windows.Forms.ToolStripMenuItem();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.saveAsFile = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(12, 33);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox.Size = new System.Drawing.Size(762, 363);
            this.textBox.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.formatToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuNew,
            this.open,
            this.save,
            this.saveAs,
            this.menuExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // menuNew
            // 
            this.menuNew.Name = "menuNew";
            this.menuNew.Size = new System.Drawing.Size(123, 22);
            this.menuNew.Text = "&New";
            this.menuNew.Click += new System.EventHandler(this.menuNew_Click);
            // 
            // open
            // 
            this.open.Name = "open";
            this.open.Size = new System.Drawing.Size(123, 22);
            this.open.Text = "&Open...";
            this.open.Click += new System.EventHandler(this.Open_Click);
            // 
            // save
            // 
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(123, 22);
            this.save.Text = "&Save";
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // saveAs
            // 
            this.saveAs.Name = "saveAs";
            this.saveAs.Size = new System.Drawing.Size(123, 22);
            this.saveAs.Text = "&Save As...";
            this.saveAs.Click += new System.EventHandler(this.saveAs_Click);
            // 
            // menuExit
            // 
            this.menuExit.Name = "menuExit";
            this.menuExit.Size = new System.Drawing.Size(123, 22);
            this.menuExit.Text = "&Exit";
            this.menuExit.Click += new System.EventHandler(this.menuExit_Click);
            // 
            // formatToolStripMenuItem
            // 
            this.formatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuBold,
            this.menuItalic,
            this.menuUnderline,
            this.sizeToolStripMenuItem});
            this.formatToolStripMenuItem.Name = "formatToolStripMenuItem";
            this.formatToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.formatToolStripMenuItem.Text = "&Format";
            // 
            // menuBold
            // 
            this.menuBold.CheckOnClick = true;
            this.menuBold.Name = "menuBold";
            this.menuBold.Size = new System.Drawing.Size(125, 22);
            this.menuBold.Text = "&Bold";
            this.menuBold.Click += new System.EventHandler(this.OnChangeStyle);
            // 
            // menuItalic
            // 
            this.menuItalic.CheckOnClick = true;
            this.menuItalic.Name = "menuItalic";
            this.menuItalic.Size = new System.Drawing.Size(125, 22);
            this.menuItalic.Text = "&Italic";
            this.menuItalic.Click += new System.EventHandler(this.OnChangeStyle);
            // 
            // menuUnderline
            // 
            this.menuUnderline.CheckOnClick = true;
            this.menuUnderline.Name = "menuUnderline";
            this.menuUnderline.Size = new System.Drawing.Size(125, 22);
            this.menuUnderline.Text = "&Underline";
            this.menuUnderline.Click += new System.EventHandler(this.OnChangeStyle);
            // 
            // sizeToolStripMenuItem
            // 
            this.sizeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSizeSmall,
            this.menuSizeMedium,
            this.menuSizeLarge});
            this.sizeToolStripMenuItem.Name = "sizeToolStripMenuItem";
            this.sizeToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.sizeToolStripMenuItem.Text = "&Size";
            // 
            // menuSizeSmall
            // 
            this.menuSizeSmall.Checked = true;
            this.menuSizeSmall.CheckOnClick = true;
            this.menuSizeSmall.CheckState = System.Windows.Forms.CheckState.Checked;
            this.menuSizeSmall.Name = "menuSizeSmall";
            this.menuSizeSmall.Size = new System.Drawing.Size(119, 22);
            this.menuSizeSmall.Text = "&Small";
            this.menuSizeSmall.Click += new System.EventHandler(this.OnSizeChnage);
            // 
            // menuSizeMedium
            // 
            this.menuSizeMedium.CheckOnClick = true;
            this.menuSizeMedium.Name = "menuSizeMedium";
            this.menuSizeMedium.Size = new System.Drawing.Size(119, 22);
            this.menuSizeMedium.Text = "&Medium";
            this.menuSizeMedium.Click += new System.EventHandler(this.OnSizeChnage);
            // 
            // menuSizeLarge
            // 
            this.menuSizeLarge.CheckOnClick = true;
            this.menuSizeLarge.Name = "menuSizeLarge";
            this.menuSizeLarge.Size = new System.Drawing.Size(119, 22);
            this.menuSizeLarge.Text = "&Large";
            this.menuSizeLarge.Click += new System.EventHandler(this.OnSizeChnage);
            // 
            // openFile
            // 
            this.openFile.FileName = "openFile";
            this.openFile.Filter = "Text Files (*.txt)|*.txt";
            // 
            // saveAsFile
            // 
            this.saveAsFile.FileName = "saveAsFile";
            this.saveAsFile.Filter = "Text Files (*.txt)|*.txt";
            // 
            // textEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "textEditorForm";
            this.Text = "Text Editor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnClosing);
            this.Load += new System.EventHandler(this.TextEditorForm_Load);
            this.SizeChanged += new System.EventHandler(this.OnFormSizeChanged);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem menuNew;
        private ToolStripMenuItem menuExit;
        private ToolStripMenuItem formatToolStripMenuItem;
        private ToolStripMenuItem menuBold;
        private ToolStripMenuItem menuItalic;
        private ToolStripMenuItem menuUnderline;
        private ToolStripMenuItem sizeToolStripMenuItem;
        private ToolStripMenuItem menuSizeSmall;
        private ToolStripMenuItem menuSizeMedium;
        private ToolStripMenuItem menuSizeLarge;
        private OpenFileDialog openFile;
        private SaveFileDialog saveAsFile;
        private ToolStripMenuItem open;
        private ToolStripMenuItem save;
        private ToolStripMenuItem saveAs;
    }
}