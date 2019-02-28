namespace LAB2_CORE
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int SupplierID { get; set; }
        public int CategoryID { get; set; }
        public double Price { get; set; }
        public bool Discontinue { get; set; }

        public Product(int ProID, string ProName, int SupID, int CatID, double Pri, bool disCon)
        {
            ProductID = ProID;
            ProductName = ProName;
            SupplierID = SupID;
            CategoryID = CatID;
            Price = Pri;
            Discontinue = disCon;
        }
    }
}
