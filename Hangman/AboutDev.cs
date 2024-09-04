using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hangman
{
    /// <summary>
    /// Represents part of the about developer form of the application.
    /// </summary>
    public partial class AboutDev : Form
    {
        /// <summary>
        /// Initializes a new instance of the AboutDev class.
        /// </summary>
        public AboutDev()
        {
            InitializeComponent();

            this.btnOk.Click += BtnOk_Click;

            this.lblGameplayBy.Text = "Game By: ??\n(probably originates from Victorian Era)";
        }

        /// <summary>
        /// Handles the Click event of the OK button.
        /// </summary>
        private void BtnOk_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
