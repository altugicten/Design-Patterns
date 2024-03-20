using FactoryPattern;


// Factory Design pattern

//#region Factory Design Pattern
//VehicleCreator factory = new VehicleCreator();

//// Create a car
//IVehicle car = factory.CreateVehicleForFactory(VehicleEnum.Car);
//car.Drive();
//car.Park();

//Console.WriteLine();

//// Create a truck
//IVehicle truck = factory.CreateVehicleForFactory(VehicleEnum.Truck);
//truck.Drive();
//truck.Park();

//Console.WriteLine();

//// Create a motorcycle
//IVehicle motorcycle = factory.CreateVehicleForFactory(VehicleEnum.Motor);
//motorcycle.Drive();
//motorcycle.Park();
//#endregion


#region Factory Method Design Pattern
VehicleCreator creator = new();


//IVehicle car1 = creator.CreateVehicleForFactoryMethod(VehicleEnum.Car);
//car1.Park();
//car1.Drive();

//Console.WriteLine();

//IVehicle truck1 = creator.CreateVehicleForFactoryMethod(VehicleEnum.Truck);
//truck1.Park();
//truck1.Drive();
#endregion


IVehicleFactory carFactory = new CarFactory();
IVehicle car2 = carFactory.CreateVehicle();
car2.Park();
car2.Drive();
car2.Stop();    
