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
		public List<Slusaoc> zaGovornika = new List<Slusaoc>();

		public Govornik g = new Govornik();

		private string govor;
		public string Govor 
		{ 
			get => govor; 
			set
			{
				govor = value;
				g.ObratiSe(zaGovornika, govor);
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
		}

		private void Dodaj(object sender, RoutedEventArgs e)
		{
			zaGovornika.Add((sender as Control).DataContext as Slusaoc);
		}

		private void Makni(object sender, RoutedEventArgs e)
		{
			zaGovornika.Remove((sender as Control).DataContext as Slusaoc);
		}
	}
}
