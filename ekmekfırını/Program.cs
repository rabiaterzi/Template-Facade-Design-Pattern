using System;

namespace ekmekfırını
{
	class Program
	{
		static void Main(string[] args)
		{
            facade tamb = new facade();
			template tambugdaylı = new tambuğday();
			tambugdaylı.build();		
			tamb.facade3();

			template cavdarlı = new çavdar();
			cavdarlı.build();
			tamb.facade1();

			template kepekli = new kepekli();
			kepekli.build();
			tamb.facade2();
		}
	}
}
