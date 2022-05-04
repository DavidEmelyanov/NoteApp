namespace NoteAppUI
{
	partial class AboutForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
			this.AppNameLabel = new System.Windows.Forms.Label();
			this.AppVersionLabel = new System.Windows.Forms.Label();
			this.AuthorLabel = new System.Windows.Forms.Label();
			this.EmailLabel = new System.Windows.Forms.Label();
			this.GithubLabel = new System.Windows.Forms.Label();
			this.AbouDateLabel = new System.Windows.Forms.Label();
			this.EmailLinkLabel = new System.Windows.Forms.LinkLabel();
			this.GithubLinkLabel = new System.Windows.Forms.LinkLabel();
			this.AuthorNameLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// AppNameLabel
			// 
			this.AppNameLabel.AutoSize = true;
			this.AppNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.AppNameLabel.Location = new System.Drawing.Point(11, 19);
			this.AppNameLabel.Name = "AppNameLabel";
			this.AppNameLabel.Size = new System.Drawing.Size(92, 24);
			this.AppNameLabel.TabIndex = 0;
			this.AppNameLabel.Text = "NoteApp";
			// 
			// AppVersionLabel
			// 
			this.AppVersionLabel.AutoSize = true;
			this.AppVersionLabel.Location = new System.Drawing.Point(12, 53);
			this.AppVersionLabel.Name = "AppVersionLabel";
			this.AppVersionLabel.Size = new System.Drawing.Size(43, 13);
			this.AppVersionLabel.TabIndex = 1;
			this.AppVersionLabel.Text = "v. 1.0.0";
			// 
			// AuthorLabel
			// 
			this.AuthorLabel.AutoSize = true;
			this.AuthorLabel.Location = new System.Drawing.Point(12, 88);
			this.AuthorLabel.Name = "AuthorLabel";
			this.AuthorLabel.Size = new System.Drawing.Size(41, 13);
			this.AuthorLabel.TabIndex = 2;
			this.AuthorLabel.Text = "Author:";
			// 
			// EmailLabel
			// 
			this.EmailLabel.AutoSize = true;
			this.EmailLabel.Location = new System.Drawing.Point(12, 123);
			this.EmailLabel.Name = "EmailLabel";
			this.EmailLabel.Size = new System.Drawing.Size(38, 13);
			this.EmailLabel.TabIndex = 3;
			this.EmailLabel.Text = "E-mail:";
			// 
			// GithubLabel
			// 
			this.GithubLabel.AutoSize = true;
			this.GithubLabel.Location = new System.Drawing.Point(12, 146);
			this.GithubLabel.Name = "GithubLabel";
			this.GithubLabel.Size = new System.Drawing.Size(43, 13);
			this.GithubLabel.TabIndex = 4;
			this.GithubLabel.Text = "GitHub:";
			// 
			// AbouDateLabel
			// 
			this.AbouDateLabel.AutoSize = true;
			this.AbouDateLabel.Location = new System.Drawing.Point(12, 216);
			this.AbouDateLabel.Name = "AbouDateLabel";
			this.AbouDateLabel.Size = new System.Drawing.Size(127, 13);
			this.AbouDateLabel.TabIndex = 5;
			this.AbouDateLabel.Text = "2019 Olga Andreevskaya";
			// 
			// EmailLinkLabel
			// 
			this.EmailLinkLabel.AutoSize = true;
			this.EmailLinkLabel.Location = new System.Drawing.Point(61, 123);
			this.EmailLinkLabel.Name = "EmailLinkLabel";
			this.EmailLinkLabel.Size = new System.Drawing.Size(113, 13);
			this.EmailLinkLabel.TabIndex = 6;
			this.EmailLinkLabel.TabStop = true;
			this.EmailLinkLabel.Text = "intels1155@gmail.com";
			this.EmailLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.EmailLinkLabel_LinkClicked);
			// 
			// GithubLinkLabel
			// 
			this.GithubLinkLabel.AutoSize = true;
			this.GithubLinkLabel.Location = new System.Drawing.Point(61, 146);
			this.GithubLinkLabel.Name = "GithubLinkLabel";
			this.GithubLinkLabel.Size = new System.Drawing.Size(159, 13);
			this.GithubLinkLabel.TabIndex = 7;
			this.GithubLinkLabel.TabStop = true;
			this.GithubLinkLabel.Text = "github.com/intels1155/NoteApp";
			this.GithubLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.GithubLinkLabel_LinkClicked);
			// 
			// AuthorNameLabel
			// 
			this.AuthorNameLabel.AutoSize = true;
			this.AuthorNameLabel.Location = new System.Drawing.Point(64, 88);
			this.AuthorNameLabel.Name = "AuthorNameLabel";
			this.AuthorNameLabel.Size = new System.Drawing.Size(100, 13);
			this.AuthorNameLabel.TabIndex = 8;
			this.AuthorNameLabel.Text = "Olga Andreevskaya";
			// 
			// AboutForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(269, 238);
			this.Controls.Add(this.AuthorNameLabel);
			this.Controls.Add(this.GithubLinkLabel);
			this.Controls.Add(this.EmailLinkLabel);
			this.Controls.Add(this.AbouDateLabel);
			this.Controls.Add(this.GithubLabel);
			this.Controls.Add(this.EmailLabel);
			this.Controls.Add(this.AuthorLabel);
			this.Controls.Add(this.AppVersionLabel);
			this.Controls.Add(this.AppNameLabel);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "AboutForm";
			this.Text = "About";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label AppNameLabel;
		private System.Windows.Forms.Label AppVersionLabel;
		private System.Windows.Forms.Label AuthorLabel;
		private System.Windows.Forms.Label EmailLabel;
		private System.Windows.Forms.Label GithubLabel;
		private System.Windows.Forms.Label AbouDateLabel;
		private System.Windows.Forms.LinkLabel EmailLinkLabel;
		private System.Windows.Forms.LinkLabel GithubLinkLabel;
		private System.Windows.Forms.Label AuthorNameLabel;
	}
}