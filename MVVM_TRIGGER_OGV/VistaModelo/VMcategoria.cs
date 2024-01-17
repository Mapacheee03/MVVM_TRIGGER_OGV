using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;
using MVVM_TRIGGER_OGV.Modelo;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVM_TRIGGER_OGV.VistaModelo
{
    public class VMcategoria : BaseViewModel
    {
        #region VARIABLES
        string _Texto;
        ObservableCollection<Mcategorias> _listaCategorias;
        #endregion
        #region CONSTRUCTOR
        public VMcategoria(INavigation navigation)
        {
            Navigation = navigation;
            MostrarCategorias();
        }
        #endregion
        #region OBJETOS
        public ObservableCollection<Mcategorias> ListaCategorias
        {
            get { return _listaCategorias; }
            set { SetValue(ref _listaCategorias, value); }
        }
        #endregion
        #region PROCESOS
        public async Task ProcesoAsyncrono()
        {

        }
        public void MostrarCategorias()
        {
            //Al hacer esto estamos jalando toda la data
            ListaCategorias = new ObservableCollection<Mcategorias>(Datos.Dcategorias.MostrarCategorias());
        }
        #endregion
        #region COMANDOS
        public ICommand ProsesoAsynCommnad => new Command(async () => await ProcesoAsyncrono());
        public ICommand MostrarCategoriasCommnad => new Command(MostrarCategorias);
        #endregion
    }
}
