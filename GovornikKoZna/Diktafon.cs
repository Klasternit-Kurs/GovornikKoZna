using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GovornikKoZna
{
	public class Diktafon
	{
		List<string> SveReceno = new List<string>();
																
		public void Snimi(object gov, GovorArgs a) => SveReceno.Add(a.vreme + "-" + gov.ToString() + ": " + a.govor);
	}
}
