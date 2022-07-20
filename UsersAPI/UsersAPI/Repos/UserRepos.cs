using UsersAPI.Model;

namespace UsersAPI.Repos
{
    public class UserRepos
    {
        static List<User> users { get; set; }
       static UserRepos()
        {
            users = new List<User>()
            {
                new User(){Id=1,FName="Thabet",LName="Atatra",BOD=DateTime.Parse("1998/9/4")},
                new User(){Id=2,FName="Ahmad",LName="Omar",BOD=DateTime.Parse("1958/6/4")},
                new User(){Id=3,FName="Saeed",LName="Khalid",BOD=DateTime.Parse("1992/2/14")},
                new User(){Id=4,FName="Ali",LName="Jaad",BOD=DateTime.Parse("1975/5/1")},
                new User(){Id=5,FName="Naseem",LName="Amr",BOD=DateTime.Parse("1986/6/7")}

            };
        }
        public static List<User> GetALL()
        {
            return users;
        }

        public static User Get(int id)
        {
            return users.FirstOrDefault(user => user.Id == id);
        }

        public static void Delete(int id)
        {

            var user = Get(id);
            if (user != null)
                users.Remove(user);
        }

        public static void Add(User user)
        {
            users.Add(user);
        }

        public static void Update(User user, int id)
        {
            var _Prev_Edit_User=users.FirstOrDefault(user=>user.Id == id);
            if(_Prev_Edit_User != null)
            {
             var _Prev_Index = users.IndexOf(_Prev_Edit_User);
             users[_Prev_Index] = user;
            }
            
            
        }


    }
}
