using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MinerCON
{
    public class RconConnection : IDisposable
    {
        private static MinecraftClient client;

        public void Login([Description("The adress of a server")] string adress, [Description("The port on which Rcon is running")] int port, [Description("Rcon Password")] string password)
        {
            try
            {
                client = new MinecraftClient(adress, port);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error via registration: {ex.Message}");
                return;
            }
            try
            {
                client.Authenticate(password);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An authorization error: {ex.Message}");
            }
        }

        public void SendCommand(string command)
        {
            Message responce;
            client.SendCommand(command, out responce);
            Console.WriteLine(responce.Body);
        }

        public void Dispose()
        {
            try
            {
                client.Close();
                client.Dispose();
            }catch (Exception ex)
            {
                Console.WriteLine($"Logout error: {ex.Message}");
            }
        }
    }
}
