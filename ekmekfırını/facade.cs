using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ekmekfırını
{
	class facade
	{
		fırınderecesi fd = new fırınderecesi();
		mayalama my = new mayalama();
		pişirme ps = new pişirme();
		public void facade1()
		{
			if (my.cavdar())
			{
				Console.WriteLine("Hamur mayalandı.");
				Thread.Sleep(1000);
				if (fd.cavdarlı())
				{
					Console.WriteLine("Fırın derecesi ayarlandı.");
					Thread.Sleep(1000);
					if (ps.cavdar())
					{ 
						Console.WriteLine("Ekmek pişti.\n");
					}
				}
			}
		}
		public void facade2()
		{
			if (my.kepek())
			{
				Console.WriteLine("Hamur mayalandı.");
				Thread.Sleep(1000);
				if (fd.kepekli())
				{
					Console.WriteLine("Fırın derecesi ayarlandı.");
					Thread.Sleep(1000);
					if (ps.kepek())
					{
						Console.WriteLine("Ekmek pişti.\n");
					}
				}
			}
		}
		public void facade3()
		{
            if (my.tambugday())
			{
				Console.WriteLine("Hamur mayalandı.");
				Thread.Sleep(1000);
				if (fd.tambugday())
				{
					Console.WriteLine("Fırın derecesi ayarlandı.");
					Thread.Sleep(1000);
					if (ps.tambugday())
					{
						Console.WriteLine("Ekmek pişti.\n");
					}
				}
			}
		}		
	}
}
