using Pro_Estate.Core.Database.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro_Estate.Core.Database.Base
{
	public interface IEntryData<T>
		where T : class
	{
		bool CheckFields();
		T GetValue();
	}
}
