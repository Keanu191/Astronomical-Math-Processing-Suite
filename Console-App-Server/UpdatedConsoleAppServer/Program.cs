// 30074191 / Keanu Farro
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using AstroMath;

namespace UpdatedConsoleAppServer
{
    /// <summary>
    /// Entry point for the AstroServer WCF service application.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Main method to host the WCF service.
        /// </summary>
        /// <param name="args">Command-line arguments.</param>
        static void Main(string[] args)
        {
            const string address = "net.pipe://localhost/AstroServer";

            using (var serviceHost = new ServiceHost(typeof(AstroServer)))
            {
                var binding = new NetNamedPipeBinding(NetNamedPipeSecurityMode.None);
                serviceHost.AddServiceEndpoint(typeof(IAstroContract), binding, address);

                try
                {
                    serviceHost.Open();
                    Console.WriteLine("ServiceHost is running. Press Enter to exit...");
                    Console.ReadLine();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error starting the service: {ex.Message}");
                }
                finally
                {
                    if (serviceHost.State == CommunicationState.Opened)
                    {
                        serviceHost.Close();
                    }
                }
            }
        }
    }
}

