using System.Reflection.Metadata.Ecma335;
namespace ShoppingBussinessLogicLibrary
{
	public class CustomerBusinessLogic
	{
		private int _CustId;

		public int CustomerId
		{
			get { return _CustId; }
			set { _CustId = value; }
		}
		private String _custName;

		public String CustName
		{
			get { return _custName; }
			set { _custName = value; }
		}

	}
}
