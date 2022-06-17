using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    internal class Car : IVehicle, ICompany
    {
        public double EngineSize { get  ; set  ; }
        public string Make { get  ; set  ; }
        public string Model { get  ; set  ; }
        public int SeatCount { get  ; set  ; }
        public string CompanyName { get  ; set  ; }
        public string motto { get  ; set  ; }
        public bool HasChangedGears { get ; set ; }

        public void ChangeGears(bool ischanged)
        {
            HasChangedGears = ischanged;
        }

        public void Drive()
        {
            Console.WriteLine($"{GetType().Name} now driving foward");
        }

        public void park()
        {
            Console.WriteLine($" car is parked");
        }

        public void Reverse()
        {

            Console.WriteLine($"car is in reverse");

            
        }

        
          
        
    }
}
