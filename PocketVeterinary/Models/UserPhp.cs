using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace PocketVeterinary.Models
{
    [DataContract]
  public  class UserPhp
    {

        [DataMember(Name = "id")]
        public int id { get; set; }

        [DataMember(Name = "name")]
        public String name { get; set; }

        [DataMember(Name = "username")]
        public String username { get; set; }

        [DataMember(Name = "password")]
        public String password { get; set; }

        [DataMember(Name = "logged")]
        public Boolean logged { get; set; }

 

        //  public static List<UserPhp> userList = new List<UserPhp>();
        // public static UserPhp user;

        /*
        public class UserPhpManagers
        {

            public static  Task<UserPhp> getUsername(string username)
            {
                HttpClient httpClient = new HttpClient();
                JArray u;
                try
                {
                    Task<string> datataskuser = httpClient.GetStringAsync("http://localhost/PocketVetWindows/login.php?email=" + username);
                    string datauser = datataskuser.Result;
                    if (datauser.Equals(""))
                        user = null;


                    else {
                        u = JArray.Parse(datauser);
                        Debug.WriteLine("****" + u[0]["name"]);               
                        int id = (int)u[0]["id"];
                        user = new UserPhp { id = id, username = u[0]["username"] + "", name = u[0]["name"] + "", password = u[0]["password"] + "" };

                        //      user = new User { id = id, username = u[0]["username"] + "", email = u[0]["email"] + "", lastName = u[0]["lastName"] + "", firstName = u[0]["¸firstName"] + "", tel = tel, adresse = u[0]["adresse"] + "", password = u[0]["password"] + "", photo = "Assets/UserHraderImg.png" };
                        Debug.WriteLine(user.name);
                      
                    }
                }
                catch (HttpRequestException hre)
                {
                    // You might want to actually handle the exception
                    // instead of silently swallowing it.
                 
                }

               return user;
         
            }
        }*/
      
       
    }
    [DataContract]
    public class RootUser
    {
        [DataMember(Name = "user")]
        public List<UserPhp> user { get; set; }
        [DataMember(Name = "meta")]
        public Meta1 meta { get; set; }
    }
    public class Meta1
    {
        [DataMember(Name = "code")]
        public int code { get; set; }
        [DataMember(Name = "requestId")]
        public string requestId { get; set; }
    }
}
