using Firebase.Database;
using Firebase.Database.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XamarinFirebase.Model;

namespace XamarinFirebase.Helper
{
    class FirebaseHelper2
    {
        FirebaseClient firebase = new FirebaseClient("https://xamarinfirebase2-13a48.firebaseio.com/");

        public async Task<List<Character>> GetAllCharacters()
        {

            return (await firebase
              .Child("Characters")
              .OnceAsync<Character>()).Select(item => new Character
              {
                  Name = item.Object.Name,
                  Email = item.Object.Email,
                  LastName = item.Object.LastName
              }).ToList();
        }

        public async Task AddCharacter(string name, string email, string lastName)
        {

            await firebase
              .Child("Characters")
              .PostAsync(new Character() { Email = email, Name = name, LastName = lastName });
        }

        public async Task<Character> GetEmail(string email)
        {
            var allPersons = await GetAllCharacters();
            await firebase
              .Child("Characters")
              .OnceAsync<Character>();
            return allPersons.Where(a => a.Email == email).FirstOrDefault();
        }

        public async Task<Character> GetEmail2(string email)
        {
            //var allPersons = (await firebase
            // .Child("Characters")
            // .OnceAsync<Character>())
            // .Where(item => item.Object.Email == "A-Email")
            // .Select(item => new Character
            // {
            //     Name = item.Object.Name,
            //     Email = item.Object.Email,
            //     LastName = item.Object.LastName
            // }).ToList();

            var allPersons = await firebase
             .Child("Characters")
             .Child("A-Email")
             .OnceSingleAsync<Character>();


            //await firebase
            //  .Child("Characters")
            //  .OnceAsync<Character>();
            //return allPersons.Where(a => a.Email == email).FirstOrDefault();
            return allPersons;

        }

        public async Task UpdatePerson(string email, string name, string lastName)
        {
            var toUpdatePerson = (await firebase
              .Child("Characters")
              .OnceAsync<Character>()).Where(a => a.Object.Email == email).FirstOrDefault();

            await firebase
              .Child("Characters")
              .Child(toUpdatePerson.Key)
              .PutAsync(new Character() { Email = email, Name = name, LastName = lastName });
        }

        public async Task DeletePerson(string email)
        {
            var toDeletePerson = (await firebase
              .Child("Characters")
              .OnceAsync<Character>()).Where(a => a.Object.Email == email).FirstOrDefault();
            await firebase.Child("Characters").Child(toDeletePerson.Key).DeleteAsync();

        }
    }
}
