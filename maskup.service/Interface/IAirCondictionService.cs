using maskup.domain;
using System;
using System.Collections.Generic;

namespace maskup.service.Interface
{
    interface IAirCondictionService : IDisposable
    {
        List<AirCondiction> GetAll();
        AirCondiction GetById(Guid id);

        List<AirCondiction> GetLatestAndSort();
    }
}
