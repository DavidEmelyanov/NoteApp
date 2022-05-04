namespace NoteAppUI
{
	partial class NoteForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NoteForm));
			this.TitleLabel = new System.Windows.Forms.Label();
			this.CategoryLabel = new System.Windows.Forms.Label();
			this.CreatedLabel = new System.Windows.Forms.Label();
			this.TitleTextBox = new System.Windows.Forms.TextBox();
			this.CategoryComboBox = new System.Windows.Forms.ComboBox();
			this.CreatedDateTimeLabel = new System.Windows.Forms.Label();
			this.ModifiedLabel = new System.Windows.Forms.Label();
			this.ModifiedDateTimeLabel = new System.Windows.Forms.Label();
			this.NoteTextBox = new System.Windows.Forms.TextBox();
			this.CancelButton = new System.Windows.Forms.Button();
			this.OkButton = new System.Windows.Forms.Button();
			this.OkButtonToolTip = new System.Windows.Forms.ToolTip(this.components);
			this.CancelButtonToolTip = new System.Windows.Forms.ToolTip(this.components);
			this.SuspendLayout();
			// 
			// TitleLabel
			// 
			this.TitleLabel.AutoSize = true;
			this.TitleLabel.Location = new System.Drawing.Point(13, 16);
			this.TitleLabel.Name = "TitleLabel";
			this.TitleLabel.Size = new System.Drawing.Size(30, 13);
			this.TitleLabel.TabIndex = 0;
			this.TitleLabel.Text = "Title:";
			// 
			// CategoryLabel
			// 
			this.CategoryLabel.AutoSize = true;
			this.CategoryLabel.Location = new System.Drawing.Point(13, 47);
			this.CategoryLabel.Name = "CategoryLabel";
			this.CategoryLabel.Size = new System.Drawing.Size(52, 13);
			this.CategoryLabel.TabIndex = 1;
			this.CategoryLabel.Text = "Category:";
			// 
			// CreatedLabel
			// 
			this.CreatedLabel.AutoSize = true;
			this.CreatedLabel.Location = new System.Drawing.Point(229, 47);
			this.CreatedLabel.Name = "CreatedLabel";
			this.CreatedLabel.Size = new System.Drawing.Size(47, 13);
			this.CreatedLabel.TabIndex = 2;
			this.CreatedLabel.Text = "Created:";
			// 
			// TitleTextBox
			// 
			this.TitleTextBox.Location = new System.Drawing.Point(71, 13);
			this.TitleTextBox.MaxLength = 50;
			this.TitleTextBox.Name = "TitleTextBox";
			this.TitleTextBox.Size = new System.Drawing.Size(467, 20);
			this.TitleTextBox.TabIndex = 3;
			// 
			// CategoryComboBox
			// 
			this.CategoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.CategoryComboBox.FormattingEnabled = true;
			this.CategoryComboBox.Location = new System.Drawing.Point(71, 44);
			this.CategoryComboBox.Name = "CategoryComboBox";
			this.CategoryComboBox.Size = new System.Drawing.Size(144, 21);
			this.CategoryComboBox.TabIndex = 4;
			// 
			// CreatedDateTimeLabel
			// 
			this.CreatedDateTimeLabel.AutoSize = true;
			this.CreatedDateTimeLabel.Location = new System.Drawing.Point(282, 47);
			this.CreatedDateTimeLabel.Name = "CreatedDateTimeLabel";
			this.CreatedDateTimeLabel.Size = new System.Drawing.Size(90, 13);
			this.CreatedDateTimeLabel.TabIndex = 5;
			this.CreatedDateTimeLabel.Text = "CreatedDateTime";
			// 
			// ModifiedLabel
			// 
			this.ModifiedLabel.AutoSize = true;
			this.ModifiedLabel.Location = new System.Drawing.Point(392, 47);
			this.ModifiedLabel.Name = "ModifiedLabel";
			this.ModifiedLabel.Size = new System.Drawing.Size(50, 13);
			this.ModifiedLabel.TabIndex = 6;
			this.ModifiedLabel.Text = "Modified:";
			// 
			// ModifiedDateTimeLabel
			// 
			this.ModifiedDateTimeLabel.AutoSize = true;
			this.ModifiedDateTimeLabel.Location = new System.Drawing.Point(445, 47);
			this.ModifiedDateTimeLabel.Name = "ModifiedDateTimeLabel";
			this.ModifiedDateTimeLabel.Size = new System.Drawing.Size(93, 13);
			this.ModifiedDateTimeLabel.TabIndex = 7;
			this.ModifiedDateTimeLabel.Text = "ModifiedDateTime";
			// 
			// NoteTextBox
			// 
			this.NoteTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.NoteTextBox.Location = new System.Drawing.Point(16, 78);
			this.NoteTextBox.Multiline = true;
			this.NoteTextBox.Name = "NoteTextBox";
			this.NoteTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.NoteTextBox.Size = new System.Drawing.Size(522, 328);
			this.NoteTextBox.TabIndex = 8;
			// 
			// CancelButton
			// 
			this.CancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.CancelButton.Location = new System.Drawing.Point(463, 415);
			this.CancelButton.Name = "CancelButton";
			this.CancelButton.Size = new System.Drawing.Size(75, 23);
			this.CancelButton.TabIndex = 10;
			this.CancelButton.Text = "Cancel";
			this.CancelButton.UseVisualStyleBackColor = true;
			this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
			// 
			// OkButton
			// 
			this.OkButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.OkButton.Location = new System.Drawing.Point(382, 415);
			this.OkButton.Name = "OkButton";
			this.OkButton.Size = new System.Drawing.Size(75, 23);
			this.OkButton.TabIndex = 9;
			this.OkButton.Text = "OK";
			this.OkButton.UseVisualStyleBackColor = true;
			this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
			// 
			// NoteForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(553, 450);
			this.Controls.Add(this.OkButton);
			this.Controls.Add(this.CancelButton);
			this.Controls.Add(this.NoteTextBox);
			this.Controls.Add(this.ModifiedDateTimeLabel);
			this.Controls.Add(this.ModifiedLabel);
			this.Controls.Add(this.CreatedDateTimeLabel);
			this.Controls.Add(this.CategoryComboBox);
			this.Controls.Add(this.TitleTextBox);
			this.Controls.Add(this.CreatedLabel);
			this.Controls.Add(this.CategoryLabel);
			this.Controls.Add(this.TitleLabel);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(569, 250);
			this.Name = "NoteForm";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.Text = "Add/Edit Note";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label TitleLabel;
		private System.Windows.Forms.Label CategoryLabel;
		private System.Windows.Forms.Label CreatedLabel;
		private System.Windows.Forms.TextBox TitleTextBox;
		private System.Windows.Forms.ComboBox CategoryComboBox;
		private System.Windows.Forms.Label CreatedDateTimeLabel;
		private System.Windows.Forms.Label ModifiedLabel;
		private System.Windows.Forms.Label ModifiedDateTimeLabel;
		private System.Windows.Forms.TextBox NoteTextBox;
		private System.Windows.Forms.Button CancelButton;
		private System.Windows.Forms.Button OkButton;
		private System.Windows.Forms.ToolTip OkButtonToolTip;
		private System.Windows.Forms.ToolTip CancelButtonToolTip;
	}
}