using System;
class Game {
  static void Main() {
    
    Random rnd = new Random();
    int compScore,userScore;//scores
    compScore=0;
    userScore=0;
    int rounds=0;//no of rounds
    string [] options={"rock","paper","scissors"};
    
    // Console.WriteLine(randomChoice);
    while(true){
      Console.WriteLine("Choose either rock paper scissors to play or type 'q' to quit the game");
      string userChoice=Console.ReadLine().ToLower();
      string randomChoice=options[rnd.Next(0, options.Length)];
      
      while (true){
          if(userChoice=="rock" || userChoice=="paper" || userChoice=="scissors" || userChoice=="q"){
              break;
          }
          else{
              Console.WriteLine("Choose a valid option");
               userChoice=Console.ReadLine().ToLower();
          }
      }//end of while inner
      
      //start of game logic
    
     if(userChoice==randomChoice){
           rounds+=1;
         Console.WriteLine($"Draw , You chose  {userChoice}  and computer chose  {randomChoice}");
     }
     else if(userChoice=="rock"){
           rounds+=1;
         
         if(randomChoice=="paper"){
             Console.WriteLine($"You Lost , You chose  {userChoice}  and computer chose  {randomChoice}");
             compScore+=1;
         }
         else{
             Console.WriteLine($"You won , You chose  {userChoice}  and computer chose  {randomChoice}");
             userScore+=1;
         }
     }// condition 2
     
     else if(userChoice=="paper"){
           rounds+=1;
         if(randomChoice=="scissors"){
             Console.WriteLine($"You Lost , You chose  {userChoice}  and computer chose  {randomChoice}");
              compScore+=1;
         }
         else{
             Console.WriteLine($"You won , You chose  {userChoice}  and computer chose  {randomChoice}");
              userScore+=1;
         }
     }//condition 3
     
     
     else if(userChoice=="scissors"){
           rounds+=1;
         
         if(randomChoice=="rock"){
             Console.WriteLine($"You Lost , You chose  {userChoice}  and computer chose  {randomChoice}");
             compScore+=1;
         }
         else{
             Console.WriteLine($"You won , You chose  {userChoice}  and computer chose  {randomChoice}");
             userScore+=1;
         }
         
     }//condition 4
     else if(userChoice=="q"){
         break;
     }

      
    }
    // end of while outer
    
    Console.WriteLine($"You played {rounds} rounds Your final score is : {userScore} and Computer scored : {compScore}");
    if(userScore>compScore && rounds>0){
        Console.WriteLine("You Won the game");
    }
    else if (userScore==compScore && rounds>0){
        Console.WriteLine("Draw");
    }
    else{
        Console.WriteLine("You Lost the game");
    }
    
  }
  
}
