using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GovornikKoZna
{
	public class Diktafon
	{
		public List<string> SveReceno = new List<string>();
																
		public void Snimi(object gov, GovorArgs a) => SveReceno.Add(a.vreme + "-" + gov.ToString() + ": " + a.govor);

		public void SnimiuFajl(object gov, GovorArgs a) => File.AppendAllText($"{gov.ToString()}.txt", 
			a.vreme + "-" + gov.ToString() + ": " + a.govor + Environment.NewLine);
	}
}
