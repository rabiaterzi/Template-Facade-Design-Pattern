using System;
using System.Collections.Generic;
using System.Text;

namespace ekmekfırını
{
	class fırınderecesi
	{
		int fırınd=160;
		int fırınde = 180;
		int fırınder = 200;

		public bool tambugday()
		{
			if (fırınd == 160)
				return true;
			else
				return false;
		}
		public bool kepekli()
		{
			if (fırınde == 180)
				return true;
			else
				return false;
		}
		public bool cavdarlı()
		{
			if (fırınder == 200)
				return true;
			else
				return false;
		}
	}
}
