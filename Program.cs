using V1UPGF;

namespace Friend
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Friend.Factory.SetRandomFriend());
            Console.WriteLine(Adress.Factory.CreateAdress());
            List<Friend> friends = new List<Friend>();
            for (int i = 0; i < 100_000; i++)
            {
                friends.Add(Friend.Factory.SetRandomFriend());
            }
            for (int i = friends.Count() - 20; i < friends.Count(); i++)
            {
                Console.WriteLine(friends[i]);
            }
            for (int i = 0; i < 20; i++) 
            {
                Console.WriteLine(friends[i]);
            }
        }
    }
}