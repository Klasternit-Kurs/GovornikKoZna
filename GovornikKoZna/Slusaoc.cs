using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GovornikKoZna
{
	public class Slusaoc : INotifyPropertyChanged
	{
		public string Ime { get; set; }

		private string zadnjeReceno;
		public string ZadnjeReceno
		{ 
			get => zadnjeReceno; 
			set
			{
				zadnjeReceno = value;
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ZadnjeReceno"));
			}
		}

		public Slusaoc(string i) => Ime = i;

		public event PropertyChangedEventHandler PropertyChanged;

		public void Slusaj(object gov, GovorArgs a) => ZadnjeReceno = a.govor;

		public override string ToString() => "Neko moj ToString :) ";
	}
}
