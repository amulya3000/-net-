DateTime birthdate = new DateTime(2005, 5, 15);
DateTime currentDate = DateTime.Now;

TimeSpan age = currentDate - birthdate;

int ageInYears = (int)(age.TotalDays / 365.25);

Console.WriteLine("Birthdate: " + birthdate.ToShortDateString());
Console.WriteLine("Current Date: " + currentDate);
Console.WriteLine("Age: " + ageInYears + " years");

DateTime newDate = birthdate.AddDays(10);

Console.WriteLine("Birthdate after 10 days: " + newDate.ToShortDateString());