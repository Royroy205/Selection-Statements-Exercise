namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var r = new Random();
            int FavNum = r.Next(1,10);
            int response = 6;
            
          while (response != FavNum)
            Console.Write("enter a number: ");

            response = int.Parse(Console.ReadLine());

            if (response < FavNum)

            {
                Console.WriteLine($"Too low!/myour guess: {response}");
            }
            else if (response > FavNum) 
            
            {
                Console.WriteLine($"Too High!/myour guess: {response}");


            }
            else 
            {
                Console.WriteLine($"Correct! {response} was my favorite number .");
                    
                    
                    
            }
            



        }
    }
}
