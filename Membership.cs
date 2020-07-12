using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessRulesEngine
{
    public class Membership:Product,IEmail
    {
        private string memberShipType;
        public string MembershipType { get; set; }

        public Membership(string memberShipType)
        {
            this.memberShipType = memberShipType;
            this.SendEmail();          
        }
        public void SendEmail()
        {
            Console.WriteLine("Email sent to Owner");
        }
    }
}
