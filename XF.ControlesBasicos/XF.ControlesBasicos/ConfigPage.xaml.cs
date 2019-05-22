using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XF.ControlesBasicos
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ConfigPage : ContentPage
	{
		public ConfigPage ()
		{
			InitializeComponent ();

            if (!receberemail.On)
            {
                email.IsEnabled = false;
            }
        }

        private void SwitchCell_OnChanged(object sender, ToggledEventArgs e)
        {
            if (!receberemail.On)
            {
                email.Text = string.Empty;
                email.IsEnabled = false;
            }
            else
            {
                email.IsEnabled = true;
            }
            
        }
    }
}