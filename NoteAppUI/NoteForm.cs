using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NoteApp.Model;

namespace NoteAppUI
{
	public partial class NoteForm : Form
	{
		// Состояние формы создания/редактирования.
		// Если true - форма открыта для редактирования записи.
		// Если false - форма открыта для добавления записи.
		private Boolean _isEdit;

		public bool IsEdit
		{
			get { return _isEdit; }
			set { _isEdit = value; }
		}

		private Note _currentNote;

		public Note CurrentNote
		{
			get { return _currentNote; }
			set { _currentNote = value; }
		}

		public NoteCategory CurrentCategory;

		public NoteForm()
		{
			InitializeComponent();
			// Установка всплывающие подсказки.
			OkButtonToolTip.SetToolTip(OkButton, "Save changes to current note");
			CancelButtonToolTip.SetToolTip(CancelButton, "Exit without saving");
		}

		/// <summary>
		/// Метод создания заметки.
		/// </summary>
		public void AddNote()
		{
			IsEdit = false;

			TitleTextBox.Text = "No title";
			FillCategoryItems();
			CategoryComboBox.SelectedIndex = 0;
			DateTime dateTimeNow = DateTime.Now;
			CreatedDateTimeLabel.Text = dateTimeNow.ToString();
			SetModifiedDateTime(dateTimeNow, dateTimeNow);
		}

		/// <summary>
		/// Метод редактирования заметки.
		/// </summary>
		/// <param name="currentNote"></param>
		public void EditNote(Note currentNote)
		{
			IsEdit = true;

			CurrentNote = currentNote;
			// Заполнение данных.
			TitleTextBox.Text = CurrentNote.Name;
			FillCategoryItems();
			// Особый случай с категорией.
			if (CurrentNote.Category == NoteCategory.HealthAndSport)
			{
				CategoryComboBox.Text = "Health and Sport";
			}
			else
			{
				CategoryComboBox.Text = CurrentNote.Category.ToString();
			}
			CurrentNote.DateOfLastEdit = DateTime.Now;
			CreatedDateTimeLabel.Text = CurrentNote.DateOfCreation.ToString();
			SetModifiedDateTime(currentNote.DateOfLastEdit, currentNote.DateOfCreation);
			NoteTextBox.Text = CurrentNote.Content;
		}

		/// <summary>
		/// Заполняет категории заметки
		/// </summary>
		public void FillCategoryItems()
		{
			foreach (var item in Enum.GetValues(typeof(NoteCategory)))
			{
				CategoryComboBox.Items.Add(item);
			}
		}

		// Кнопки.
	#region Buttons

	private void OkButton_Click(object sender, EventArgs e)
		{
			if (TitleTextBox.Text == "" || NoteTextBox.Text == "")
			{
				//Ничего не делаем
				MessageBox.Show("Title and note content shouldn't be empty");
			}
			else
			{
				if (IsEdit) // условие, при котором уже созданая заметка редактируется
				{
					DialogResult result = MessageBox.Show("Save changes to current note?", "NoteApp",
						MessageBoxButtons.YesNo, MessageBoxIcon.Question);
					if (result == DialogResult.Yes) // подтверждение сохранения изменений
					{
						CurrentCategory = (NoteCategory) CategoryComboBox.SelectedIndex;
						var CurrentCreationDateTime = CurrentNote.DateOfCreation;
						CurrentNote.DateOfCreation = CurrentCreationDateTime;
						CurrentNote.Name = TitleTextBox.Text;
						CurrentNote.Content = NoteTextBox.Text;
						CurrentNote.Category = CurrentCategory;
					}
				}
				else
				{
					CurrentCategory = (NoteCategory) CategoryComboBox.SelectedIndex;
					CurrentNote = new Note(TitleTextBox.Text, NoteTextBox.Text, CurrentCategory);
				}

				DialogResult = DialogResult.OK;
				
			}
		}

		private void CancelButton_Click(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show("Do you want to exit without saving?", "NoteApp",
				MessageBoxButtons.YesNo, MessageBoxIcon.Question);

			if (result == DialogResult.Yes)
			{
				this.DialogResult = DialogResult.Cancel;
			}
		}

		#endregion

		/// <summary>
		/// Реализует скрытие даты редактирования у созданных заметок.
		/// </summary>
		/// <param name="dateOfLastEdit"></param>
		/// <param name="dateOfCreation"></param>
		private void SetModifiedDateTime(DateTime dateOfLastEdit, DateTime dateOfCreation)
		{
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
	}
}
