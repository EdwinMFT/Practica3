using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Practica3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class InicioMaster : ContentPage
    {
        public ListView ListView;

        public InicioMaster()
        {
            InitializeComponent();

            BindingContext = new InicioMasterViewModel();
            ListView = MenuItemsListView;
        }

        class InicioMasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<InicioMenuItem> MenuItems { get; set; }

            public InicioMasterViewModel()
            {
                MenuItems = new ObservableCollection<InicioMenuItem>(new[]
                {
                    new InicioMenuItem { Id = 0, Title = "Ingresar Datos"},
                    
                });
            }

            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}