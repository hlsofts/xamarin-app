namespace MossPrice.Models
{
    public class Models
    {

    }

    public class Account
    {
        public string username { get; set; }
        public string password { get; set; }
        public Account()
        {

        }
    }

    public class Customer
    {
        public int Id { get; set; }
        public string CustomerCode { get; set; }
        public string CustomerName { get; set; }
        public string Tel1 { get; set; }
        public string Address { get; set; }
        public Customer()
        {

        }
    }

    public interface IToast
    {
        void show(string message);
    }
}
