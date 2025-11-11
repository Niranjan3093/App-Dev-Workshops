using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class NullOperators
    {
        public void PerformNullChecks()
        {
            string username = null;
            string displayName = (username == null) ? "Username is not available." : username;
            Console.WriteLine(displayName);

            Console.WriteLine(username ?? "Username is not available.");

            username ??= "Default User.";
            Console.WriteLine($"Updated Username : {username}");
        }
    }
}
