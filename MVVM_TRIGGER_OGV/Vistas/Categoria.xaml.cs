using MVVM_TRIGGER_OGV.VistaModelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MVVM_TRIGGER_OGV.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Categoria : ContentPage
    {
        public Categoria()
        {
            InitializeComponent();
            BindingContext = new VMcategoria(Navigation);
        }
    }
}