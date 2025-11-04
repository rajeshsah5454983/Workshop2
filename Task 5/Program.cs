  
DateTime birthDate = new DateTime(2004, 9, 14); 

DateTime currentDate = DateTime.Now;

       
TimeSpan ageSpan = currentDate - birthDate;
double ageInYears = ageSpan.TotalDays / 365.25; // Convert days to years approximately

        
Console.WriteLine($"Birthdate: {birthDate.ToShortDateString()}");
Console.WriteLine($"Current Date: {currentDate.ToShortDateString()}");
Console.WriteLine($"Your Age: {Math.Floor(ageInYears)} years");

        
DateTime newDate = birthDate.AddDays(10);
Console.WriteLine($"Date after adding 10 days to your birthdate: {newDate.ToShortDateString()}");