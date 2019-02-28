namespace LAB2_CORE
{
    public class Supplier
    {
        public int SupplierID { get; set; }
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string Address { get; set; }

        public Supplier(int supID, string comName, string conName, string address)
        {
            SupplierID = supID;
            CompanyName = comName;
            conName = ContactName;
            Address = address;
        }
    }
}
