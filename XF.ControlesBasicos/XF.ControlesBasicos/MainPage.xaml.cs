using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XF.ControlesBasicos
{
    public partial class MainPage : ContentPage
    {
        private Configuracao _vmConfig;
        public MainPage()
        {
            InitializeComponent();
        }

        void ButtonEnviarClicked(object sender, EventArgs e)
        {
            if (_vmConfig == null)
                _vmConfig = new Configuracao();

            if (_vmConfig.ReceberEmail)
            {
                DisplayAlert("Mensagem"
                    , "E-mail enviado para" + _vmConfig.Email, "OK");
            }
            else
            {
                DisplayAlert("Mensagem"
                    , "E-mail não autorizado", "OK");
            }
            
        }

        void ButtonConfiguracaoClicked(object sender, EventArgs e)
        {

            if (_vmConfig == null)
                _vmConfig = new Configuracao();

            Navigation.PushAsync(new ConfigPage() { BindingContext = _vmConfig });
        }
    }
}
