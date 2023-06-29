using System.Text;

namespace Anonymous;

enum MenuOptions
{
  Add,
  Get,
  Exit
}


internal static class Menu
{
  internal static void ShowMenuOptions()
  {
    StringBuilder menuOptionsText = new StringBuilder();
    MenuOptions[] menuOptions = (MenuOptions[])Enum.GetValues(typeof(MenuOptions));

    menuOptionsText.AppendLine("MENU\n");

    int MenuNumber = 1;
    foreach (MenuOptions option in menuOptions)
    {
      menuOptionsText.AppendLine($"[{MenuNumber++}] => {option}");
    }

    menuOptionsText.Append($"Enter your option: ");
    Console.WriteLine(menuOptionsText);
  }

  internal static int GetOption()
  {
    int option = Convert.ToInt16(Console.ReadLine());

    return option;
  }

  internal static void MenuDecision(int option)
  {

    State state;
    switch (option)
    {

      case 1:
        string name = GetName();
        state = GetState();
        Program.notebook.AddNote(name, state);

        break;

      case 2:
        state = GetState();

        int number = 1;
        foreach (var note in Program.notebook.GetNotes(state))
        {
          Console.WriteLine($"{number++} {note}");
        }
        Console.ReadKey();
        break;

      case 3:
        Program.Run = false;
        Console.WriteLine("Thank you for using our program.");

        break;

      default:
        break;
    }
  }

  internal static string GetName()
  {
    Console.Write("Enter the name of your note: ");

    string? name = Console.ReadLine();

    return name == null ? "No name" : name;
  }

  internal static State GetState()
  {
    State[] AllStates = (State[])Enum.GetValues(typeof(State));

    int StateNumber = 1;

    foreach (State state in AllStates)
    {
      Console.WriteLine($"[{StateNumber++}] => {state}");
    }

    Console.Write("Enter your state option: ");
    int stateOption = Convert.ToInt16(Console.ReadLine());
    return stateDecision(stateOption);
  }

  internal static State stateDecision(int stateOption)
  {
    switch (stateOption)
    {
      case 1:
        return State.active;
      case 2:
        return State.completed;
      case 3:
        return State.others;
      default:
        Console.WriteLine("State doesn't exist. Will put 'others' automatically.");
        return State.others;
    }
  }
}