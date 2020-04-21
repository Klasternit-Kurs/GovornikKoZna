using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GovornikKoZna
{
	public class Govornik
	{
		public void ObratiSe(List<Slusaoc> slusaoci, string sta)
		{
			//foreach (Slusaoc s in slusaoci)
			//	s.ZadnjeReceno = sta;

			slusaoci.ForEach(s => s.ZadnjeReceno = sta);
		}
	}
}
