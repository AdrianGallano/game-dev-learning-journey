using System.Diagnostics;
using Immutability;



Person p1 = new Person("Adrian", "Gallano", 202211194);
Person p2 = new Person("Adrian", "Gallano", 202211194);
Person p3 = p2;
Person p4 = p1 with {FirstName = "Someone"};

Debug.WriteLine(p1);
Debug.WriteLine(p2);
Debug.WriteLineIf(p1 == p2, "Two object have value equality");
Debug.WriteLineIf(ReferenceEquals(p1, p2), $"Two object have reference equality {nameof(p1)} and {nameof(p2)}");
Debug.WriteLineIf(ReferenceEquals(p2, p3), $"Two object have reference equality {nameof(p2)} and {nameof(p3)}");

Debug.WriteLine($"The value of {nameof(p4)} is {p4}");
Debug.WriteLineIf(p1 == p4, $"Two object have value equality {nameof(p1)} and {nameof(p4)}");