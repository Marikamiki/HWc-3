

// Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да


Console.Clear();

Console.Write("Enter a 5 digit number: ");
string? number = Console.ReadLine();

void CheckingNumber(string number){
  if (number[0]==number[4] || number[1]==number[3]){
    Console.WriteLine($"The number: {number} - is palindrome.");
  }
  else Console.WriteLine($"The number: {number} - isn't palindrome.");
}

if (number!.Length == 5){
  CheckingNumber(number);
}
else Console.WriteLine($"enter correct number");

