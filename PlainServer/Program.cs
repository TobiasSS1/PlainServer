﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlainServer
{
	class Program
	{
		static void Main(string[] args)
		{
			Server Server1 = new Server();
			Server1.start();
		}
	}
}
