
using System;
class Guess {
  static void Main() {
    
    Random rnd = new Random();
    int score=0;
    
    while(true){
        int randomNumber=rnd.Next(1, 10);
        Console.WriteLine("Guess a number between 1-10 to play and type 0 to quit");
        int userChoice=Convert.ToInt32(Console.ReadLine());
        while(true){
            if(userChoice==0 ||userChoice==1 || userChoice==2 || userChoice==3 || userChoice==4 || userChoice==5 || userChoice==6 || userChoice==7 || userChoice==8 || userChoice==9 || userChoice==10){
               break;
            }
            else{
                 Console.WriteLine("Choose a valid option");
                 userChoice=Convert.ToInt32(Console.ReadLine());
            }
        }
        //end of inner while
        if(userChoice==randomNumber){
            Console.WriteLine("Your Guess is correct");
            score+=1;
        }
        
        else if(userChoice==0){
            break;
        }
        else{
            Console.WriteLine("Wrong Guess");
        }
        
        
        
    }//end of outer while
 
  Console.WriteLine($"Your Final Score is : {score}");
  }
  
}
