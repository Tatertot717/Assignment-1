using System;
using System.Collections.Generic;

class Program {
    public static List<String> testHand1() {
    List<String> h1 = new List<String>();
    h1.Add("A of Hearts");
    h1.Add("K of Hearts");
    h1.Add("Q of Hearts");
    h1.Add("J of Hearts");
    h1.Add("10 of Hearts");
    return h1;
  }
  
  public static List<String> testHand2() {
    List<String> h1 = new List<String>();
    h1.Add("9 of Hearts");
    h1.Add("K of Hearts");
    h1.Add("Q of Hearts");
    h1.Add("J of Hearts");
    h1.Add("10 of Hearts");
    return h1;
  }
  
  public static List<String> testHand3() {
    List<String> h1 = new List<String>();
    h1.Add("9 of Hearts");
    h1.Add("9 of Spades");
    h1.Add("9 of Clubs");
    h1.Add("9 of Diamonds");
    h1.Add("2 of Hearts");
    return h1;
  }

  public static List<String> testHand4() {
    List<String> h1 = new List<String>();
    h1.Add("9 of Hearts");
    h1.Add("9 of Spades");
    h1.Add("2 of Clubs");
    h1.Add("2 of Diamonds");
    h1.Add("2 of Hearts");
    return h1;
  }
  
  public static List<String> testHand5() {
    List<String> h1 = new List<String>();
    h1.Add("2 of Hearts");
    h1.Add("9 of Hearts");
    h1.Add("A of Hearts");
    h1.Add("3 of Hearts");
    h1.Add("7 of Hearts");
    return h1;
  }
  
  public static List<String> testHand6() {
    List<String> h1 = new List<String>();
    h1.Add("5 of Hearts");
    h1.Add("8 of Clubs");
    h1.Add("9 of Diamonds");
    h1.Add("7 of Spades");
    h1.Add("6 of Hearts");
    return h1;
  }
  
  public static List<String> testHand7() {
    List<String> h1 = new List<String>();
    h1.Add("A of Hearts");
    h1.Add("A of Clubs");
    h1.Add("A of Spades");
    h1.Add("3 of Hearts");
    h1.Add("7 of Hearts");
    return h1;
  }

  public static List<String> testHand8() {
    List<String> h1 = new List<String>();
    h1.Add("A of Hearts");
    h1.Add("A of Clubs");
    h1.Add("7 of Spades");
    h1.Add("3 of Hearts");
    h1.Add("7 of Hearts");
    return h1;
  }

  public static List<String> testHand9() {
    List<String> h1 = new List<String>();
    h1.Add("A of Hearts");
    h1.Add("A of Clubs");
    h1.Add("7 of Spades");
    h1.Add("3 of Hearts");
    h1.Add("K of Hearts");
    return h1;
  }
  
  public static List<String> testHand10() {
    List<String> h1 = new List<String>();
    h1.Add("A of Hearts");
    h1.Add("4 of Clubs");
    h1.Add("7 of Spades");
    h1.Add("3 of Hearts");
    h1.Add("K of Hearts");
    return h1;
  }
  public static void Main (string[] args) {
    List<String> royal = testHand1();
    List<String> straightFlush= testHand2();
    List<String> fourKind= testHand3();
    List<String> fullHouse= testHand4();
    List<String> flush= testHand5();
    List<String> straight= testHand6();
    List<String> threeKind= testHand7();
    List<String> twoPair= testHand8();
    List<String> onePair= testHand9();
    List<String> highCard= testHand10();
    
    Console.WriteLine();
    Poker gameOne=new Poker(royal,straightFlush);
    gameOne.showHand(1);
    Console.WriteLine(gameOne.scoreHand(1));
    gameOne.showHand(2);
    Console.WriteLine(gameOne.scoreHand(2));
    
    Console.WriteLine();
    Poker gameTwo=new Poker(fourKind,fullHouse);
    gameTwo.showHand(1);
    Console.WriteLine(gameTwo.scoreHand(1));
    gameTwo.showHand(2);
    Console.WriteLine(gameTwo.scoreHand(2));
    
    Console.WriteLine();
    Poker gameThree=new Poker(flush,straight);
    gameThree.showHand(1);
    Console.WriteLine(gameThree.scoreHand(1));
    gameThree.showHand(2);
    Console.WriteLine(gameThree.scoreHand(2));
    
    Console.WriteLine();
    Poker gameFour=new Poker(threeKind,twoPair);
    gameFour.showHand(1);
    Console.WriteLine(gameFour.scoreHand(1));
    gameFour.showHand(2);
    Console.WriteLine(gameFour.scoreHand(2));
    
    Console.WriteLine();
    Poker gameFive=new Poker(onePair,highCard);
    gameFive.showHand(1);
    Console.WriteLine(gameFive.scoreHand(1));
    gameFive.showHand(2);
    Console.WriteLine(gameFive.scoreHand(2));
    
    Console.WriteLine();
    Poker gameSix=new Poker();
    gameSix.showHand(1);
    Console.WriteLine(gameSix.scoreHand(1));
    gameSix.showHand(2);
    Console.WriteLine(gameSix.scoreHand(2));
  }
}