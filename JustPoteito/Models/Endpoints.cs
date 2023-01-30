using JustPoteito.Models;

namespace JustPoteito
{
    public class Endpoints
    { 
        public static string GetUsers() 
        {
            return $"http://localhost:8080/api/users";
        }

        public static string GetUserById(int id)
        {
            return $"http://localhost:8080/api/users/{id}";
        }

        public static string CreateUser()
        {
            return "http://localhost:8080/api/post";
        }

        public static string UpdateUser(int userId)
        {
            //TODO: pendientito 
            return $"http://localhost:8080/api/users/{userId}";
        }

        public static string DeleteUser(int userId)
        {
            return $"http://localhost:8080/api/delete/{userId}";
        }
    }
}