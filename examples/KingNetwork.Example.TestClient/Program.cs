using KingNetwork.Client;
using KingNetwork.Example.Shared;
using System;
using KingNetwork.Example.TestClient.PacketHandlers;

namespace KingNetwork.Example.TestClient
{
    /// <summary>
    /// This class represents the program instance.
    /// </summary>
    class Program
    {
        /// <summary>
        /// This method is responsible for main execution of console application.
        /// </summary>
        /// <param name="args">The string args receiveds by parameters.</param>
        static void Main(string[] args)
        {
            try
            {
                var client = new KingClient();
                client.PutHandler<MyPacketHandlerOne, MyPackets>(MyPackets.PacketOne);
                client.Connect("127.0.0.1");

                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
