using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GovornikKoZna
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public ObservableCollection<Slusaoc> listaSl = new ObservableCollection<Slusaoc>();
		public Diktafon dikt = new Diktafon();

		public Govornik g = new Govornik();

		private string govor;
		public string Govor 
		{ 
			get => govor; 
			set
			{
				govor = value;
				g.ObratiSe(govor);
			}
		}

		public MainWindow()
		{
			InitializeComponent();
			listaSl.Add(new Slusaoc("Pera"));
			listaSl.Add(new Slusaoc("Pera"));
			listaSl.Add(new Slusaoc("Pera"));
			listaSl.Add(new Slusaoc("Pera"));
			listaSl.Add(new Slusaoc("Pera"));
			listaSl.Add(new Slusaoc("Pera"));
			dg.ItemsSource = listaSl;

			DataContext = this;

			g.Govor += dikt.Snimi;

		}

		private void Dodaj(object sender, RoutedEventArgs e)
		{
			g.Govor += ((sender as Control).DataContext as Slusaoc).Slusaj;
		}

		private void Makni(object sender, RoutedEventArgs e)
		{
			g.Govor -= ((sender as Control).DataContext as Slusaoc).Slusaj;
		}
	}
}
