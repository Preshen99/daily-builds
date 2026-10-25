using System;

class MainClass {
  public static string PrimeTime(int num) {
    // Edge case: Numbers less than or equal to 1 are not prime
    if (num <= 1) return "false";
    if(num == 2) return "true";
    if(num % 2 == 0) return "false";

    for (int i = 3; i * i <= num; i += 2) {
      if (num % i == 0) {
        return "false";
      }
    }

    return "true";
  }

  static void Main() {
    Console.WriteLine(PrimeTime(Convert.ToInt32(Console.ReadLine())));
  }
}
