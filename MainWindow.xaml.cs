using System;
using System.Collections.Generic;
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

namespace Druga
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		private int kolicina = 0; //stanje, polje, kako god

		public int Kolicina //property, tj. skup dve metode za citanje i pisanje
		{ //unutar propertya obavezno pricati sa poljem, tj. malo slovo :D
			get
			{
				return kolicina;
			}

			set
			{
				if (value < 0) //ono sto smo dobili
				{
					kolicina = 0;
				}
				else
				{
					kolicina = value;
				}
			}
		}

		public string Tekst { get; set; } = "Nesto"; //brz nacin pisanja propertya bez specificnosti :) 

		public int DajKolicinu()
		{
			return kolicina;
		}

		public void PromeniKolicinu(int kol)
		{
			if (kol < 0)
			{
				kolicina = 0;
			} else
			{
				kolicina = kol;
			}
		}

		public MainWindow()
		{	
			InitializeComponent(); //Kod za komponente uvek
								   //ispod :)

				
		}

		private void zklj(object qwe, RoutedEventArgs zxc)
		{
			//Ovako nikada :)
			//MojaLabela.Content = Tekst;


			Binding MojBajnding = new Binding();
			MojBajnding.Source = this;
			MojBajnding.Path = new PropertyPath("Tekst");
	

			BindingOperations.SetBinding(MojaLabela, Label.ContentProperty, MojBajnding);
		}

	
	}


}
