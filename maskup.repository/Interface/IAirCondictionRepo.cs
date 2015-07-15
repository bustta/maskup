using maskup.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maskup.repository.Interface
{
    interface IAirCondictionRepo : IDisposable
    {
        List<AirCondiction> GetAll();
        AirCondiction GetById(Guid id);

    }
}
