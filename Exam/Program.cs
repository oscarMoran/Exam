using Factory;
using Microsoft.Extensions.Hosting;
using PartOne;
using PartTwoSingleton;
// Part 1
/* 
var cruiseObj = new Cruise
{
    Name = "Cabo San Lucas world tour",
    Description = @"Cruises to Mexico are available year-round, 
                    and itineraries typically range from three to 17 nights. 
                    Cruises from the Atlantic or Gulf coasts of the U.S. head 
                    for the Yucatan Peninsula and Caribbean resort towns like Cozumel, while ships 
                    sailing from the West Coast visit Pacific ports like Cabo San Lucas and Ensenada.",
    PeopleNumberSupported = 2100,
    Speed = 4000.5F,
    Origin = "USA",
    Destination = "MEXICO"
};
Console.WriteLine(cruiseObj.GeneralInformation());
Cruise.TurnOn(cruiseObj.Name);
cruiseObj.RaiseAnchor();
cruiseObj.ThrowAnchor();
cruiseObj.RunAground();
Cruise.TurnOff(cruiseObj.Name);
*/

// Part 2
/*
var inst = new Repository();
var list = inst.GetBankList();
foreach (var item in list)
{
    Console.WriteLine($"{item.Id} {item.Name} {item.Description} \n");
}
*/


//Part 3
/*
bool goOn = true;
string? answer;
while (goOn)
{
    Console.WriteLine("1 -Sedan");
    Console.WriteLine("2 -Deportivo");
    Console.WriteLine("3 -Harchback");
    var op = Console.ReadLine();
    if (int.TryParse(op, out int option))
    {
        Creator creator = new();
        var car = creator.CreateCar(option);
        if (car != null)
        {
            Console.WriteLine(car.CarDetail());
            Console.WriteLine("Try again?  s/n");
            answer = Console.ReadLine();
            goOn = answer.Contains("s") || answer.Contains("S");
        }
    }
    Console.Clear();
}
*/
//Part 4
var folio = new Random().Next(10, 150);
var request = new RequestOpt
{ 
    User = "omoran",
    Password= "developExam",
    Opt1 = 10, Opt2 = 20,
};
var log = new Logs();
var repo = new Repository();
var creatorOpt = new CreatorOperation();
string msgDescription;

if (string.IsNullOrEmpty(request.User) || string.IsNullOrEmpty(request.Password) || request.Opt1 <= 0 || request.Opt2 <= 0)
{
    msgDescription = "Validation error.";
    log.InsertLog(msgDescription, folio, "no apply");
    Console.WriteLine(msgDescription);
    
}
else
{
    log.InsertLog("Validation OK", folio, request.User);
    var user = repo.GetUser(request.User,request.Password);
    if (user == null)
    {
        msgDescription = "Authentication error.";
        log.InsertLog(msgDescription, folio, request.User);
        Console.WriteLine(msgDescription);
    }
    else
    {
        log.InsertLog("Authentication OK ", folio, request.User);
        var opt = creatorOpt.GetOperator(3);
        var response = opt.ExecOperation(request.Opt1, request.Opt2);
        log.InsertLog(response < 0 ? "Operation error" : "Operation OK ", folio, request.User);
        Console.WriteLine(response < 0 ? "Operation Error" : $"Process complete , result {response}");
    }
}

Console.ReadLine();






public class RequestOpt
{
    public string User { get; set; } 
    public string Password { get; set; }
    public int Opt1 { get; set; }
    public int Opt2 { get; set; }
}