using MVVM_TRIGGER_OGV.Modelo;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace MVVM_TRIGGER_OGV.Datos
{
    public class Dcategorias
    {
        public static ObservableCollection<Mcategorias> MostrarCategorias()
        {
            return new ObservableCollection<Mcategorias>()
            {
                new Mcategorias ()
                {
                    descripcion = "Cena",
                    numeroItem= 4512,
                    imagen="https://i.ibb.co/59qPkNx/pikachu.png",
                    backgroundColor="#EAEDF6",
                    textColor="#000000"
                },
                new Mcategorias ()
                {
                    descripcion = "Hotel",
                    numeroItem= 4512,
                    imagen="https://i.ibb.co/59qPkNx/pikachu.png",
                    backgroundColor="#EAEDF6",
                    textColor="#000000"
                },
                new Mcategorias ()
                {
                    descripcion = "Fiesta",
                    numeroItem= 4512,
                    imagen="https://i.ibb.co/59qPkNx/pikachu.png",
                    backgroundColor="#EAEDF6",
                    textColor="#000000"
                },
                new Mcategorias ()
                {
                    descripcion = "Flores",
                    numeroItem= 4512,
                    imagen="https://i.ibb.co/59qPkNx/pikachu.png",
                    backgroundColor="#EAEDF6",
                    textColor="#000000"
                }
            };
        }
    }
}
