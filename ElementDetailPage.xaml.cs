using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ElectricalSymbols
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ElementDetailPage : ContentPage
	{
	    public ElementDetailPage(Element element)
	    {
	        if (element == null)
	        {
	            throw new ArgumentNullException();
	        }

	        BindingContext = element;

	        InitializeComponent();


	    }
	}
}