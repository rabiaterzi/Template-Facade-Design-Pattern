using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ekmekfırını
{
	class tambuğday : template
	{
		public void içerikekle()
		{
			Console.WriteLine("Zeytinyağı eklendi.");
			Thread.Sleep(1000);
		}

		public void mayaekle()
		{
			Console.WriteLine("Kuru maya eklendi.");
			Thread.Sleep(1000);
		}

		public void unekle()
		{
			Console.WriteLine("Tam buğdaylı un eklendi.");
			Thread.Sleep(1000);
		}
	}
}
