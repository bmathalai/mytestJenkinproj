using System;
using System.Management;

namespace WMISample
{
    class Program
    {
        static void Main(string[] args)
        {
            ConnectionOptions con = new ConnectionOptions();
            //con.Username = "Administrator";
            //con.Password = "Password";

            ManagementScope scope = new ManagementScope(@"\\IN-PF2S40JT\root\cimv2", con);
            scope.Connect();

            // Get the WMI class path test testing
            ManagementPath p =
                new ManagementPath(
                "\\\\IN-PF2S40JT\\root" +
                "\\cimv2:Win32_LogicalDisk.DeviceID=\"C:\"");

            Console.WriteLine("IsClass: " +
                p.IsClass);
            // Should be False (because it is an instance)

            Console.WriteLine("IsInstance: " +
                p.IsInstance);
            // Should be True

            Console.WriteLine("ClassName: " +
                p.ClassName);
            // Should be "Win32_LogicalDisk"

            Console.WriteLine("NamespacePath: " +
                p.NamespacePath);
            // Should be "ComputerName\cimv2"

            Console.WriteLine("Server: " +
                p.Server);
            // Should be "ComputerName"

            Console.WriteLine("Path: " +
                p.Path);
            // Should be "ComputerName\root\cimv2:
            // Win32_LogicalDisk.DeviceId="C:""

            Console.WriteLine("RelativePath: " +
                p.RelativePath);
            // Should be "Win32_LogicalDisk.DeviceID="C:""
        }
    }
}
