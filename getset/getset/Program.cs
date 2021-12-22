using System;

namespace getset
{
    class Program
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public static void Main(string[] args)
        {
            Program obj = new Program();
            Console.WriteLine("Please Enter CustomerID");
            obj.Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter Name");
            obj.Name = Console.ReadLine();
            Console.WriteLine("Please Enter Phone");
            obj.Phone = Console.ReadLine();
            Console.WriteLine("Please Enter Gender");
            obj.Gender = Console.ReadLine();
            Console.WriteLine("Please Enter Address");
            obj.Address = Console.ReadLine();
           string toprint= "CustomerID=123, Name=Rabin Giri, Phone=9812345678, Gender=Male, Address=Tinkune";
            string a = "CustomeID=" + obj.Id + ", Name= " + obj.Name;
            string b = 
        }
    }
}
