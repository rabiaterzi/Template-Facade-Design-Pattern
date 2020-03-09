using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ekmekfırını
{
	interface template
	{
		public void build()
		{
			Thread.Sleep(1000);
			Console.WriteLine("Tuz,toz şeker ve ılık su eklendi.");
			Thread.Sleep(1000);
			mayaekle();
			içerikekle();
			unekle();
		}	
		public void mayaekle();
		public void içerikekle();
        public void unekle();
	}
}
