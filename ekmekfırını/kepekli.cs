using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ekmekfırını
{
	class kepekli : template
	{
		public void içerikekle()
        {
			Console.WriteLine("Bal eklendi.");
			Thread.Sleep(1000);
		}

		public void mayaekle()
		{
			Console.WriteLine("Kuru maya eklendi.");
			Thread.Sleep(1000);
		}

		public void unekle()
		{
			Console.WriteLine("Kepekli un eklendi.");
			Thread.Sleep(1000);
		}
	}
}
