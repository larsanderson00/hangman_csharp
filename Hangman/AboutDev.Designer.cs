namespace Hangman
{
    partial class AboutDev
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDevelopers = new System.Windows.Forms.Label();
            this.lblGameplayBy = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(214, 37);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(199, 46);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Hangman";
            // 
            // lblDevelopers
            // 
            this.lblDevelopers.AutoSize = true;
            this.lblDevelopers.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDevelopers.Location = new System.Drawing.Point(155, 113);
            this.lblDevelopers.Name = "lblDevelopers";
            this.lblDevelopers.Size = new System.Drawing.Size(304, 29);
            this.lblDevelopers.TabIndex = 1;
            this.lblDevelopers.Text = "Developers: Lars Anderson";
            // 
            // lblGameplayBy
            // 
            this.lblGameplayBy.AutoSize = true;
            this.lblGameplayBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameplayBy.Location = new System.Drawing.Point(77, 142);
            this.lblGameplayBy.Name = "lblGameplayBy";
            this.lblGameplayBy.Size = new System.Drawing.Size(155, 29);
            this.lblGameplayBy.TabIndex = 2;
            this.lblGameplayBy.Text = "Gameplay By";
            this.lblGameplayBy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(265, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Version 1.0";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(269, 198);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // AboutDev
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 248);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblGameplayBy);
            this.Controls.Add(this.lblDevelopers);
            this.Controls.Add(this.lblTitle);
            this.Name = "AboutDev";
            this.Text = "About Developer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDevelopers;
        private System.Windows.Forms.Label lblGameplayBy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOk;
    }
}