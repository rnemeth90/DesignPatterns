// See https://aka.ms/new-console-template for more information

using Builder;

void MakeCar()
{ 
    VehicleBuilder car = new VehicleBuilder();
    car.AddEngine();
    car.AddTires();
    car.AddECU();
    car.AddNavigationSystem();
    car.Build();
    Console.WriteLine(car.GetVehicle().ListParts());


    VehicleBuilder boat = new VehicleBuilder();
    boat.AddEngine();
    boat.AddNavigationSystem();
    boat.Build();
    Console.WriteLine(boat.GetVehicle().ListParts());
}
MakeCar();