using System;

string room = "classroom";

while (room != "exit")
{
    if (room == "classroom")
    {
        Console.WriteLine("you are in classroom");
        Console.WriteLine("Where do you want to go?");
        string where = Console.ReadLine();

        if (where == "hall")
        {
            room = "hall";
        }
        else
        {
            Console.WriteLine("What?");
        }
    }
    else if (room == "labb")
    {
        Console.WriteLine("you are in the labb");
        Console.WriteLine("Where do you want to go?");
        string where = Console.ReadLine();


     
        if (where == "hall")
        {
            room = "hall";
        }
        else
        {
            Console.WriteLine("What?");
        }

    }
    else if (room == "hall")
    {
        Console.WriteLine("you are in the hall");
        Console.WriteLine("Where do you want to go?");
        string where = Console.ReadLine();


        if (where == "classroom")
        {
            room = "classroom";
        }
        else if (where == "labb")
        {
            room = "labb";
        }
        else
        {
            Console.WriteLine("What?");
        }

    }
}