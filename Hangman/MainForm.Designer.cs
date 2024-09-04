namespace Hangman
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.txtLetterGuess = new System.Windows.Forms.TextBox();
            this.btnSubmitGuess = new System.Windows.Forms.Button();
            this.flpAlphabet = new System.Windows.Forms.FlowLayoutPanel();
            this.picHangman = new System.Windows.Forms.PictureBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblTest = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNewWord = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAboutDeveloper = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHowToPlay = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTools = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHint = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.picHangman)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtLetterGuess
            // 
            this.txtLetterGuess.Location = new System.Drawing.Point(141, 413);
            this.txtLetterGuess.Name = "txtLetterGuess";
            this.txtLetterGuess.Size = new System.Drawing.Size(177, 22);
            this.txtLetterGuess.TabIndex = 1;
            // 
            // btnSubmitGuess
            // 
            this.btnSubmitGuess.Location = new System.Drawing.Point(360, 406);
            this.btnSubmitGuess.Name = "btnSubmitGuess";
            this.btnSubmitGuess.Size = new System.Drawing.Size(131, 36);
            this.btnSubmitGuess.TabIndex = 2;
            this.btnSubmitGuess.Text = "Enter";
            this.btnSubmitGuess.UseVisualStyleBackColor = true;
            // 
            // flpAlphabet
            // 
            this.flpAlphabet.Location = new System.Drawing.Point(615, 40);
            this.flpAlphabet.Name = "flpAlphabet";
            this.flpAlphabet.Size = new System.Drawing.Size(319, 402);
            this.flpAlphabet.TabIndex = 4;
            // 
            // picHangman
            // 
            this.picHangman.Image = global::Hangman.Properties.Resources._base;
            this.picHangman.Location = new System.Drawing.Point(220, 74);
            this.picHangman.Name = "picHangman";
            this.picHangman.Size = new System.Drawing.Size(214, 203);
            this.picHangman.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHangman.TabIndex = 6;
            this.picHangman.TabStop = false;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // lblTest
            // 
            this.lblTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTest.Location = new System.Drawing.Point(52, 306);
            this.lblTest.Name = "lblTest";
            this.lblTest.Size = new System.Drawing.Size(504, 50);
            this.lblTest.TabIndex = 7;
            this.lblTest.Text = "lblTest";
            this.lblTest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuTools,
            this.mnuHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(993, 28);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNewWord,
            this.mnuExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(46, 24);
            this.mnuFile.Text = "File";
            // 
            // mnuNewWord
            // 
            this.mnuNewWord.Name = "mnuNewWord";
            this.mnuNewWord.Size = new System.Drawing.Size(224, 26);
            this.mnuNewWord.Text = "New Word";
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(224, 26);
            this.mnuExit.Text = "Exit";
            // 
            // mnuHelp
            // 
            this.mnuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHowToPlay,
            this.mnuAboutDeveloper});
            this.mnuHelp.Name = "mnuHelp";
            this.mnuHelp.Size = new System.Drawing.Size(55, 24);
            this.mnuHelp.Text = "Help";
            // 
            // mnuAboutDeveloper
            // 
            this.mnuAboutDeveloper.Name = "mnuAboutDeveloper";
            this.mnuAboutDeveloper.Size = new System.Drawing.Size(224, 26);
            this.mnuAboutDeveloper.Text = "About Developer";
            // 
            // mnuHowToPlay
            // 
            this.mnuHowToPlay.Name = "mnuHowToPlay";
            this.mnuHowToPlay.Size = new System.Drawing.Size(224, 26);
            this.mnuHowToPlay.Text = "How to Play";
            // 
            // mnuTools
            // 
            this.mnuTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHint});
            this.mnuTools.Name = "mnuTools";
            this.mnuTools.Size = new System.Drawing.Size(58, 24);
            this.mnuTools.Text = "Tools";
            // 
            // mnuHint
            // 
            this.mnuHint.Name = "mnuHint";
            this.mnuHint.Size = new System.Drawing.Size(224, 26);
            this.mnuHint.Text = "Hint";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 544);
            this.Controls.Add(this.lblTest);
            this.Controls.Add(this.picHangman);
            this.Controls.Add(this.flpAlphabet);
            this.Controls.Add(this.btnSubmitGuess);
            this.Controls.Add(this.txtLetterGuess);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Hangman";
            ((System.ComponentModel.ISupportInitialize)(this.picHangman)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtLetterGuess;
        private System.Windows.Forms.Button btnSubmitGuess;
        private System.Windows.Forms.FlowLayoutPanel flpAlphabet;
        private System.Windows.Forms.PictureBox picHangman;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Label lblTest;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuHelp;
        private System.Windows.Forms.ToolStripMenuItem mnuAboutDeveloper;
        private System.Windows.Forms.ToolStripMenuItem mnuNewWord;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuHowToPlay;
        private System.Windows.Forms.ToolStripMenuItem mnuTools;
        private System.Windows.Forms.ToolStripMenuItem mnuHint;
    }
}

