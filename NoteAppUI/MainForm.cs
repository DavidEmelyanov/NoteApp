using System;
using System.Windows.Forms;
using System.Collections.Generic;
using NoteApp.Model;


namespace NoteAppUI
{
	public partial class MainForm : Form
	{
		/// <summary>
		/// Хранит номер текущей заметки.
		/// </summary>
		private Note _selectedNote;
		public Note SelectedNote { get; set; }

		/// <summary>
		/// Хранит экземпляр текущего проекта.
		/// </summary>
		private ProjectData _currentProjectData;

		/// <summary>
		/// Хранит текущий проект.
		/// </summary>
		public ProjectData CurrentProjectData
		{
			get { return _currentProjectData; }
			set { _currentProjectData = value; }
		}

		public MainForm()
		{
			InitializeComponent();
			// Заполнение комбобокса с категориями.
			FillCategoryItems();
			// Задаем клавишу быстрого доступа для удаления.
			deleteNoteToolStripMenuItem.ShortcutKeys = Keys.Delete;

			// Пытаемся загрузить данные из файла. Если нет - создаём новый файл.
			_currentProjectData = ProjectManager.LoadFromFile();

			UpdateNotesList();

			// Снятие выделения заметки и отображение всех заметок.
			NotesListBox.SelectedIndex = -1;
			CategoryComboBox.SelectedIndex = 0;

			// Защита кнопок от нажатия при невыбранной заметке.
			EditNoteButton.Enabled = false;
			DeleteNoteButton.Enabled = false;
		}

		// Обновление листа заметок.
		private void UpdateNotesList()
		{
			// Сохраняемся всякий раз, когда обновляем данные.
			ProjectManager.SaveToFile(_currentProjectData);

			// Перезагружаем проект.
			_currentProjectData = ProjectManager.LoadFromFile();

			// Обновляем данные коллекции.
			NotesListBox.DataSource = null;
			NotesListBox.DisplayMember = "Name";
			SelectedNote = (Note)NotesListBox.SelectedItem;
			if (CategoryComboBox.SelectedIndex == 0)
			{
				NotesListBox.DataSource = CurrentProjectData.OrderListByEditDate();
			}
			else if (CategoryComboBox.SelectedIndex >= 1)
			{
				NotesListBox.DataSource = _currentProjectData.OrderListByEditDate((NoteCategory)CategoryComboBox.SelectedIndex - 1);
			}

			if (CategoryComboBox.SelectedIndex < 0)
			{
				EditNoteButton.Enabled = false;
			}

			if (NotesListBox.Items.Count != 0)
			{
				NotesListBox.SelectedIndex = 0;
			}

			// Снятие выделения заметки.
			NotesListBox.SelectedIndex = -1;

			// Защита кнопок от нажатия при невыбранной заметке.
			EditNoteButton.Enabled = false;
			DeleteNoteButton.Enabled = false;

			// Обновление счётчика заметок.
			CountNotesLabel.Text = NotesListBox.Items.Count.ToString();
		}

		/// <summary>
		/// Заполнение комбобокса категориями
		/// </summary>
		public void FillCategoryItems()
		{
			CategoryComboBox.Items.Add("All");
			foreach (var item in Enum.GetValues(typeof(NoteCategory)))
			{
				CategoryComboBox.Items.Add(item);
			}
		}

		// Очистка полей после снятия выделения заметки
		private void ClearFields()
		{
			NoteTitleLabel.Text = "";
			NoteCategoryLabel.Text = "";
			CreatedDateTimeLabel.Text = "";
			ModifiedDateTimeLabel.Text = "";
			NoteTextBox.Text = "";
		}

		// События кнопок.
		#region Buttons

		private void AddNoteButton_Click(object sender, EventArgs e)
		{
			addNoteToolStripMenuItem_Click(sender, e);
		}

		private void EditNoteButton_Click(object sender, EventArgs e)
		{
			editNoteToolStripMenuItem_Click(sender, e);
		}

		private void DeleteNoteButton_Click(object sender, EventArgs e)
		{
			deleteNoteToolStripMenuItem_Click(sender, e);
		}

		#endregion

		// События кнопок меню.
		#region Menu

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			// Для сохранения список заметок должен быть не пустым
			if (CurrentProjectData.Notes.Count != 0)
			{
				ProjectManager.SaveToFile(CurrentProjectData);
				Application.Exit();
			}
			else
			{
				Application.Exit();
			}
		}

		private void addNoteToolStripMenuItem_Click(object sender, EventArgs e)
		{
			// Можно добавить только до 200 заметок
			if (CurrentProjectData.Notes.Count < 200)
			{
				NoteForm addAndEditNoteForm = new NoteForm();
				addAndEditNoteForm.AddNote();

				if (addAndEditNoteForm.ShowDialog() == DialogResult.OK)
				{
					CurrentProjectData.Notes.Add(addAndEditNoteForm.CurrentNote);
					UpdateNotesList();
				}
			}
		}

		private void editNoteToolStripMenuItem_Click(object sender, EventArgs e)
		{
			//CurrentNote = NotesListBox.SelectedIndex;
			SelectedNote = (Note)NotesListBox.SelectedItem;
			if (NotesListBox.SelectedIndex != -1)
			{
				NoteForm addAndEditNoteForm = new NoteForm();
				addAndEditNoteForm.EditNote(SelectedNote); //Передача выбранной заметки из листбокса в форму редактирования

				if (addAndEditNoteForm.ShowDialog() == DialogResult.OK)
				{
					if (CategoryComboBox.SelectedIndex == 0)
					{
						CurrentProjectData.CurrentNote = addAndEditNoteForm.CurrentNote;
						UpdateNotesList();
					}
					UpdateNotesList();
				}
			}
		}

		private void deleteNoteToolStripMenuItem_Click(object sender, EventArgs e)
		{
			//Должна быть выбрана заметка.
			if (NotesListBox.SelectedIndex != -1)
			{
				// При выборе заметки кнопки становятся доступны.
				EditNoteButton.Enabled = true;
				DeleteNoteButton.Enabled = true;

				DialogResult result = MessageBox.Show("Do you want to remove note?", "NoteApp", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

				if (result == DialogResult.Yes)
				{
					CurrentProjectData.Notes.Remove((Note)NotesListBox.SelectedItem);
					ClearFields();
					UpdateNotesList();

					DialogResult = DialogResult.Cancel;
				}

				if (result == DialogResult.No)
				{
					DialogResult = DialogResult.Cancel;
				}
			}

			// Блокировка кнопок после удаления заметки если нет выбранной заметки.
			if (NotesListBox.SelectedIndex == -1)
			{
				ClearFields();
				EditNoteButton.Enabled = false;
				DeleteNoteButton.Enabled = false;
			}
		}

		private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form aboutForm = new AboutForm();

			aboutForm.ShowDialog();
		}

		#endregion

		// Событие при смене выбора заметки.
		private void NotesListBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			var NoteId = NotesListBox.SelectedIndex;
			if (NoteId != -1)
			{
				// При выборе заметки кнопки доступны.
				EditNoteButton.Enabled = true;
				DeleteNoteButton.Enabled = true;
				if (CategoryComboBox.SelectedIndex < 0)
				{
					EditNoteButton.Enabled = false;
				}
				var note = (Note)NotesListBox.SelectedItem;
				NoteTitleLabel.Text = note.Name;
				NoteTextBox.Text = note.Content;
				if (note.Category == NoteCategory.HealthAndSport)
				{
					NoteCategoryLabel.Text = "Health and Sport";
				}
				else
				{
					NoteCategoryLabel.Text = note.Category.ToString();
				}
				CreatedDateTimeLabel.Text = note.DateOfCreation.ToString();
				SetModifiedDateTime();
			}
			else
			{
				ClearFields();
			}
		}

		private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			UpdateNotesList();
			NotesListBox.SelectedIndex = -1;
			ClearFields();
		}

		private void SetModifiedDateTime()
		{
			var note = (Note)NotesListBox.SelectedItem;
			DateTime dateOfLastEdit = note.DateOfLastEdit;
			DateTime dateOfCreation = note.DateOfCreation;

			if (dateOfCreation == dateOfLastEdit)
			{
				ModifiedDateTimeLabel.Visible = false;
				ModifiedLabel.Visible = false;
			}
			else
			{
				ModifiedDateTimeLabel.Visible = true;
				ModifiedLabel.Visible = true;
			}

			ModifiedDateTimeLabel.Text = dateOfLastEdit.ToString();
		}

		// Обработчик при закрытии окна программы.
		private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			DialogResult result = MessageBox.Show("Do you want to exit?", "NoteApp", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (result == DialogResult.Yes)
			{
				SelectedNote = (Note)NotesListBox.SelectedItem;
				// Для сохранения список заметок должен быть не пустым
				if (CurrentProjectData.Notes.Count != 0)
				{
					if (NotesListBox.SelectedIndex != -1)
					{
						SelectedNote = CurrentProjectData.CurrentNote;
					}

					if (NotesListBox.SelectedIndex == -1)
					{
						SelectedNote = null;
					}

					ProjectManager.SaveToFile(CurrentProjectData);
				}
			}

			if (result == DialogResult.No)
			{
				e.Cancel = true;
			}
		}
	}
}

