using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;

namespace PlainServer
{
	class Server
	{


		public void start()
		{
			TcpListener Server = new TcpListener(IPAddress.Loopback, 10001);
			Server.Start();


			while (true)
			{
				TcpClient Socket = Server.AcceptTcpClient();
				using (NetworkStream ns = Socket.GetStream())
				using (StreamReader sr = new StreamReader(ns))
				{
					string car = sr.ReadLine();
					Console.WriteLine(car);
				}
			}
			}

			public Server()
			{

			}
		} 
}
