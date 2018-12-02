using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.LINQToSql
{
    class Program
    {
        static void Main(string[] args)
        {
            string connStr = @"Data Source=server2;Initial Catalog=ttttttttt;User ID=student;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            /*DataContext ctx = new DataContext(connStr);
            ctx.CreateDatabase();
            var users = ctx.GetTable<User>();

            // Редактирование данных
            //var u = users.First();
            //u.Firstname = "It`s new firstname";

            //Вставка данных
            users.InsertOnSubmit(new User { Firstname = "Kolya", Lastname = "Nikiforov" });

            //Удаление данных
            users.DeleteOnSubmit(users.Where(user => user.Id == 1002).FirstOrDefault());

            ctx.SubmitChanges();

            Console.WriteLine("Success");*/

            Console.Read();
        }
    }
}
