using maskup.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maskup.service.Interface
{
    interface IAirCondictionService : IDisposable
    {
        List<AirCondiction> GetLatestAndSort();
    }
}
