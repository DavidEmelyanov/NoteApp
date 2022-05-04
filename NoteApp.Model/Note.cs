using System;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;
using DateTime = System.DateTime;

namespace NoteApp.Model
{
	/// <summary>
	/// Класс, представляющий заметку.
	/// </summary>
	public class Note : ICloneable // 15
	{
		/// <summary>
		/// Заголовок заметки
		/// </summary>
		private string _name;
		/// <summary>
		/// Содержимое заметки
		/// </summary>
		private string _content;
		/// <summary>
		/// Категория заметки
		/// </summary>
		private NoteCategory _category;
		/// <summary>
		/// Дата создания заметки
		/// </summary>
		private DateTime _dateOfCreation;
		/// <summary>
		/// Дата последнего изменения
		/// </summary>
		private DateTime _dateOfLastEdit;

		public string Name // 4
		{
			get { return _name; } // 1
			set // 3
			{
				string pattern = @"^[\w*\s-0-9]*$";

				if (value == null)
				{
					throw new ArgumentException("Name value is instance of null type");
				}

				value = value.Trim();

				if (!Regex.IsMatch(value, pattern))
				{
					_name = "No title";
					return;
				}
				_name = value;
			}
		}

		public string Content // 3
		{
			get { return _content; }
			set
			{
				if (value == null)
				{
					throw new ArgumentException("Content value is instance of null type");
				}
				_content = value.Trim();
			}
		}

		public NoteCategory Category // 2
		{
			get { return _category; }
			set { _category = value; }
		}

		public DateTime DateOfCreation // 2
		{
			get { return _dateOfCreation; }
			set { _dateOfCreation = value; }
		}

		public DateTime DateOfLastEdit // 2
		{
			get { return _dateOfLastEdit; }
			set { _dateOfLastEdit = value; }
		}

		/// <summary>
		/// Конструктор, который устанавливает значения полей заметки.
		/// </summary>
		/// <param name="name"></param>
		/// <param name="content"></param>
		/// <param name="category"></param>
		public Note(string name, string content, NoteCategory category) // 1
		{
			Name = name;
			Content = content;
			Category = category;
			DateOfCreation = DateTime.Now;
			DateOfLastEdit = DateTime.Now;
		}

		public object Clone() // 1
		{
			return this.MemberwiseClone();
		}
	}
}

