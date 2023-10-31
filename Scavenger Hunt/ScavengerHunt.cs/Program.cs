Console.WriteLine("Welcome to Scavenger Hunt");
Console.WriteLine("Type 'e' for easy questions or 'h' for hard questions");
var difficulty = Console.ReadLine();
Console.WriteLine("Press ENTER to continue to questions: ");
Console.ReadLine();

var score = 0;

if(difficulty=="e"){
  Console.WriteLine("Welcome to the EASY questions: ");
  Console.WriteLine("Q1) What is the phone number for the Treaty 1 office?");
  var A1 = Console.ReadLine();
  if(A1=="204-783-3110"){
    score++;
    Console.WriteLine("CORRECT!!! Your Score is: " + score);
  }else{
    Console.WriteLine("WRONG!!!  Your Score is: " + score);
  }

  Console.WriteLine("Q2) When and where was Treaty 1 negotiated and entered? (Month, Year, Place)");
  var A2 = Console.ReadLine().ToLower();
  if(A2=="august, 1871, lower fort garry"){
    score++;
    Console.WriteLine("CORRECT!!! Your Score is: " + score);
  }else{
    Console.WriteLine("WRONG!!!  Your Score is: " + score);
  }

  Console.WriteLine("Q3) What province was Treaty 1 signed in?");
  var A3 = Console.ReadLine().ToLower();
  if(A3=="manitoba"){
    score++;
    Console.WriteLine("CORRECT!!! Your Score is: " + score);
  }else{
    Console.WriteLine("WRONG!!!  Your Score is: " + score);
  }
}
  

if(difficulty=="h"){
  Console.WriteLine("Welcome to the HARD questions: ");
  
}