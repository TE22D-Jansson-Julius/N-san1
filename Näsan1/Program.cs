// Steg 1
if(6>3){
Console.WriteLine("Hello, World!");
}

// Steg 2
string userName = Console.ReadLine();
if (userName == "noname"){
    Console.WriteLine("Welcome!");
}

// Steg 3
string username2 = Console.ReadLine();
string password = Console.ReadLine();
if (userName == "noname" && password == "nopass"){
    Console.WriteLine("Welcome!");
}
    else 
    {
        Console.WriteLine("Wrong username or password");
    }

// Steg 4
for (int i = 0; i < 32; i++){
    Console.WriteLine("Hello World");
}

// Steg 5
string password2 ="";
while (password2 != "nopass"){
password2 = Console.ReadLine();
}

// Steg 6 
for (int i = 0; i < 5; i++)
            {
                Console.Write("Ange ett tal: ");
                string input = Console.ReadLine();
                
                int tal = int.Parse(input);
                
                if (tal > 5)
                {
                    Console.WriteLine("högre än 5!");
                }
            }
        

// Steg 7
string ggez = ""; 
while (!int.TryParse(ggez,out int ggwp))
    {
        ggez=Console.ReadLine();
        
    }


//Steg 8
 Random random = new Random();
            int targetNumber = random.Next(1, 11);
            int guess = 0;
            Console.WriteLine("Gissa ett tal mellan 1 och 10!");
            while (guess != targetNumber)
            {
                Console.Write("Gissa: ");
                if (int.TryParse(Console.ReadLine(), out guess))
                {
                    if (guess < targetNumber)
                    {
                        Console.WriteLine("För lågt :(");
                    }
                    else if (guess > targetNumber)
                    {
                        Console.WriteLine("För högt:(");
                    }
                    else
                    {
                        Console.WriteLine("Rätt gissat:)");
                    }
                }
                else
                {
                    Console.WriteLine("Får inte skriva så:(");
                }
            }