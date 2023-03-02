class Program {
    static void Main(string[] args) {
        Console.Write("Input Password(6 digits): ");
        int Pass = int.Parse(Console.ReadLine());
        
        int d6 = Pass / 100000 % 10;
        int d5 = Pass / 10000 % 10;
        int d4 = Pass / 1000 % 10;
        int d3 = Pass / 100 % 10;
        int d2 = Pass / 10 % 10;
        int d1 = Pass / 1 % 10;

        if (!(Pass <= 999999 && Pass >= 99999) )
            Console.WriteLine("Please put Your 6 digits Password ");

        Console.Write("Input your Agency: ");
        string y = (Console.ReadLine());

        if (y == "CIA") {
            if(d1 % 3 == 0 && d2 != 1 && d2 != 3 && d2 != 5 && d4 > 6 && d4 < 8){
                Console.WriteLine("Valid Password");
            } else {
                Console.WriteLine("Invalid Password"); 
            }
    }
            
        if (y == "FBI") {
            if (d6 >= 4 && d6 <= 7 && d3 % 2 == 0 && d3 % 6 != 0 && d5 % 2 != 0) {
                Console.WriteLine("Valid Password");
            } else {
                Console.WriteLine("Invalid Password");   
            }
        }
        if (y == "NSA") {
            if (d2 == 7 || d4 == 7 || d5 == 7 || d6 == 7 && d1 % 30 == 0 && d3 % 2 != 0 && d3 % 3 == 0 && d3 != 7 && d1 != 7) {
                Console.WriteLine("Valid Password");
            } else {
                Console.WriteLine("Invalid Password");
            }
        }

                

    }
}

