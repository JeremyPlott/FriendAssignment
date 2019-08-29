using System;
using System.Collections.Generic;

namespace Friends {
    class Program {
        static void Main(string[] args) {

            //create 5 friends

            var friend1 = new Friend("Corey M", "513-555-1234", "ccccc@aol.com", true, 10.5);
            var friend2 = new Friend("Chris M", "513-555-4321", "cMMMc@gmail.com", true, 11);
            var friend3 = new Friend("Raymond K", "513-473-2354", "RrRrRr@yahoo.com", false, 0.8);
            var friend4 = new Friend("Jacob G", "678-323-3476", "JGNo1@phishing.net", false, 1.2);
            var friend5 = new Friend("Andrew 'AJ' R", "513-235-9999", "notenoughlette@gmail.com", true, 9.5);

            //Console.WriteLine($"{friend1.Name} {friend2.Name} {friend3.Name} {friend4.Name} {friend5.Name}");

            var friends = new List<Friend>(); //replaced the fixed array with this list.
            friends.Add(friend1);
            friends.Add(friend2);
            friends.Add(friend3);
            friends.Add(friend4);
            friends.Add(friend5);

            var aFriend = friends[0];

            var StateCodes = new Dictionary<string, string>();               //<key type, data type>
            StateCodes.Add("OH", "Ohio");
            StateCodes.Add("KY", "Kentucky");
            StateCodes.Add("IN", "Indiana");

            var ohio = StateCodes["OH"];

            //sorted dictionary has function of a dictionary but keeps the keys in sequence.

            //var friends = new Friend[] { friend1, friend2, friend3, friend4, friend5 };

            //foreach(var friend in friends) {                          //test ternary operator
            //    friend.HowLong = (friend.BFF) ? 10 : 0;
            //}

            foreach (var friend in friends) {
                Console.WriteLine(friend);
            }

            var totalYrs = 0.0;
            foreach(var friend in friends) {
                totalYrs += friend.HowLong;
            }
            Console.WriteLine($"The total length of your friendships is {totalYrs} years. Not bad for someone with that level of computer monitor tan.");

            //console.WriteLine is already calling a function ToString when creating strings.


            //mess around with generic collections

            //List<int> integers = new List<int>(); //hit tab after typing 'new' to auto complete.
            //integers.Add(17);
            //integers.Add(0);
            //integers.Add(88);
            //integers.Add(43);

            //var count = integers.Count;
            //integers.Sort();
            //integers.Remove(0);

        }
    }
}
