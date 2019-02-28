namespace LAB2_CORE
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }

        public Category(int id, string name)
        {
            CategoryID = id;
            CategoryName = name;
        }
    }
}
