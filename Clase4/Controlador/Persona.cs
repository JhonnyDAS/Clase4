using Clase4.Modelo;
using Clase4.Modelo.dsPruebaDBTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Clase4.Controlador
{
    class Persona
    {
        dsPruebaDB _ds = new dsPruebaDB();
        PersonaTableAdapter _taPersona = new PersonaTableAdapter();
        #region Campos
        private string ci;

        public string Ci
        {
            get { return ci; }
            set { ci = value; }
        }
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        private string apellido;

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        private string direccion;

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }
        #endregion
        #region Metodos
        public DataTable Listar()
        {
            return _taPersona.GetData();
        }
        //public DataTable Listar(string pBuscar)
        //{
        //    return _taPersona.GetDataByBuscar(pBuscar);
        //}
        public void Modificar(string pCi)
        {
            try
            {
                _taPersona.Update(
                        Ci,
                        Nombre,
                        Apellido,
                        Direccion,
                        pCi
                    );
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        public void Insertar()
        {
            try
            {
                _taPersona.Insert(
                    Ci,
                    Nombre,
                    Apellido,
                    Direccion
                    );
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        public void Eliminar(string pCi)
        {
            try
            {
                _taPersona.Delete(pCi);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        //public DataTable BuscarPK(string pCi)
        //{
        //    return _taPersona.GetDataByPK(pCi);
        //}
        #endregion
    }
}
