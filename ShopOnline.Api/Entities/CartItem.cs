namespace ShopOnline.Api.Entities
{
    public class CartItem
    {
        public int Id { get; set; }

        //foreign key field
        public int CartId { get; set; }
        public int ProductId { get; set; }
        //quantity of a specific product in the cart
        public int Qty { get; set; }
    }
}
