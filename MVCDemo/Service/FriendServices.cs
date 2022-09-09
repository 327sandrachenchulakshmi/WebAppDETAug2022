using MVCDemo.Models;
using System.Xml.Linq;

namespace MVCDemo.Service
{
    public class FriendServices
    {
        static List<Friend> Friends { get; }
        static int nextId = 3;
        static FriendServices()
        {
            Friends = new List<Friend>
                {
                    new Friend {FriendId = 1,FriendName = "Kiran", Place="Kottur" },  
                    new Friend {FriendId = 2,FriendName = "chandu", Place="Kottur" },
                };
        }

        public static List<Friend> GetAll() => Friends;

        public static Friend? Get(int id) => Friends.FirstOrDefault(p => p.FriendId == id);

        public static void Add(Friend Friend)
        {
            Friend.FriendId = nextId++;
            Friends.Add(Friend);
        }

        public static void Delete(int id)
        {
            var Friend = Get(id);
            if (Friend is null)
                return;

            Friends.Remove(Friend);
        }

        public static void Update(Friend Friend)
        {
            var index = Friends.FindIndex(f => f.FriendId == Friend.FriendId);
            if (index == -1)
                return;

            Friends[index] = Friend;
        }
    }
}

