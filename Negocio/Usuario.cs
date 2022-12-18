using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Negocio
{
    public class Usuario : IObserver
    {
        public Usuario(string nombre, string apellido)
        {
            Nombre = nombre;
            Apellido = apellido;
        }
        public string Nombre { get; set; }
        public string Apellido { get; set; }


        public override string ToString()
        {
            return $"{Nombre} {Apellido}";
        }
        public void UpdateH(SubjectHotel subjectH)
        {

            List<Form> forms = new List<Form>();

            foreach (Form frm in Application.OpenForms)
            {
                forms.Add(frm);
                if (frm.Name.Contains("Form1"))
                {
                    ListBox lb = (ListBox)frm.Controls["lstNotificaciones"];
                    lb.Items.Add($"El usuario {this} recibio la notificacion del producto {subjectH}");
                }
            }
        }

        public void UpdateV(SubjectVuelo subjectV)
        {
            List<Form> forms = new List<Form>();

            foreach (Form frm in Application.OpenForms)
            {
                forms.Add(frm);
                if (frm.Name.Contains("Form1"))
                {
                    ListBox lb = (ListBox)frm.Controls["lstNotificaciones"];
                    lb.Items.Add($"El usuario {this} recibio la notificacion del producto {subjectV}");
                }
            }
        }
    }
}
