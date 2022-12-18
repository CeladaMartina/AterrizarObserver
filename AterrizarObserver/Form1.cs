using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Negocio;

namespace AterrizarObserver
{
    public partial class Form1 : Form
    {
        private List<SubjectHotel> _hoteles;
        private List<SubjectVuelo> _vuelos;
        private List<IObserver> _usuarios;


        private SubjectHotel _hotel;
        private SubjectVuelo _vuelo;
        private IObserver _usuario;
        public Form1()
        {
            InitializeComponent();
            _hoteles = new List<SubjectHotel>();
            _vuelos = new List<SubjectVuelo>();
            _usuarios = new List<IObserver>();
            simularDatos();

        }

        private void simularDatos()
        {
            _hoteles.Add(new SubjectHotel("Hotel Buena Vista", 100));
            _hoteles.Add(new SubjectHotel("Hotel Mala Vista", 200));
            _hoteles.Add(new SubjectHotel("Hotel Pesima Vista", 300));
            _hoteles.Add(new SubjectHotel("Hotel Sin Vista", 400));
            _vuelos.Add(new SubjectVuelo("Vuelo Buena Vista", 100));
            _vuelos.Add(new SubjectVuelo("Vuelo Mala Vista", 200));
            _vuelos.Add(new SubjectVuelo("Vuelo Pesima Vista", 300));
            _vuelos.Add(new SubjectVuelo("Vuelo Sin Vista", 400));
            _usuarios.Add(new Usuario("Diego", "Maradona"));
            _usuarios.Add(new Usuario("Leonel", "Messi"));
            _usuarios.Add(new Usuario("Paulo", "Silas"));

            mostrarHoteles();
            mostrarVuelos();
            mostrarUsuarios();
        }

        private void mostrarVuelos()
        {
            this.lstVuelos.DataSource = null;
            this.lstVuelos.DataSource = _vuelos;

        }
        private void mostrarHoteles()
        {
            this.lstHotel.DataSource = null;
            this.lstHotel.DataSource = _hoteles;

        }
        private void mostrarUsuarios()
        {
            this.lstUsuarios.DataSource = null;
            this.lstUsuarios.DataSource = _usuarios;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        #region Hoteles
        private void lstHotel_SelectedValueChanged(object sender, EventArgs e)
        {
            _hotel = (SubjectHotel)((ListBox)sender).SelectedItem;
        }

        private void lstUsuarios_SelectedValueChanged(object sender, EventArgs e)
        {
            _usuario = (IObserver)((ListBox)sender).SelectedItem;
        }

        private void BtnSuscribirHotel_Click(object sender, EventArgs e)
        {
            if (_hotel != null && _usuario != null)
            {
                try
                {
                    _hotel.Agregar(_usuario);
                    MessageBox.Show("Suscripción correcta");

                }
                catch (Exception ee)
                {

                    MessageBox.Show(ee.Message);
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un hotel y usuario");
            }
        }

        private void BtnDesuscribirHotel_Click(object sender, EventArgs e)
        {
            if (_hotel != null && _usuario != null)
            {
                try
                {
                    _hotel.Quitar(_usuario);
                    MessageBox.Show("Desuscripción correcta");

                }
                catch (Exception ee)
                {

                    MessageBox.Show(ee.Message);
                }

            }
            else
            {
                MessageBox.Show("Debe seleccionar un hotel y usuario");
            }
        }

        private void lstHotel_DoubleClick(object sender, EventArgs e)
        {
            double p;

            if (double.TryParse(Interaction.InputBox("Ingrese el nuevo precio: "), out p))
            {
                ((SubjectHotel)_hotel).Precio = p;
                mostrarHoteles();
            }
        }

        #endregion
        #region Vuelos

        private void lstVuelos_SelectedValueChanged(object sender, EventArgs e)
        {
            _vuelo = (SubjectVuelo)((ListBox)sender).SelectedItem;
        }

        private void BtnSuscribirVuelo_Click(object sender, EventArgs e)
        {
            if (_vuelo != null && _usuario != null)
            {
                try
                {
                    _vuelo.Agregar(_usuario);
                    MessageBox.Show("Suscripción correcta");

                }
                catch (Exception ee)
                {

                    MessageBox.Show(ee.Message);
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un vuelo y usuario");
            }
        }

        private void BtnDesuscribirVuelo_Click(object sender, EventArgs e)
        {
            if (_vuelo != null && _usuario != null)
            {
                try
                {
                    _vuelo.Quitar(_usuario);
                    MessageBox.Show("Desuscripción correcta");

                }
                catch (Exception ee)
                {

                    MessageBox.Show(ee.Message);
                }

            }
            else
            {
                MessageBox.Show("Debe seleccionar un vuelo y usuario");
            }
        }

        private void lstVuelos_DoubleClick(object sender, EventArgs e)
        {
            double p;

            if (double.TryParse(Interaction.InputBox("Ingrese el nuevo precio: "), out p))
            {
                ((SubjectVuelo)_vuelo).Precio = p;
                mostrarVuelos();
            }
        }

        #endregion
    }
}
