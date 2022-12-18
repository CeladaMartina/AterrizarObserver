using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Negocio
{
    public class SubjectHotel : ISubject
    {

        private List<IObserver> _usuarios;
        public SubjectHotel(string nombre, double precio)
        {

            _usuarios = new List<IObserver>();
            Nombre = nombre;
            _precio = precio;
        }

        public string Nombre { get; set; }


        double _precio;
        public double Precio
        {
            get
            {
                return _precio;
            }
            set
            {
                _precio = value;
                this.Notificar();
            }
        }
        public override string ToString()
        {
            return $"{Nombre} (${_precio})";
        }


        public void Agregar(IObserver usuario)
        {
            if (!_usuarios.Contains(usuario))
            {
                _usuarios.Add(usuario);
            }
            else
            {
                throw new Exception($"Ya existe una suscripción para {((Usuario)usuario)}");
            }
        }

        public void Notificar()
        {
            foreach (var usuario in _usuarios)
            {
                usuario.UpdateH(this);
            }

            //Form f1 = Application.OpenForms["Form1"];          
            //f1.Notificar();

            List<Form> forms = new List<Form>();

            foreach (Form frm in Application.OpenForms)
            {
                forms.Add(frm);
                if (frm.Name.Contains("Form1"))
                {
                    ListBox lb = (ListBox)frm.Controls["lstNotificaciones"];
                    lb.Items.Add("$--------------------------------------------------------------------------------------------------------------------");
                }

                if (_usuarios.Count == 0)
                {
                    if (frm.Name.Contains("Form1"))
                    {
                        ListBox lb = (ListBox)frm.Controls["lstNotificaciones"];
                        lb.Items.Add($"No hay suscripciones");
                    }                   
                }
            }      
        
        }

        public void Quitar(IObserver usuario)
        {
            if (_usuarios.Contains(usuario))
            {
                _usuarios.Remove(usuario);
            }
            else
            {
                throw new Exception($"Ya existe una suscripción para {((Usuario)usuario)}");
            }
        }
    }
}
