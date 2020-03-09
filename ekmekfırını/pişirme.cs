using System;
using System.Collections.Generic;
using System.Text;

namespace ekmekfırını
{
	class pişirme
	{
		int pisirmet = 40;
		int pisirmek = 25;
		int pisirmeç = 30;

		public bool tambugday()
		{
			if (pisirmet == 40)
				return true;
			else
				return false;
		}
		public bool kepek()
		{
			if (pisirmek == 25)
				return true;
			else
				return false;
		}
		public bool cavdar()
		{
			if (pisirmeç == 30)
				return true;
			else
				return false;
		}
	}
}
