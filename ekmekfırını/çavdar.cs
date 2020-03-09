using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ekmekfırını
{
	class çavdar : template
	{
		public void içerikekle()
		{
			Console.WriteLine("Sıvı yağ ve yağsız süt eklendi.");
			Thread.Sleep(1000);
		}

		public void mayaekle()
		{
			Console.WriteLine("Yaş maya eklendi.");
			Thread.Sleep(1000);
		}

		public void unekle()
		{
			Console.WriteLine("Çavdarlı un eklendi.");
			Thread.Sleep(1000);
		}
	}
}
