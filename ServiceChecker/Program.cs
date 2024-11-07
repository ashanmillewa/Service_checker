using System;
using System.ServiceProcess;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Service Status Checker");

        // Get all the services on the local machine
        ServiceController[] services = ServiceController.GetServices();

        // Check each service and display its status
        foreach (ServiceController service in services)
        {
            try
            {
                // Display service name and status
                Console.WriteLine($"Service: {service.ServiceName}");
                Console.WriteLine($"Display Name: {service.DisplayName}");
                Console.WriteLine($"Status: {service.Status}");
                Console.WriteLine("----------------------------");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error getting service {service.ServiceName}: {ex.Message}");
            }
        }

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}
