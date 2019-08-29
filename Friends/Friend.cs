using System;
using System.Collections.Generic;
using System.Text;

namespace Friends {
    class Friend {

        //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~PROPERTIES~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

        private static int nextFriendNumber = 0;

        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; } = null;
        public string Email { get; set; } = null;
        public bool BFF { get; set; } = false;
        public double HowLong { get; set; }

        //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~METHODS~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

        public override string ToString() {
            return $"{Name,-15} {Phone,-12} {Email,-25} {(BFF ? "BFF" : ""),3} {HowLong}";        
        }

        //defining what happens when someone calls ToString on the class + formatting.
        //the numbers are the character width for each value. - means left-justified.
        //BFF shows how to replace boolean value with T:F strings. Called the Ternary Operator. Can be used with other things:
        //var a = (boolean condition)?c:d; set a = c if boolean is true. set a = d if boolean is false.
        //using var a like above means that the 'var' interpreted variable will take on whatever type c and d are. one string, one dec, it will change a to that type.

        //var a = ( b >= 0 ) ? c : d;

        //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~CONSTRUCTORS~~~~~~~~~~~~~~~~~~~~~~~~~~

        private void Initialize() {
            Id = ++nextFriendNumber;
        }

        public Friend(string Name) {
            this.Name = Name;
            Initialize();
        }

        public Friend(string Name, string Phone, string Email, bool BFF, double HowLong) {
            this.Name = Name;
            this.Phone = Phone;
            this.Email = Email;
            this.BFF = BFF;
            this.HowLong = HowLong;
            Initialize();
        }
    }
}
