using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loginlibrary
{
    public class Product
    {
		private int _prodId;

		public int ProductId
		{
			get { return _prodId; }
			set { _prodId = value; }
		}
		private String _name;

		public String ProductName
		{
			get { return _name; }
			set { _name = value; }
		}

		private int _price;

		public int Price
		{
			get { return _price; }
			set { _price = value; }
		}


	}
}
