using ScaffoldDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ScaffoldDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            using var db = new demoday3Context();
            //List<User> users = db.Users.ToList();

            //var all = (from d in db.Users select d).ToList();

            //foreach(var item in users)
            //{
            //    Console.WriteLine(item.FirstName);
            //}

            //Console.WriteLine();
            //users = db.Users.Where(x => x.FirstName == "Jim").ToList();
            //all = (from d in db.Users where d.FirstName == "Jim" select d).ToList();

            //foreach (var item in all)
            //{
            //    Console.WriteLine(item.FirstName);
            //}

            //Console.WriteLine();
            //var kalle = db.Users.Where(n => n.FirstName == "Kalle" && n.LastName == "Eriksson").ToList();
            //kalle = db.Users.Where(n => n.FirstName == "Kalle").Where(n => n.LastName =="Eriksson").ToList();
            //foreach (var item in kalle)
            //{
            //    Console.WriteLine(item.FirstName + " " +item.LastName);
            //}

            ////Single för att precisera till att hämta just en träff
            //User singleUser = db.Users.Single(n => n.FirstName == "Kalle" && n.LastName == "Eriksson");
            ////Hämtar första eller null (förhindrar krasch)
            //singleUser = db.Users.Where(n => n.FirstName == "Kalle" && n.LastName == "Eriksson").FirstOrDefault();

            //// HÄMTA AnvändarID för en användare
            //int userId = (from i in db.Users where i.FirstName == "Kalle" select i.Id).FirstOrDefault();
            //Console.WriteLine(userId);
            //userId = db.Users.Single(x => x.FirstName == "Kalle").Id;
            //Console.WriteLine(userId);

            ////ALLA ANVÄNDARE FRÅN EN VISS STAD
            //var cities = db.Cities.ToList();
            //var allFromSthlm = db.Addresses.Where(a => a.City.CityName == "Stockholm").ToList();
            //foreach (var item in allFromSthlm)
            //{
            //    foreach (var user in item.Users)
            //    {
            //        Console.WriteLine(user.FirstName);
            //    }
            //}

            //List<User> users1 = db.Users.Where(c => c.AddressId == db.Cities.Single(x=> x.CityName=="Stockholm").Id).ToList();
            //foreach (var item in users1)
            //{
            //    Console.WriteLine(item.FirstName);
            //}


            ////ALLA ADRESSER I EN VISS STAD
            //var allStreetsInSTHML = db.Addresses.Where(a => a.City.CityName == "Stockholm").ToList();
            //Address a = db.Addresses.FirstOrDefault();

            ////KOLLA OM VÄRDE FINNS I DB
            //bool sthlmInDB = db.Cities.Any(a => a.CityName == "Stockholm");

            //var user2 = db.Users.Where(x => x.AddressId == db.Addresses.Where(a => a.City.CityName == "Stockholm").FirstOrDefault().Id).ToList();
            //foreach (var item in user2)
            //{
            //    Console.WriteLine(item.FirstName);
            //}
            //Console.WriteLine();


            ////GROUP BY
            //List<Address> allCities = new();

            //var citiesGroupByCityId = db.Addresses.ToList().GroupBy(c => c.CityId).Where(a =>a.Count()>2);
            //foreach (var item in citiesGroupByCityId)
            //{
            //    foreach (var i in item)
            //    {
            //        Console.WriteLine(i.StreetAddress);
            //        allCities.Add(i);
            //    }
            //}
            //Console.WriteLine();

            //var all1 = db.Users.ToList();
            //var allNames = all1.GroupBy(n => n.FirstName);

            //foreach (var item in allNames)
            //{
            //    Console.WriteLine("Key: " + item.Key);
            //    foreach (var i in item)
            //    {
            //        Console.WriteLine(i.FirstName);
            //    }
            //}


            //ORDER BY
            var allCities = db.Cities.OrderBy(c => c.CityName).ToList();
            foreach (var item in allCities)
            {
                Console.WriteLine(item.CityName);
            }

            Console.WriteLine();

            //ORDER BY DESCENDING
            allCities = db.Cities.OrderByDescending(c => c.CityName).ToList();
            foreach (var item in allCities)
            {
                Console.WriteLine(item.CityName);
            }

            //INSERT
            db.Cities.Add(new City { CityName = "Skövde" });
            db.SaveChanges();


            //UPDATE
            City toEdit = db.Cities.Where(a => a.CityName == "Skövde").FirstOrDefault();
            toEdit.CityName = "Orust";
            db.SaveChanges();


            ////SELECT COUNT(*) FROM users;
            //Console.WriteLine(db.Users.Count());


            //   /*var allusers = db.Users.ToList();
            //foreach (var item in allusers)
            //{
            //    Console.WriteLine(item.FirstName);
            //}*/

            ////Hämta en specifik användare
            //var currentUser = db.Users.Single(x => x.Id == 1);
            //Console.WriteLine(currentUser.FirstName);

            ////Ändra en användare
            //currentUser.FirstName = "Johan";

            ////Spara ändringar till databasen
            //db.SaveChanges();

            //// hämta alla användare som matchar villkor
            //List<User> selectedUsers = db.Users.Where(x => x.Id > 2).ToList();

            //// Lägg till en användare
            //db.Users.Add(new User { FirstName = "Robin", LastName = "Kamo", AddressId = 2 });
            //db.SaveChanges();

        }
    }
}
