namespace NoteAppUI
{
	partial class MainForm
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.MainMenu = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.addNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.editNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.deleteNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.MainSplitContainer = new System.Windows.Forms.SplitContainer();
			this.CountNotesLabel = new System.Windows.Forms.Label();
			this.NoteCountLabel = new System.Windows.Forms.Label();
			this.DeleteNoteButton = new System.Windows.Forms.Button();
			this.EditNoteButton = new System.Windows.Forms.Button();
			this.AddNoteButton = new System.Windows.Forms.Button();
			this.NotesListBox = new System.Windows.Forms.ListBox();
			this.CategoryComboBox = new System.Windows.Forms.ComboBox();
			this.ShowCategoryLabel = new System.Windows.Forms.Label();
			this.ModifiedDateTimeLabel = new System.Windows.Forms.Label();
			this.ModifiedLabel = new System.Windows.Forms.Label();
			this.CreatedDateTimeLabel = new System.Windows.Forms.Label();
			this.CreatedLabel = new System.Windows.Forms.Label();
			this.NoteCategoryLabel = new System.Windows.Forms.Label();
			this.CategoryLabelFixed = new System.Windows.Forms.Label();
			this.NoteTextBox = new System.Windows.Forms.TextBox();
			this.NoteTitleLabel = new System.Windows.Forms.Label();
			this.MainMenu.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.MainSplitContainer)).BeginInit();
			this.MainSplitContainer.Panel1.SuspendLayout();
			this.MainSplitContainer.Panel2.SuspendLayout();
			this.MainSplitContainer.SuspendLayout();
			this.SuspendLayout();
			// 
			// MainMenu
			// 
			this.MainMenu.BackColor = System.Drawing.SystemColors.Menu;
			this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
			this.MainMenu.Location = new System.Drawing.Point(0, 0);
			this.MainMenu.Name = "MainMenu";
			this.MainMenu.Size = new System.Drawing.Size(634, 24);
			this.MainMenu.TabIndex = 0;
			this.MainMenu.Text = "menuStrip";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
			this.exitToolStripMenuItem.Text = "Exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// editToolStripMenuItem
			// 
			this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNoteToolStripMenuItem,
            this.editNoteToolStripMenuItem,
            this.deleteNoteToolStripMenuItem});
			this.editToolStripMenuItem.Name = "editToolStripMenuItem";
			this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
			this.editToolStripMenuItem.Text = "Edit";
			// 
			// addNoteToolStripMenuItem
			// 
			this.addNoteToolStripMenuItem.Name = "addNoteToolStripMenuItem";
			this.addNoteToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
			this.addNoteToolStripMenuItem.Text = "Add Note";
			this.addNoteToolStripMenuItem.Click += new System.EventHandler(this.addNoteToolStripMenuItem_Click);
			// 
			// editNoteToolStripMenuItem
			// 
			this.editNoteToolStripMenuItem.Name = "editNoteToolStripMenuItem";
			this.editNoteToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
			this.editNoteToolStripMenuItem.Text = "Edit Note";
			this.editNoteToolStripMenuItem.Click += new System.EventHandler(this.editNoteToolStripMenuItem_Click);
			// 
			// deleteNoteToolStripMenuItem
			// 
			this.deleteNoteToolStripMenuItem.Name = "deleteNoteToolStripMenuItem";
			this.deleteNoteToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
			this.deleteNoteToolStripMenuItem.Text = "Delete Note";
			this.deleteNoteToolStripMenuItem.Click += new System.EventHandler(this.deleteNoteToolStripMenuItem_Click);
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.helpToolStripMenuItem.Text = "Help";
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
			this.aboutToolStripMenuItem.Text = "About";
			this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
			// 
			// MainSplitContainer
			// 
			this.MainSplitContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.MainSplitContainer.BackColor = System.Drawing.SystemColors.Menu;
			this.MainSplitContainer.Location = new System.Drawing.Point(0, 24);
			this.MainSplitContainer.Name = "MainSplitContainer";
			// 
			// MainSplitContainer.Panel1
			// 
			this.MainSplitContainer.Panel1.BackColor = System.Drawing.SystemColors.Window;
			this.MainSplitContainer.Panel1.Controls.Add(this.CountNotesLabel);
			this.MainSplitContainer.Panel1.Controls.Add(this.NoteCountLabel);
			this.MainSplitContainer.Panel1.Controls.Add(this.DeleteNoteButton);
			this.MainSplitContainer.Panel1.Controls.Add(this.EditNoteButton);
			this.MainSplitContainer.Panel1.Controls.Add(this.AddNoteButton);
			this.MainSplitContainer.Panel1.Controls.Add(this.NotesListBox);
			this.MainSplitContainer.Panel1.Controls.Add(this.CategoryComboBox);
			this.MainSplitContainer.Panel1.Controls.Add(this.ShowCategoryLabel);
			this.MainSplitContainer.Panel1.Padding = new System.Windows.Forms.Padding(6);
			this.MainSplitContainer.Panel1MinSize = 180;
			// 
			// MainSplitContainer.Panel2
			// 
			this.MainSplitContainer.Panel2.BackColor = System.Drawing.SystemColors.Window;
			this.MainSplitContainer.Panel2.Controls.Add(this.ModifiedDateTimeLabel);
			this.MainSplitContainer.Panel2.Controls.Add(this.ModifiedLabel);
			this.MainSplitContainer.Panel2.Controls.Add(this.CreatedDateTimeLabel);
			this.MainSplitContainer.Panel2.Controls.Add(this.CreatedLabel);
			this.MainSplitContainer.Panel2.Controls.Add(this.NoteCategoryLabel);
			this.MainSplitContainer.Panel2.Controls.Add(this.CategoryLabelFixed);
			this.MainSplitContainer.Panel2.Controls.Add(this.NoteTextBox);
			this.MainSplitContainer.Panel2.Controls.Add(this.NoteTitleLabel);
			this.MainSplitContainer.Panel2MinSize = 400;
			this.MainSplitContainer.Size = new System.Drawing.Size(634, 426);
			this.MainSplitContainer.SplitterDistance = 197;
			this.MainSplitContainer.TabIndex = 1;
			// 
			// CountNotesLabel
			// 
			this.CountNotesLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.CountNotesLabel.AutoSize = true;
			this.CountNotesLabel.Location = new System.Drawing.Point(6, 392);
			this.CountNotesLabel.Name = "CountNotesLabel";
			this.CountNotesLabel.Size = new System.Drawing.Size(42, 13);
			this.CountNotesLabel.TabIndex = 7;
			this.CountNotesLabel.Text = "number";
			// 
			// NoteCountLabel
			// 
			this.NoteCountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.NoteCountLabel.AutoSize = true;
			this.NoteCountLabel.Location = new System.Drawing.Point(6, 373);
			this.NoteCountLabel.Name = "NoteCountLabel";
			this.NoteCountLabel.Size = new System.Drawing.Size(38, 13);
			this.NoteCountLabel.TabIndex = 6;
			this.NoteCountLabel.Text = "Notes:";
			// 
			// DeleteNoteButton
			// 
			this.DeleteNoteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.DeleteNoteButton.AutoSize = true;
			this.DeleteNoteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.DeleteNoteButton.FlatAppearance.BorderSize = 0;
			this.DeleteNoteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.DeleteNoteButton.Image = ((System.Drawing.Image)(resources.GetObject("DeleteNoteButton.Image")));
			this.DeleteNoteButton.Location = new System.Drawing.Point(154, 364);
			this.DeleteNoteButton.MinimumSize = new System.Drawing.Size(32, 32);
			this.DeleteNoteButton.Name = "DeleteNoteButton";
			this.DeleteNoteButton.Size = new System.Drawing.Size(34, 41);
			this.DeleteNoteButton.TabIndex = 5;
			this.DeleteNoteButton.UseVisualStyleBackColor = true;
			this.DeleteNoteButton.Click += new System.EventHandler(this.DeleteNoteButton_Click);
			// 
			// EditNoteButton
			// 
			this.EditNoteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.EditNoteButton.AutoSize = true;
			this.EditNoteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.EditNoteButton.FlatAppearance.BorderSize = 0;
			this.EditNoteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.EditNoteButton.Image = ((System.Drawing.Image)(resources.GetObject("EditNoteButton.Image")));
			this.EditNoteButton.Location = new System.Drawing.Point(98, 364);
			this.EditNoteButton.MinimumSize = new System.Drawing.Size(32, 32);
			this.EditNoteButton.Name = "EditNoteButton";
			this.EditNoteButton.Size = new System.Drawing.Size(34, 41);
			this.EditNoteButton.TabIndex = 4;
			this.EditNoteButton.UseVisualStyleBackColor = true;
			this.EditNoteButton.Click += new System.EventHandler(this.EditNoteButton_Click);
			// 
			// AddNoteButton
			// 
			this.AddNoteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.AddNoteButton.AutoSize = true;
			this.AddNoteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.AddNoteButton.FlatAppearance.BorderSize = 0;
			this.AddNoteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.AddNoteButton.Image = ((System.Drawing.Image)(resources.GetObject("AddNoteButton.Image")));
			this.AddNoteButton.Location = new System.Drawing.Point(56, 364);
			this.AddNoteButton.MinimumSize = new System.Drawing.Size(32, 32);
			this.AddNoteButton.Name = "AddNoteButton";
			this.AddNoteButton.Size = new System.Drawing.Size(36, 41);
			this.AddNoteButton.TabIndex = 3;
			this.AddNoteButton.UseVisualStyleBackColor = true;
			this.AddNoteButton.Click += new System.EventHandler(this.AddNoteButton_Click);
			// 
			// NotesListBox
			// 
			this.NotesListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.NotesListBox.BackColor = System.Drawing.SystemColors.Window;
			this.NotesListBox.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.NotesListBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.NotesListBox.FormattingEnabled = true;
			this.NotesListBox.ItemHeight = 14;
			this.NotesListBox.Location = new System.Drawing.Point(9, 45);
			this.NotesListBox.MinimumSize = new System.Drawing.Size(80, 80);
			this.NotesListBox.Name = "NotesListBox";
			this.NotesListBox.Size = new System.Drawing.Size(181, 298);
			this.NotesListBox.TabIndex = 2;
			this.NotesListBox.SelectedIndexChanged += new System.EventHandler(this.NotesListBox_SelectedIndexChanged);
			// 
			// CategoryComboBox
			// 
			this.CategoryComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.CategoryComboBox.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.CategoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.CategoryComboBox.ForeColor = System.Drawing.SystemColors.WindowText;
			this.CategoryComboBox.FormattingEnabled = true;
			this.CategoryComboBox.Location = new System.Drawing.Point(67, 14);
			this.CategoryComboBox.Name = "CategoryComboBox";
			this.CategoryComboBox.Size = new System.Drawing.Size(123, 21);
			this.CategoryComboBox.TabIndex = 1;
			this.CategoryComboBox.SelectedIndexChanged += new System.EventHandler(this.CategoryComboBox_SelectedIndexChanged);
			// 
			// ShowCategoryLabel
			// 
			this.ShowCategoryLabel.AutoSize = true;
			this.ShowCategoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.ShowCategoryLabel.Location = new System.Drawing.Point(6, 15);
			this.ShowCategoryLabel.Name = "ShowCategoryLabel";
			this.ShowCategoryLabel.Size = new System.Drawing.Size(58, 15);
			this.ShowCategoryLabel.TabIndex = 0;
			this.ShowCategoryLabel.Text = "Category:";
			// 
			// ModifiedDateTimeLabel
			// 
			this.ModifiedDateTimeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ModifiedDateTimeLabel.AutoSize = true;
			this.ModifiedDateTimeLabel.Location = new System.Drawing.Point(314, 64);
			this.ModifiedDateTimeLabel.Name = "ModifiedDateTimeLabel";
			this.ModifiedDateTimeLabel.Size = new System.Drawing.Size(93, 13);
			this.ModifiedDateTimeLabel.TabIndex = 7;
			this.ModifiedDateTimeLabel.Text = "ModifiedDateTime";
			// 
			// ModifiedLabel
			// 
			this.ModifiedLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ModifiedLabel.AutoSize = true;
			this.ModifiedLabel.Location = new System.Drawing.Point(258, 64);
			this.ModifiedLabel.Name = "ModifiedLabel";
			this.ModifiedLabel.Size = new System.Drawing.Size(50, 13);
			this.ModifiedLabel.TabIndex = 6;
			this.ModifiedLabel.Text = "Modified:";
			// 
			// CreatedDateTimeLabel
			// 
			this.CreatedDateTimeLabel.AutoSize = true;
			this.CreatedDateTimeLabel.Location = new System.Drawing.Point(314, 47);
			this.CreatedDateTimeLabel.Name = "CreatedDateTimeLabel";
			this.CreatedDateTimeLabel.Size = new System.Drawing.Size(90, 13);
			this.CreatedDateTimeLabel.TabIndex = 5;
			this.CreatedDateTimeLabel.Text = "CreatedDateTime";
			// 
			// CreatedLabel
			// 
			this.CreatedLabel.AutoSize = true;
			this.CreatedLabel.Location = new System.Drawing.Point(261, 47);
			this.CreatedLabel.Name = "CreatedLabel";
			this.CreatedLabel.Size = new System.Drawing.Size(47, 13);
			this.CreatedLabel.TabIndex = 4;
			this.CreatedLabel.Text = "Created:";
			// 
			// NoteCategoryLabel
			// 
			this.NoteCategoryLabel.AutoSize = true;
			this.NoteCategoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.NoteCategoryLabel.Location = new System.Drawing.Point(66, 45);
			this.NoteCategoryLabel.Name = "NoteCategoryLabel";
			this.NoteCategoryLabel.Size = new System.Drawing.Size(81, 15);
			this.NoteCategoryLabel.TabIndex = 3;
			this.NoteCategoryLabel.Text = "NoteCategory";
			// 
			// CategoryLabelFixed
			// 
			this.CategoryLabelFixed.AutoSize = true;
			this.CategoryLabelFixed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.CategoryLabelFixed.Location = new System.Drawing.Point(4, 45);
			this.CategoryLabelFixed.Name = "CategoryLabelFixed";
			this.CategoryLabelFixed.Size = new System.Drawing.Size(58, 15);
			this.CategoryLabelFixed.TabIndex = 2;
			this.CategoryLabelFixed.Text = "Category:";
			// 
			// NoteTextBox
			// 
			this.NoteTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.NoteTextBox.BackColor = System.Drawing.SystemColors.Window;
			this.NoteTextBox.ForeColor = System.Drawing.SystemColors.InfoText;
			this.NoteTextBox.Location = new System.Drawing.Point(7, 80);
			this.NoteTextBox.MinimumSize = new System.Drawing.Size(250, 80);
			this.NoteTextBox.Multiline = true;
			this.NoteTextBox.Name = "NoteTextBox";
			this.NoteTextBox.ReadOnly = true;
			this.NoteTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.NoteTextBox.Size = new System.Drawing.Size(414, 325);
			this.NoteTextBox.TabIndex = 1;
			// 
			// NoteTitleLabel
			// 
			this.NoteTitleLabel.AutoSize = true;
			this.NoteTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.NoteTitleLabel.Location = new System.Drawing.Point(3, 15);
			this.NoteTitleLabel.Name = "NoteTitleLabel";
			this.NoteTitleLabel.Size = new System.Drawing.Size(86, 20);
			this.NoteTitleLabel.TabIndex = 0;
			this.NoteTitleLabel.Text = "Note Title";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.ClientSize = new System.Drawing.Size(634, 441);
			this.Controls.Add(this.MainSplitContainer);
			this.Controls.Add(this.MainMenu);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.MainMenu;
			this.MinimumSize = new System.Drawing.Size(600, 350);
			this.Name = "MainForm";
			this.Text = "NoteApp";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
			this.MainMenu.ResumeLayout(false);
			this.MainMenu.PerformLayout();
			this.MainSplitContainer.Panel1.ResumeLayout(false);
			this.MainSplitContainer.Panel1.PerformLayout();
			this.MainSplitContainer.Panel2.ResumeLayout(false);
			this.MainSplitContainer.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.MainSplitContainer)).EndInit();
			this.MainSplitContainer.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip MainMenu;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem addNoteToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem editNoteToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem deleteNoteToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.SplitContainer MainSplitContainer;
		private System.Windows.Forms.Label ShowCategoryLabel;
		private System.Windows.Forms.ListBox NotesListBox;
		private System.Windows.Forms.ComboBox CategoryComboBox;
		private System.Windows.Forms.Label NoteTitleLabel;
		private System.Windows.Forms.TextBox NoteTextBox;
		private System.Windows.Forms.Label CategoryLabelFixed;
		private System.Windows.Forms.Label CreatedDateTimeLabel;
		private System.Windows.Forms.Label CreatedLabel;
		private System.Windows.Forms.Label NoteCategoryLabel;
		private System.Windows.Forms.Label ModifiedDateTimeLabel;
		private System.Windows.Forms.Label ModifiedLabel;
		private System.Windows.Forms.Button DeleteNoteButton;
		private System.Windows.Forms.Button EditNoteButton;
		private System.Windows.Forms.Button AddNoteButton;
		private System.Windows.Forms.Label CountNotesLabel;
		private System.Windows.Forms.Label NoteCountLabel;
	}
}

