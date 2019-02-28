namespace LAB2_CORE
{
    public class Order
    {
        public int OrderID { get; set; }
        public string ShipName { get; set; }
        public string ShipAddress { get; set; }

        public Order(int orID, string shipName, string shipAddress)
        {
            OrderID = orID;
            ShipName = shipName;
            ShipAddress = shipAddress;
        }
    }
}
