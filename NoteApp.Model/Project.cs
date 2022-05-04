using System.Collections.Generic;
using System.Linq;

namespace NoteApp.Model
{
	/// <summary>
	/// Класс, который хранит словарь всех созданных заметок.
	/// </summary>
	public class ProjectData
	{
		private List<Note> _notes = new List<Note>();

		public List<Note> Notes
		{
			get { return _notes; }
			set => _notes = value;
		}

		/// <summary>
		/// Хранит текущую заметку
		/// </summary>
		public Note CurrentNote { get; set; }

	}
}
