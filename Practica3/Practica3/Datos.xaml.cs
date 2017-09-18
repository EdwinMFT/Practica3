using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Practica3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Datos : ContentPage
    {
        public Datos(nuevosParametros parametros)
        {
            InitializeComponent();
            BindingContext = parametros;

        }
        
    }
}