using System;

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

            var friends = new Friend[] { friend1, friend2, friend3, friend4, friend5 };
            foreach(var friend in friends) {
                Console.WriteLine(friend);
            }

            var totalYrs = 0.0;
            foreach(var friend in friends) {
                totalYrs += friend.HowLong;
            }
            Console.WriteLine($"The total length of your friendships is {totalYrs} years. Not bad for someone with a computer monitor tan at that level.");

            //console.WriteLine is already calling a function ToString when creating strings.
        }
    }
}
