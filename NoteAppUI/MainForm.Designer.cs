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
			this.MainMenu = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.addNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.editNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.removeNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.DeleteNoteBtn = new System.Windows.Forms.Button();
			this.EditNoteBtn = new System.Windows.Forms.Button();
			this.AddNoteBtn = new System.Windows.Forms.Button();
			this.NotesListBox = new System.Windows.Forms.ListBox();
			this.NotesComboBox = new System.Windows.Forms.ComboBox();
			this.NoteCategory = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.ModifiedLabel = new System.Windows.Forms.Label();
			this.aa = new System.Windows.Forms.Label();
			this.CreatedLabel = new System.Windows.Forms.Label();
			this.ChosenCategoryLabel = new System.Windows.Forms.Label();
			this.CategoryLabelFixed = new System.Windows.Forms.Label();
			this.NoteTextBox = new System.Windows.Forms.TextBox();
			this.NoteTitle = new System.Windows.Forms.Label();
			this.MainMenu.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.SuspendLayout();
			// 
			// MainMenu
			// 
			this.MainMenu.BackColor = System.Drawing.SystemColors.Control;
			this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
			this.MainMenu.Location = new System.Drawing.Point(0, 0);
			this.MainMenu.Name = "MainMenu";
			this.MainMenu.Size = new System.Drawing.Size(634, 24);
			this.MainMenu.TabIndex = 0;
			this.MainMenu.Text = "menuStrip1";
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
			// 
			// editToolStripMenuItem
			// 
			this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNoteToolStripMenuItem,
            this.editNoteToolStripMenuItem,
            this.removeNoteToolStripMenuItem});
			this.editToolStripMenuItem.Name = "editToolStripMenuItem";
			this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
			this.editToolStripMenuItem.Text = "Edit";
			// 
			// addNoteToolStripMenuItem
			// 
			this.addNoteToolStripMenuItem.Name = "addNoteToolStripMenuItem";
			this.addNoteToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
			this.addNoteToolStripMenuItem.Text = "Add Note";
			// 
			// editNoteToolStripMenuItem
			// 
			this.editNoteToolStripMenuItem.Name = "editNoteToolStripMenuItem";
			this.editNoteToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
			this.editNoteToolStripMenuItem.Text = "Edit Note";
			// 
			// removeNoteToolStripMenuItem
			// 
			this.removeNoteToolStripMenuItem.Name = "removeNoteToolStripMenuItem";
			this.removeNoteToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
			this.removeNoteToolStripMenuItem.Text = "Remove Note";
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
			// 
			// splitContainer1
			// 
			this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.splitContainer1.Location = new System.Drawing.Point(0, 24);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.DeleteNoteBtn);
			this.splitContainer1.Panel1.Controls.Add(this.EditNoteBtn);
			this.splitContainer1.Panel1.Controls.Add(this.AddNoteBtn);
			this.splitContainer1.Panel1.Controls.Add(this.NotesListBox);
			this.splitContainer1.Panel1.Controls.Add(this.NotesComboBox);
			this.splitContainer1.Panel1.Controls.Add(this.NoteCategory);
			this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(6);
			this.splitContainer1.Panel1MinSize = 180;
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.label3);
			this.splitContainer1.Panel2.Controls.Add(this.ModifiedLabel);
			this.splitContainer1.Panel2.Controls.Add(this.aa);
			this.splitContainer1.Panel2.Controls.Add(this.CreatedLabel);
			this.splitContainer1.Panel2.Controls.Add(this.ChosenCategoryLabel);
			this.splitContainer1.Panel2.Controls.Add(this.CategoryLabelFixed);
			this.splitContainer1.Panel2.Controls.Add(this.NoteTextBox);
			this.splitContainer1.Panel2.Controls.Add(this.NoteTitle);
			this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
			this.splitContainer1.Panel2MinSize = 400;
			this.splitContainer1.Size = new System.Drawing.Size(634, 426);
			this.splitContainer1.SplitterDistance = 200;
			this.splitContainer1.TabIndex = 1;
			// 
			// DeleteNoteBtn
			// 
			this.DeleteNoteBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.DeleteNoteBtn.Location = new System.Drawing.Point(139, 380);
			this.DeleteNoteBtn.Name = "DeleteNoteBtn";
			this.DeleteNoteBtn.Size = new System.Drawing.Size(54, 23);
			this.DeleteNoteBtn.TabIndex = 5;
			this.DeleteNoteBtn.Text = "Delete";
			this.DeleteNoteBtn.UseVisualStyleBackColor = true;
			// 
			// EditNoteBtn
			// 
			this.EditNoteBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.EditNoteBtn.Location = new System.Drawing.Point(66, 380);
			this.EditNoteBtn.Name = "EditNoteBtn";
			this.EditNoteBtn.Size = new System.Drawing.Size(54, 23);
			this.EditNoteBtn.TabIndex = 4;
			this.EditNoteBtn.Text = "Edit";
			this.EditNoteBtn.UseVisualStyleBackColor = true;
			// 
			// AddNoteBtn
			// 
			this.AddNoteBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.AddNoteBtn.Location = new System.Drawing.Point(6, 380);
			this.AddNoteBtn.Name = "AddNoteBtn";
			this.AddNoteBtn.Size = new System.Drawing.Size(54, 23);
			this.AddNoteBtn.TabIndex = 3;
			this.AddNoteBtn.Text = "Add";
			this.AddNoteBtn.UseVisualStyleBackColor = true;
			// 
			// NotesListBox
			// 
			this.NotesListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.NotesListBox.FormattingEnabled = true;
			this.NotesListBox.Location = new System.Drawing.Point(6, 45);
			this.NotesListBox.MinimumSize = new System.Drawing.Size(80, 80);
			this.NotesListBox.Name = "NotesListBox";
			this.NotesListBox.Size = new System.Drawing.Size(187, 329);
			this.NotesListBox.TabIndex = 2;
			// 
			// NotesComboBox
			// 
			this.NotesComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.NotesComboBox.FormattingEnabled = true;
			this.NotesComboBox.Location = new System.Drawing.Point(67, 12);
			this.NotesComboBox.Name = "NotesComboBox";
			this.NotesComboBox.Size = new System.Drawing.Size(126, 21);
			this.NotesComboBox.TabIndex = 1;
			// 
			// NoteCategory
			// 
			this.NoteCategory.AutoSize = true;
			this.NoteCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.NoteCategory.Location = new System.Drawing.Point(3, 14);
			this.NoteCategory.Name = "NoteCategory";
			this.NoteCategory.Size = new System.Drawing.Size(58, 15);
			this.NoteCategory.TabIndex = 0;
			this.NoteCategory.Text = "Category:";
			this.NoteCategory.Click += new System.EventHandler(this.label1_Click);
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(289, 64);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(93, 13);
			this.label3.TabIndex = 7;
			this.label3.Text = "ModifiedDateTime";
			// 
			// ModifiedLabel
			// 
			this.ModifiedLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ModifiedLabel.AutoSize = true;
			this.ModifiedLabel.Location = new System.Drawing.Point(233, 64);
			this.ModifiedLabel.Name = "ModifiedLabel";
			this.ModifiedLabel.Size = new System.Drawing.Size(50, 13);
			this.ModifiedLabel.TabIndex = 6;
			this.ModifiedLabel.Text = "Modified:";
			// 
			// aa
			// 
			this.aa.AutoSize = true;
			this.aa.Location = new System.Drawing.Point(59, 64);
			this.aa.Name = "aa";
			this.aa.Size = new System.Drawing.Size(90, 13);
			this.aa.TabIndex = 5;
			this.aa.Text = "CreatedDateTime";
			// 
			// CreatedLabel
			// 
			this.CreatedLabel.AutoSize = true;
			this.CreatedLabel.Location = new System.Drawing.Point(6, 64);
			this.CreatedLabel.Name = "CreatedLabel";
			this.CreatedLabel.Size = new System.Drawing.Size(47, 13);
			this.CreatedLabel.TabIndex = 4;
			this.CreatedLabel.Text = "Created:";
			// 
			// ChosenCategoryLabel
			// 
			this.ChosenCategoryLabel.AutoSize = true;
			this.ChosenCategoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.ChosenCategoryLabel.Location = new System.Drawing.Point(70, 32);
			this.ChosenCategoryLabel.Name = "ChosenCategoryLabel";
			this.ChosenCategoryLabel.Size = new System.Drawing.Size(97, 15);
			this.ChosenCategoryLabel.TabIndex = 3;
			this.ChosenCategoryLabel.Text = "ChosenCategory";
			this.ChosenCategoryLabel.Click += new System.EventHandler(this.label1_Click_2);
			// 
			// CategoryLabelFixed
			// 
			this.CategoryLabelFixed.AutoSize = true;
			this.CategoryLabelFixed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.CategoryLabelFixed.Location = new System.Drawing.Point(6, 32);
			this.CategoryLabelFixed.Name = "CategoryLabelFixed";
			this.CategoryLabelFixed.Size = new System.Drawing.Size(58, 15);
			this.CategoryLabelFixed.TabIndex = 2;
			this.CategoryLabelFixed.Text = "Category:";
			this.CategoryLabelFixed.Click += new System.EventHandler(this.label1_Click_1);
			// 
			// NoteTextBox
			// 
			this.NoteTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.NoteTextBox.Location = new System.Drawing.Point(8, 80);
			this.NoteTextBox.MinimumSize = new System.Drawing.Size(250, 80);
			this.NoteTextBox.Multiline = true;
			this.NoteTextBox.Name = "NoteTextBox";
			this.NoteTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.NoteTextBox.Size = new System.Drawing.Size(410, 323);
			this.NoteTextBox.TabIndex = 1;
			// 
			// NoteTitle
			// 
			this.NoteTitle.AutoSize = true;
			this.NoteTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.NoteTitle.Location = new System.Drawing.Point(5, 12);
			this.NoteTitle.Name = "NoteTitle";
			this.NoteTitle.Size = new System.Drawing.Size(86, 20);
			this.NoteTitle.TabIndex = 0;
			this.NoteTitle.Text = "Note Title";
			this.NoteTitle.Click += new System.EventHandler(this.label2_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(634, 441);
			this.Controls.Add(this.splitContainer1);
			this.Controls.Add(this.MainMenu);
			this.MainMenuStrip = this.MainMenu;
			this.MinimumSize = new System.Drawing.Size(600, 350);
			this.Name = "MainForm";
			this.Text = "NoteApp";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.MainMenu.ResumeLayout(false);
			this.MainMenu.PerformLayout();
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel1.PerformLayout();
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
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
		private System.Windows.Forms.ToolStripMenuItem removeNoteToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.Label NoteCategory;
		private System.Windows.Forms.ListBox NotesListBox;
		private System.Windows.Forms.ComboBox NotesComboBox;
		private System.Windows.Forms.Label NoteTitle;
		private System.Windows.Forms.TextBox NoteTextBox;
		private System.Windows.Forms.Label CategoryLabelFixed;
		private System.Windows.Forms.Label aa;
		private System.Windows.Forms.Label CreatedLabel;
		private System.Windows.Forms.Label ChosenCategoryLabel;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label ModifiedLabel;
		private System.Windows.Forms.Button DeleteNoteBtn;
		private System.Windows.Forms.Button EditNoteBtn;
		private System.Windows.Forms.Button AddNoteBtn;
	}
}

