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
