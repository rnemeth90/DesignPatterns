using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    internal interface IVehicleBuilder
    {
        void Reset();
        void Build();
        void AddSeats();
        void AddEngine();
        void AddECU();
        void AddNavigationSystem();
        void AddTires();
    }
}
