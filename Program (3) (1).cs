

//Reza Naghpoor                       Score project



int y;

int score;

string yesorno;

ConsoleKeyInfo key;

do
{
    Console.Write("\n Enter scores:    ");
    score = 0;
    do
    {
        Lock();

        Key();

    } while (key.Key.ToString() != "Enter");

    Console.WriteLine();

    y = score * 5;

    Score();

    Console.WriteLine("\n Do you want to continue? ( Press y Or n)");

    YN();

} while (yesorno.ToLower() == "y");

Console.WriteLine(" \n thanks to use this project");



void Lock()
{
    do
    {

        key = Console.ReadKey(true);

    } while (key.KeyChar.ToString() != "0" && key.KeyChar.ToString() != "1" && key.KeyChar.ToString() != "2" &&
            key.KeyChar.ToString() != "3" && key.KeyChar.ToString() != "4" && key.KeyChar.ToString() != "5" &&
            key.KeyChar.ToString() != "6" && key.KeyChar.ToString() != "7" && key.KeyChar.ToString() != "8" &&
            key.KeyChar.ToString() != "9" && key.Key.ToString() != "Enter");
}

void Key()
{
    if (key.Key.ToString() != "Enter")
    {
        score = score * 10 + Convert.ToInt32(key.KeyChar.ToString());

        Console.Write(key.KeyChar);
    }
}
void YN()
{
    do
    {
        yesorno = Console.ReadKey(true).KeyChar.ToString();


    } while (yesorno.ToLower() != "y" & yesorno.ToLower() != "n");
}

void Score()
{



    if (score > 17 && score <= 20)
    {

        Console.WriteLine("This is your score:   " + score);
        Console.WriteLine("This is your percentage:  " + y);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("You got A rank");
        Console.ResetColor();

    }
    else if (score > 15 && score <= 17)
    {
        Console.WriteLine("This is your score:   " + score);
        Console.WriteLine("This is your percentage:  " + y);
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("You got B rank");
        Console.ResetColor();

    }
    else if (score >= 10 && score <= 15)
    {

        Console.WriteLine("This is your score:   " + score);
        Console.WriteLine("This is your percentage:  " + y);
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("You got C rank");
        Console.ResetColor();
    }
    else if (score > 0 && score < 10)
    {

        Console.WriteLine("This is your score:   " + score);
        Console.WriteLine("This is your percentage:  " + y);
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("You got Failed rank");
        Console.ResetColor();
    }
    else
    {
        Console.WriteLine("Invaild........");


    }
}


Console.ReadKey();
