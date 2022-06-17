using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    internal interface IVehicle
    {
        public double EngineSize { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int SeatCount { get; set; }

        public void Drive();
        public void Reverse();

        public void park();

        public void ChangeGears(bool ischanged);

        public bool HasChangedGears { get; set; }
    }
}
