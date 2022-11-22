Console.WriteLine("Enter a time (HH:MM): ");
string time = Console.ReadLine();

string[] times = time.Split(":");

int hours = Convert.ToInt32(times[0]);
int minutes = Convert.ToInt32(times[1]);

//Minute arrow changes
const int one_min_change = 6; //360 degrees / 60 minutes


//Hour arrow changes
const double one_min_passed = 0.5; // 360 degrees / 12 hours / 60 minutes
const int one_hour_change = 30;//360 degrees / 12 hours


double hourAngle = one_hour_change * hours + (one_min_passed * minutes);

double minuteAngle = minutes * one_min_change;

double Angle_Beetween = hourAngle - minuteAngle;

//There could be wider and sharper angles
//In the example given, we need to calculate sharper angle
//In this situation we use switch

switch (Angle_Beetween)
{
    case > 180:
        Console.WriteLine("Angle beetween arrows: {0} degrees",360 - Angle_Beetween);
        break;
        
    case <= 180:        
        Console.WriteLine("Angle beetween arrows: {0} degrees", Angle_Beetween);
        break;
        
    default:
        Console.WriteLine("Angles are equal");
        break;
}
    
        



