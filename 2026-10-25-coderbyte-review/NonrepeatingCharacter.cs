using System;
using System.Collections.Generic;

class MainClass {
  public static string NonrepeatingCharacter(string str) {
    Dictionary<char, int> counter = new Dictionary<char, int>();

    for(int i = 0; i < str.Length; i++) {
      char character = str[i];
      if (!counter.ContainsKey(character)) {
        counter.Add(character, 1);
      } else {
        counter[character]++;
      }
    }

    for(int i = 0; i < str.Length; i++) {
      if (counter[str[i]] == 1) {
        return str[i].ToString();
      }
    }

    return str;
  }

  static void Main() {
    Console.WriteLine(NonrepeatingCharacter(Console.ReadLine()));
  }
}
