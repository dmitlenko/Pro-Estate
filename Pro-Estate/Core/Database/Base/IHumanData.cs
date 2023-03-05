using Pro_Estate.Core.Database.Tables;

namespace Pro_Estate.Core.Database.Base
{
	public interface IHumanData
	{
		 string Surname { get; set; }
		string Name { get; set; }
		string Patronymic { get; set; }

		string Email { get; set; }
		string Phone { get; set; }

		PassportData PassportData { get; set; }

		 string ToString();
	}
}