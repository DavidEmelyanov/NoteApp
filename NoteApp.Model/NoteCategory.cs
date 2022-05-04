using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteApp.Model
{
	/// <summary>
	/// Перечисление "Категория заметки"
	/// </summary>

	public enum NoteCategory
	{
		// Первый элемент - значение по умолчанию.
		Other,
		Work,
		Home, 
		HealthAndSport,
		People,
		Documents,
		Finance
	}
}
