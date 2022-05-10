insuree.Quote = 500;
 
           int age = DateTime.Now.Year - insuree.DateOfBirth.Year;
 
 
 
           if (age <= 18)
           {
               insuree.Quote = insuree.Quote + 100;
           }
 
           if (age >= 19 && age <= 25)
           {
               insuree.Quote = insuree.Quote + 50;
           }
 
           if (insuree.CarYear < 2000 || insuree.CarYear > 2015)
           {
               insuree.Quote = insuree.Quote + 25;
           }
 
           if (insuree.CarMake == "Porsche" || insuree.CarMake == "porsche")
           {
               insuree.Quote = insuree.Quote + 25;
           }
 
           if (insuree.CarMake == "Porsche" || insuree.CarMake == "porsche" && insuree.CarModel == "911 Carrera")
           {
               insuree.Quote = insuree.Quote + 25;
           }
 
           if (insuree.SpeedingTickets > 0)
           {
               insuree.Quote = insuree.Quote + (insuree.SpeedingTickets * 10);
           }
 
           if(insuree.DUI == true)
           {
               insuree.Quote = insuree.Quote + (insuree.Quote * 0.25);
           }
 
           if(insuree.CoverageType == true)
           {
               insuree.Quote = insuree.Quote + (insuree.Quote * 0.25);
           }