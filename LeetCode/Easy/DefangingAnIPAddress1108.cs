using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Easy
{
    /// <summary>
    /// Given a valid (IPv4) IP address, return a defanged version of that IP address.
    /// A defanged IP address replaces every period "." with "[.]".
    /// </summary>
    public class DefangingAnIPAddress1108
    {
        public string DefangIPaddr(string address)
        {
            address = address.Replace(".", "[.]");
            return address;
        }
    }
}
