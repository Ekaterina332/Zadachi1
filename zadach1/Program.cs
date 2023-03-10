// Напишите программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее
Console.Clear(); 
Console.WriteLine("Введите два числа: ");
int n1 = Convert.ToInt32(Console.ReadLine());
int n2 = Convert.ToInt32(Console.ReadLine());

if (n1 > n2){
    Console.Write("max=");
    Console.WriteLine(n1);
}    
else{
    Console.Write("max=");
    Console.WriteLine(n2);
}    
