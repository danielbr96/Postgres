using System;
using Tareabd.ModelsSQL;
using System.Linq;
 
namespace Tareabd
{
    class Program
    {
        static void Main(string[] args)
         {
             //insert
             var user = new Usuario()
  {
      Userid = "ECaporal",
     Nombre = "Erick Caporal",
      Pass = "5230"
  };
 
 using (var context = new appsContext())
  {
      context.Usuario.Add(user);
      context.SaveChanges();
  }

//delete
// var usr = new Usuarios()
// {
//     Id = 10
// };
 
// using (var context = new appsContext())
// {
//     context.Usuarios.Remove(usr);
//     context.SaveChanges();
// }

//update
// using (var context = new appsContext())
// {
//         // Retrieve entity by id
//         // Answer for question #1
//         var entity = context.Usuarios.FirstOrDefault(user => user.Id == 1);

//         // Validate entity is not null
//         if (entity != null)
//         {
//             // Answer for question #2

//             // Make changes on entity
        
//             entity.Nombre = "Briceño";

//             // Update entity in DbSet
//             context.Usuarios.Update(entity);

//             // Save changes in database
//             context.SaveChanges();
//         }
// }
           var dbContext = new appsContext();
        var usuarios = dbContext.Usuario.ToList();
       foreach(var c in usuarios)
   {
          System.Console.WriteLine($"id:{c.Id} userid:{c.Userid} nombre:{c.Nombre} pass:{c.Pass}  ");
   }



    }
        }
   
}