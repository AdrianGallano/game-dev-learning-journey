

// Program 1
Console.WriteLine("Name: Adrian Cris Gallano");

// Program 2
Console.WriteLine("Name: " + "Adrian Cris Gallano");

// Program 3
string name = "Adrian Gallano";
Console.WriteLine("Name: " + name);

// Program 4 - String Interpolation
Console.WriteLine($"Name: {name}"); 

// Program 5 - String Interpolation part 2
string megaIdok = "oyam";
Console.WriteLine($"My name is {name} and my bestfriend is {megaIdok}");

// Program 6 - the Length Property
Console.WriteLine($"My name is {name} and it has {name.Length} letters");

// Program 7 - Trimming
string sampleSentence = "    A Quick Fox is here    ";
Console.WriteLine($"[{sampleSentence.TrimStart()}]");
Console.WriteLine($"[{sampleSentence.TrimEnd()}]");
Console.WriteLine($"[{sampleSentence.Trim()}]");

// Program 8 - Replace

string sentence = "I love apple because apple is delicious";
string newSentence =  sentence.Replace("apple", "orange");
Console.WriteLine(newSentence);

// Program 9 - Upper and Lower
string newName = "Adrian Gallano";
Console.WriteLine(newName.ToLower());
Console.WriteLine(newName.ToUpper());
Console.WriteLine(newName);

// Program 10 = Contains
Console.WriteLine(sentence.Contains("love"));
Console.WriteLine(sentence.Contains("hate"));

// Program 11 = Starts With
Console.WriteLine(sentence.StartsWith("I love"));
Console.WriteLine(sentence.StartsWith("love"));

// Program 12 = EndsWith
Console.WriteLine(sentence.EndsWith("delicious"));
Console.WriteLine(sentence.EndsWith("is"));
Console.Beep();