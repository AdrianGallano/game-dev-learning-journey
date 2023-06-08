namespace CardWars
{
  class Program
  {

    /* Defining my game

    MEHCANISMS:
    ===================================
    What i want for this card game is to:
    be able to battle with cards
    turn-base
    which means it would have 2 or more players

    GOALS:
    ===================================
    || I also want to level this up by implementing LINQ to provide a database of cards
    || I also want to make this multiplayer using localhost or a server for each player
    || but it would still be a terminal game

    BIG STEPS:
    ===================================
    || CREATE MY GAME
    || CONNECT MY GAME TO A DATABASE
    || MAKE IT MULTIPLAYER

    SMALL STEPS:
    ===================================
    || CREATING MY GAME 
    -- PLAYER
      -- HEALTH

    -- CARDS - CAN BE BUILDINGS, SOLDIERS, AND SPELLS
      -- CARD TYPE - COULD BE MONSTER, HUMAN, ORC, ELVES
      -- PROPERTIES
        -- ATTACK
        -- DEFENSE
        -- CONDITIONS
      
    
    -- LAND 
      -- AREA
      -- BIOME
        -- BIOME PROPERTY
        -- BIOME CONDITIONS

     */


    static void Main(string[] args)
    {
      Console.WriteLine("CARD WARS!");
      Game.Play();
    }
  }
}


