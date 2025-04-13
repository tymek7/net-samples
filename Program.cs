var playerMove = new Move(Type.Nożyce);
var computerMoveType = Random.Shared.Next(2) switch
{
    0 => Type.Kamień,
    1 => Type.Papier,
    _ => Type.Nożyce
};
var computerMove = new Move(computerMoveType);

Console.WriteLine("Player: " + playerMove);
Console.WriteLine("Computer: " + computerMove);
Console.WriteLine(playerMove.Fight(computerMove));

internal enum Type
{
    Kamień, Nożyce, Papier
}


internal enum ResultType
{
    Won,
    Lost,
    Drew
}

internal sealed class Move(Type type)
{
    private Type MoveType { get; } = type;


    public ResultType Fight(Move opponentMove)
    {
        if (MoveType == opponentMove.MoveType) return ResultType.Drew;

        return (MoveType, opponentMove.MoveType) switch
        {
            (Type.Nożyce, Type.Papier) => ResultType.Won,
            (Type.Kamień, Type.Nożyce) => ResultType.Won,
            (Type.Papier, Type.Kamień) => ResultType.Won,
            _ => ResultType.Lost
        };

    }

    public override string ToString()
    {
        return MoveType.ToString();
    }
}

//
//
// using ConsoleApp1;
//
//
//
// var tymekAutoToSell = new CarToSell(
//     name: "Porsze",
//     price: 300.40m,
//     maxSpeed: 250,
//     vehicleType: VehicleType.Car,
//     "dupa"
//     );
//
// var uncleAutoToSell = new CarToSell(
//     name: "Audo",
//     price: 444.40m,
//     maxSpeed: 44,
//     vehicleType: VehicleType.Truck,
//     "dupa"
// );
//
//
//
// try
// {
//     tymekAutoToSell.ChangePrice(222.22m, "dupa");
// }
// catch (Exception ex)
// {
//     Console.WriteLine(ex.Message);
// }
//
// Console.WriteLine(tymekAutoToSell);
// Console.WriteLine(uncleAutoToSell);
//
//
// enum VehicleType
// {
//     Truck,
//     Car
// }
//
//
// class CarToSell
// {
//     private VehicleType VehicleType;
//     private int MaxSpeed;
//     private decimal Price;
//     private string Name;
//     private string Password;
//     
//     public CarToSell(string name, decimal price, int maxSpeed, VehicleType vehicleType, string password)
//     {
//         Name = name;
//         Price = price;
//         MaxSpeed = maxSpeed;
//         VehicleType = vehicleType;
//         Password = password;
//     }
//
//     public void ChangePrice(decimal newPrice, string password)
//     {
//         if (Password != password)
//         {
//             throw new Exception("Wrong password - only real owner could change price!!!");   
//         }
//         
//         Price = newPrice;
//     }
//
//     public override string ToString()
//     {
//         return $"Car name: {Name}, price: {Price:C}, maxSpeed: {MaxSpeed}, vehicleType: {VehicleType}";
//     }
// }
//
//
//
//
//
//
// struct Car
// {
//     private string Name;
//     private double Price;
//
//     void ChangePrice(double newPrice, string password)
//     {
//         Price = newPrice;
//     }
// }
//
//
//
// class People
// {
//     public string Name { get; set; }
//
//     public virtual string GetName()
//     {
//         return $"My name ist: {Name}";
//     }
// }
//
// class DisabledPeople : People
// {
//     
//     public string Description { get; set; }
//
//
//     public override string GetName()
//     {
//         return $"My name ist: {Name} Im disabled";
//     }
// }
//
//
// class NonDisabledPeople : People
// {
//     public string Content { get; set; }
// }
//
//