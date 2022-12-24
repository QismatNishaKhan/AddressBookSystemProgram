namespace AddressBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Contact contact = new Contact()
            {
                FirstName = "Qismat ",
                LastName = "Khan",
                Address = "Lucknow",
                City = "Sultanpur",
                State = "Uttar Pradesh",
                Zip = 28001,
                PhoneNumber = 8971919599,
                Email = "qismatnisha6243@gmail.com",
            };
            Console.WriteLine(contact.FirstName + "\n" + contact.LastName + "\n" + contact.Address + "\n" + contact.City + "\n" + contact.State + "\n" + contact.Zip + "\n" + contact.PhoneNumber + "\n" + contact.Email);
        }
    }
}