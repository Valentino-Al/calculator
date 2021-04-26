using System;

 namespace calculator
 {
    class calculator
    {
            static void Main(string[] args)
            {
                int firstNum;
                int secondNum;                   
                string operation;
                int answer;

                Console.WriteLine("Hello Manieeez!, Selamat datang di kalkulator Valentino yey!");
                Console.ReadLine();

                Console.Write("Masukkan angka pertama ya maniezz: ");
                firstNum = Convert.ToInt32(Console.ReadLine());                             

                //User input for equation
                Console.Write("Sekarang masukkan angka kedua: ");
                secondNum = Convert.ToInt32(Console.ReadLine());
                Console.Write("Yuk mau pilih yang mana ( x , / , +, -) ");
                operation = Console.ReadLine();

                if (operation == "x")
                {
                   answer = firstNum * secondNum;
                   Console.WriteLine(firstNum + " x " + secondNum + " = " + answer);
                   Console.ReadLine();
                }
                else if (operation == "/")
                {
                   answer = firstNum / secondNum;
                   Console.WriteLine(firstNum + " / " + secondNum + " = " + answer);
                   Console.ReadLine();
                }                                                                           
                //Getting answers
                else if (operation == "+")
                {
                   answer = firstNum + secondNum;
                   Console.WriteLine(firstNum + " + " + secondNum + " = " + answer);
                   Console.ReadLine();
                }
                else if (operation == "-")
                {
                   answer = firstNum - secondNum;
                   Console.WriteLine(firstNum + " - " + secondNum + " = " + answer);
                   Console.ReadLine();
                }
                else
                {
                   Console.WriteLine("Sorry that is not correct format! Please restart!");     //Catch
                   Console.ReadLine();
                }
           }
     }
}