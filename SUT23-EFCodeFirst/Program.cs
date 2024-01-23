using SUT23_EFCodeFirst.Data;
using SUT23_EFCodeFirst.Models;

namespace SUT23_EFCodeFirst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using USerAppDbContex db = new USerAppDbContex();



            User test = new User()
            {
                 UserName = "Test",
                  Email = "test@test.se",
                   Phone = "076546767"

            };

            db.Users.Add(test);
            //db.SaveChanges();


            User Tobias = new User()
            {
                UserName = "Tobias",
                Email = "Tobias@qlok.se",
                Phone = "098743231"
            };

            db.Users.Add(Tobias);
           // db.SaveChanges();

        }
    }
}
