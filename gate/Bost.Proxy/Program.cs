﻿using System;
using System.Reflection;

namespace Bost.Proxy
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine($"Alword Bost Proxy {Assembly.GetExecutingAssembly().GetName().Version}");

			ProxyClient proxy = new ProxyClient("0.0.0.0", "0.0.0.0", 22565);
			proxy.Start();
			while (true)
			{
				Console.ReadLine();
				proxy = new ProxyClient("0.0.0.0", "0.0.0.0", 25566);
				proxy.Start();
			}
		}
	}
}
