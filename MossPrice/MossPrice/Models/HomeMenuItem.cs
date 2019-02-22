namespace MossPrice.Models
{
    public enum MenuItemType
    {
        ListOrders = 0, DetailOrders = 1, About = 2, Exit = 3
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
