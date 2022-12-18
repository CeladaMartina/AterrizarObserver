using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace Negocio
{
    public interface IObserver
    {
        void UpdateV(SubjectVuelo subjectV);
        void UpdateH(SubjectHotel subjectH);
    }
}
