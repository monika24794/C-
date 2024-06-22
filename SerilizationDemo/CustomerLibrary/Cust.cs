namespace CustomerLibrary
{
    [Serializable]
    public class Cust
    {
        public int Custid { get; set; }
        public string CustName { get; set; }

        [NonSerialized]
       private string _pwd; 
        public string Password
        {
            get { return _pwd; }
            set { _pwd = value; }
        }


    }
}
