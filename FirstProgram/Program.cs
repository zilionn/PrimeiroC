using System;

class Program {
    static void Main(string[] args) {
        for (int i = 0; i < 5; i++) {
            int x = int.Parse(Console.ReadLine());
            if (x == 5 || x ==0) {
                Console.WriteLine("Pls, seja mais criativo");
            } else {
                Console.WriteLine("Ok, computando...");
            }
            Console.WriteLine("Valor é: " +x);

        }
    }
}
