using System.ComponentModel;

namespace Enumeration
{
    public enum EColors
    {
        [Description("Rouge")]
        RED,

        [Description("Bleu")]
        BLUE,

        [Description("Vert")]
        GREEEN,

        [Description("Jaune")]
        YELLOW,
    }
    internal class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public EColors Colors { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var users = new List<User>{
                new User{
                    FirstName = "John",
                    LastName = "Doe",
                    Colors = EColors.GREEEN
                },
                 new User{
                    FirstName = "Samir",
                    LastName = "Doe",
                    Colors = EColors.RED
                },

                   new User{
                    FirstName = "Luck",
                    LastName = "Doe",
                    Colors = EColors.RED
                },

                       new User{
                    FirstName = "Michelle",
                    LastName = "Doe",
                    Colors = EColors.BLUE
                },
            };


            foreach (var user in users)
                Console.WriteLine($"{user.FirstName} {user.LastName} {user.Colors}");

            Console.WriteLine("\n");


            var colorsCounts = users.GroupBy(u => u.Colors).Select(g => new { Couleur = g.Key, Count = g.Count() });
            
            Console.WriteLine("Nombre d'utilisateurs par couleur :");
            
            foreach (var item in colorsCounts)
                Console.WriteLine($"{item.Couleur} : {item.Count} utilisateurs");
        }
    }
}
