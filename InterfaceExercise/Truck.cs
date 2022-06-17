using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class Truck : IVehicle, ICompany
    {
        public double EngineSize { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int SeatCount { get; set; }
        public bool HasChangedGears { get; set; }
        public string CompanyName { get; set; }
        public string motto { get; set; }

        public void ChangeGears(bool ischanged)
        {
            HasChangedGears = ischanged;
        }

        public void Drive()
        {
            Console.WriteLine($"the truck is in drive");
        }

        public void park()
        {
            Console.WriteLine($"the truck is in park");
        }

        public void Reverse()
        {
            Console.WriteLine($"the truck is in reverse");
        }
    }
}
