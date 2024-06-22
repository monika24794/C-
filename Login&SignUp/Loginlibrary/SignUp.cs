using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loginlibrary
{
    public class SignUp
    {
		private String _Firstname;

		public String FirstName
		{
			get { return _Firstname; }
			set { _Firstname = value; }
		}

        private String _lastname;

        public String lastName
        {
            get { return _lastname; }
            set { _lastname = value; }
        }
        private String _username;
        public String UserName
        {
            get { return _username; }
            set { _username = value; }
        }
        private String _password;

        public String Password
        {
            get { return _password; }
            set { _password = value; }
        }

        private String _email;

		public String Email
		{
			get { return _email; }
			set { _email = value; }
		}

	}
}
