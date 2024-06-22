using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loginlibrary
{
    internal class Customer
    {
		private String _CustoName;

		public String CustomerName
		{
			get { return _CustoName; }
			set { _CustoName = value; }
		}
		private int _CustoId;

		public int CustomerId
		{
			get { return _CustoId; }
			set { _CustoId = value; }
		}

		private String _City;

		public String City

		{
			get { return _City; }
			set { _City = value; }
		}

	}
}
