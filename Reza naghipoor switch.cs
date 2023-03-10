

// Reza Naghipoor  switch project





string x = "y";
string y = "n";
ConsoleKeyInfo key;




string a = "n";


Console.WriteLine("Did you go to military service?:    ");
string input = Console.ReadLine();
if(input.ToLower () == "n")
{
    Console.WriteLine( "are you over 21");

    if (a.ToLower() == "y") { Console.WriteLine("You can't get loan"); }

}


bool SWitch()
{

  
    {
       
        switch (x)
        {
            case "y" or "Y":
               
                if (input.ToLower() == "y")
                    Console.WriteLine("Are you married?:    ");
                
                input = Console.ReadLine();
                if (input.ToLower() == "y") { Console.WriteLine("You can get 10000 dollar loan"); }
                else if (input.ToLower() == "n") { Console.WriteLine("Do you want to get married in the next two months?:    "); }
                
               string output = Console.ReadLine();
                if (output.ToLower() == "y") { Console.WriteLine("You can get 100 dollar loan"); }
                else if (output.ToLower() == "n") { Console.WriteLine("you can't get a loan"); }
                break;
                

        }
        

    }


    return true;

}


void Lock()
{
    do
    {

        key = Console.ReadKey(true);

    } while (key.KeyChar.ToString() != "y" && key.KeyChar.ToString() != "n"&& key.Key.ToString() != "Enter");
}






    
    
    do
    {
        Lock();

        SWitch();

    } while (key.Key.ToString() != "Enter");

    Console.WriteLine();



    



    




















