using JustPoteito.Models;

namespace JustPoteito
{
    public class Endpoints
    {
        public static string Login() 
        {
            return $"http://localhost:8080/api/auth/login";
        }
        public static string GetUsers() 
        {
            return $"http://localhost:8080/api/auth/users";
        }

        public static string GetUserById(int id)
        {
            return $"http://localhost:8080/api/auth/users/{id}";
        }

        public static string CreateUser()
        {
            return "http://localhost:8080/api/notoken/createUser";
        }

        public static string UpdateUser(int userId)
        {
            return $"http://localhost:8080/api/notoken/update/{userId}";
        }

        public static string DeleteUser(int userId)
        {
            return $"http://localhost:8080/api/notoken/delete/{userId}";
        }
    }
}