using POS.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace POS.View
{
	/// <summary>
	/// Interaction logic for CustomerView.xaml
	/// </summary>
	public partial class CustomerView : UserControl
	{
		private CustomerViewModel _customerViewModel;

		public CustomerView(CustomerViewModel customerViewModel)
		{
			InitializeComponent();
			//Data binding...this is tight coupling, no??
			_customerViewModel = customerViewModel;
			DataContext = _customerViewModel;
			Loaded += CustomerView_Loaded;
		}

		public void CustomerView_Loaded(object sender, RoutedEventArgs e)
		{
			_customerViewModel.LoadCustomers();
		}
	}
}
