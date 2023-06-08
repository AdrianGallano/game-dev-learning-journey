var array = new List<string>();
int[] arr = new int[5];
int dataSize = 0;
int x = 5;

for(int i = 0; i < arr.Length; i++){
  arr[i] = ++x;
  dataSize++;

  Console.WriteLine("The length of array is now: " + dataSize);
}


foreach(var num in arr){
  Console.WriteLine("now array has " + num);
}

array.Add("1");
array.Add("2");
array.Add("3");

foreach(var data in array){
  Console.WriteLine("data is " + data);
}

for(int i = 0; i < array.Count; i++){
  Console.WriteLine(array[i]);
}

int indexNumber = array.IndexOf("2");
Console.WriteLine(indexNumber);

var names = new List<string> {"adrian", "alliyah", "denzel", "dominic", "aj", "shawn"};
names.Sort();
Console.WriteLine(string.Join(", ", names));
Console.WriteLine("The name adrian is in names array: " + names.Contains("adrian"));
Console.WriteLine("The index of alliyah in names array is " + names.IndexOf("alliyah"));

