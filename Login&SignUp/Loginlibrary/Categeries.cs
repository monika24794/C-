using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loginlibrary
{
    public class Categeries
    {
		private int _catid;

		public int CategeryId
		{
			get { return _catid; }
			set { _catid = value; }
		}
		private int _catName;

		public int CatName
		{
			get { return _catName; }
			set { _catName = value; }
		}


	}
}
