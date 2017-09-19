using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLib;
using System.Net.Sockets;
using System.Net;
using System.IO;

namespace PlainClient
{
	class Client
	{

		public void start()
		{
			Car Car1 = new Car("Tesla", "Rød", "EL23400");

			using (TcpClient Socket = new TcpClient("localhost", 10001))
			using (NetworkStream ns = Socket.GetStream())
			using (StreamWriter sw = new StreamWriter(ns))
			{
				string MyLine = Car1.ToString();
				sw.WriteLine(MyLine);
				sw.Flush();
			}

		}

		public void DoClient()
		{

		}
		public Client()
		{

		}



	}
}
