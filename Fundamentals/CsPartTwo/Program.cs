Console.ForegroundColor = ConsoleColor.Green;

bool run = true;
string usernameInput = null;
string passwordInput = null;
while(run){

    Console.WriteLine("REGISTER PANEL");

    Console.Write("Enter your username: ");
    usernameInput = Console.ReadLine();

    if(usernameInput.Length < 8){
      Console.WriteLine("Username length is less than 8, please try again.");
      Console.WriteLine("Press any key to continue.");
      Console.ReadKey();
      Console.Clear();
      continue;
    }else{
      break;
    }

}

while(run){
    Console.Write("Enter your password: ");
    passwordInput = Console.ReadLine();

    if(passwordInput.Length < 8){
      Console.WriteLine("Password length is less than 8, please try again.");
      Console.WriteLine("Press any key to continue.");
      Console.ReadKey();
      Console.Clear();
      continue;
    }else{
      break;
    }
}
Console.Clear();
Console.Beep();

Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.WriteLine("Succesfully Registered!");

Console.ForegroundColor = ConsoleColor.Magenta;

Console.ReadLine();


string username;
string password;

while(run){

    Console.WriteLine("LOGIN PANEL");

    Console.Write("Enter your username: ");
    username = Console.ReadLine();

    if(username != usernameInput){
      Console.WriteLine("username incorrect");
      Console.WriteLine("Press any key to continue.");
      Console.ReadKey();
      Console.Clear();
      continue;
    }else{
      break;
    }
}

while(run){
    Console.WriteLine("LOGIN PANEL");

    Console.Write("Enter your password: ");
    password = Console.ReadLine();

    if(password != passwordInput){
      Console.WriteLine("password incorrect");
      Console.WriteLine("Press any key to continue.");
      Console.ReadKey();
      Console.Clear();
      continue;
    }else{
      break;
    }
}

Console.WriteLine("CONGRATULATIONS YOU HAVE LOGGED IN SUCCESSFULLY.");
Console.WriteLine("Press any key to continue.");
Console.ReadKey();