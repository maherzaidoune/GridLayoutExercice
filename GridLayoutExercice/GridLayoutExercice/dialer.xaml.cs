using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GridLayoutExercice
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class dialer : ContentPage
	{
        String number = "";
		public dialer ()
		{
			InitializeComponent ();
        }
        void Click(Object sender , EventArgs e)
        {
            if (sender == one)
                number += "1";
            if (sender == two)
                number += "2";
            if (sender == three)
                number += "3";
            if (sender == four)
                number += "4";
            if (sender == five)
                number += "5";
            if (sender == six)
                number += "6";
            if (sender == seven)
                number += "7";
            if (sender == eight)
                number += "8";
            if (sender == nine)
                number += "9";
            if (sender == zero)
                number += "0";
            if (sender == call)
            {
                DisplayAlert("Error", "Can't make call now ", "Cancel");
            }

            field.Text = number;
        }
	}
}