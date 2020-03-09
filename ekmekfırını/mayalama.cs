using System;
using System.Collections.Generic;
using System.Text;

namespace ekmekfırını
{
	class mayalama
	{
		int mayalamat = 130;
		int mayalamak = 165;
		int mayalamaç = 95;

		public bool tambugday()
		{
			if (mayalamat == 130)
				return true;
			else
				return false;             
		}
		public bool kepek()
		{
			if (mayalamak== 165)
				return true;
			else
				return false;
		}
		public bool cavdar()
		{
			if (mayalamaç == 95)
				return true;
			else
				return false;
		}
	}
}
