using System;

namespace GameProject
{
    class Program
    {
        //Not: Önce varlığı daha sonra operasyonları oluştur.
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());

            gamerManager.Add(new Gamer { Id=1, BirthYear=1984, FirstName="Engin", LastName="Demiroğ", IdentityNumber=12345});

        }
    }
}
