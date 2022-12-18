using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public interface ISubject
    {
        // Attach an observer to the subject.
        void Agregar(IObserver observer);

        // Detach an observer from the subject.
        void Quitar(IObserver observer);

        // Notify all observers about an event.
        void Notificar();

    }
}
