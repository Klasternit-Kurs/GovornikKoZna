using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GovornikKoZna
{
	public class GovorArgs
	{
		public string govor;
		public DateTime vreme = DateTime.Now;

		public GovorArgs(string g) => govor = g;
	}

	public class Govornik
	{
		public delegate void GovorHandler(object KoGovori, GovorArgs a);
		public event GovorHandler Govor;


		public void ObratiSe(string sta)
		{
			Govor?.Invoke(this, new GovorArgs(sta));


			//foreach (Slusaoc s in slusaoci)
			//	s.ZadnjeReceno = sta;
			//if (d != null)
			//	d.Snimi(sta);

			//slusaoci.ForEach(s => s.ZadnjeReceno = sta);
		}
	}
}
