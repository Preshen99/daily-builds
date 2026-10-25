using System;
using System.Collections.Generic;

class MainClass {
  public static string BlackjackHighest(string[] strArr) {

    Dictionary<string, int> cardValues = new Dictionary<string, int>() {
      {"two", 2}, {"three", 3}, {"four", 4}, {"five", 5}, {"six", 6},
      {"seven", 7}, {"eight", 8}, {"nine", 9}, {"ten", 10},
      {"jack", 10}, {"queen", 10}, {"king", 10}, {"ace", 11}
    };

    Dictionary<string, int> cardRanks = new Dictionary<string, int>() {
      {"two", 2}, {"three", 3}, {"four", 4}, {"five", 5}, {"six", 6},
      {"seven", 7}, {"eight", 8}, {"nine", 9}, {"ten", 10},
      {"jack", 11}, {"queen", 12}, {"king", 13}, {"ace", 14}
    };

    int totalScore = 0;
    int aceCount = 0;

    foreach (string card in strArr) {
      totalScore += cardValues[card];
      if (card == "ace") aceCount++;
    }

    while (totalScore > 21 && aceCount > 0) {
      totalScore -= 10;
      aceCount--;
    }

    string status = totalScore < 21 ? "below" : (totalScore > 21 ? "above" : "blackjack");

    string highestCard = "";
    int highestRank = -1;

    foreach (string card in strArr) {
      int currentRank = cardRanks[card];

      if (card == "ace" && aceCount == 0) {
        currentRank = 1;
      }

      if (currentRank > highestRank) {
        highestRank = currentRank;
        highestCard = card;
      }
    }

    return $"{status} {highestCard}";
  }

  static void Main() {
    Console.WriteLine(BlackjackHighest(Console.ReadLine().Split(',')));
  }
}
