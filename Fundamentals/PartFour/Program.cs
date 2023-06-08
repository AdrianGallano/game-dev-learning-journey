
static bool isPrime(long number){
    

  if(number < 2) return false; 
  if(number == 2 || number == 3) return true;

  for(int i = 2; i < number; i++){
    if(number % i == 0){
      return false;
    }
  }
  return true;
}

// for(int i = 1; i < 100; i++){
//   bool x = isPrime(i);
//   Console.WriteLine($"{i} is prime: {x}");
// }
double x = Math.Sqrt(600851475142);
int y = (int) Math.Floor(x);
for(long i =  y; i > 1; i--){
  if(isPrime(i) && 600851475143 % i == 0){
    Console.WriteLine("Prime Factor: "+ i);
    break;
  } 
}
