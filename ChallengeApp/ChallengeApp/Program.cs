string name = "Ewa";
bool isWoman = false;
int myAge = 80;


if (isWoman == true && myAge < 30)
{
    Console.WriteLine("Women under 30 years old");
}
else if (name == "Ewa" && myAge == 33 && isWoman == true)
{
    Console.WriteLine("Ewa 33 years old");
}
else if (isWoman == false && myAge <18)
{
    Console.WriteLine("Male under 18 years old");
}
else 
{
    Console.WriteLine("Retirement date");
}

