using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using BlazorClassLibrary.Collections.Interfaces;

namespace BlazorClassLibrary.Collections
{
    public class UserCollection : ILocalDataAccess
    {
        public List<User> Users { get; set; } = [];
        public List<User> UsersFromInDb { get; set; } = [];
       
        public void AddUser(User user)
        {
            Users.Add(user);
        }

        public void RemoveUser(User user)
        {
            Users.Remove(user);
		}
        public void SaveList()
        {
            string? groupJson = JsonSerializer.Serialize(Users, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText("List_Of_People_Save.json", groupJson);
        }
        public List<User> GetUsers()
        {
            if (File.Exists("List_Of_People_Save.json"))
            {
                var loadedJson = File.ReadAllText("List_Of_People_Save.json");
                Users = JsonSerializer.Deserialize<List<User>>(loadedJson) ?? [];
               
                    return Users;
            }
            else
            {
                return new (); 
            }
        }
        public List<User> GetUsersFromInternalDb()
        {
            return JsonSerializer.Deserialize<List<User>>(File.ReadAllText("Internal_Db_List.json")) ?? [];
        }
    }
}
