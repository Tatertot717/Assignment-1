using System;
using System.Collections.Generic;


class Poker
{
    PlayingCards deck;
    public List<string> hand1 = new List<string>();
    public List<string> hand2 = new List<string>();

    public void dealHands()
    {
        for (int i = 0; i < 5; i++)
        {
            hand1.Add(deck.getNextCard());
            hand2.Add(deck.getNextCard());
        }
    }

    public Poker()
    {
        deck = new PlayingCards();
        deck.Shuffle();
        dealHands();
    }

    public Poker(List<string> hand1, List<string> hand2)
    {
        this.hand1 = hand1;
        this.hand2 = hand2;
    }

    public void showHand(int a)
    {
        if (a == 1)
        {
            Console.WriteLine("Player 1's Hand:");
            foreach (string String in hand1)
                Console.Write(String + " ");
            Console.Write("\n");
        }

        else
        {
            Console.WriteLine("Player 2's Hand:");
            foreach (string String in hand2)
                Console.Write(String + " ");
            Console.Write("\n");
        }
    }

    public int[] countSuite(List<string> hand)
    {
        //clubs - 0, diamonds - 1, hearts - 2, spades - 3
        int[] count = { 0, 0, 0, 0 };
        foreach (string String in hand)
        {
            if (String.Contains("Clubs"))
                count[0]++;
            if (String.Contains("Diamonds"))
                count[1]++;
            if (String.Contains("Hearts"))
                count[2]++;
            if (String.Contains("Spades"))
                count[3]++;
        }
        return (count);
    }

    public int[] countValues(List<string> hand)
    {
        int[] count = new int[14];
        foreach (string card in hand)
        {
            if (card.Contains("K"))
                count[13]++;
            else if (card.Contains("Q"))
                count[12]++;
            else if (card.Contains("J"))
                count[11]++;
            else if (card.Contains("A"))
                count[1]++;
            else
            {
                string[] split = card.Split(" ");
                int counter = Convert.ToInt32(split[0].Trim());
                count[counter]++;
            }
        }
        return (count);
    }
    public int numPairs(int[] pairs)
    {
        int numpairs = 0;
        foreach (int cards in pairs)
        {
            if (cards == 2)
                numpairs++;
        }
        return (numpairs);
    }

    public int threeOfAKind(int[] pairs)
    {
        int i = 0;
        foreach (int cards in pairs)
        {
            i++;
            if (cards == 3)
                return (i);
        }
        return (0);
    }
    public int fourOfAKind(int[] pairs)
    {
        int i = 0;
        foreach (int cards in pairs)
        {
            i++;
            if (cards == 4)
                return (i);
        }
        return (0);
    }
    public Boolean fullHouse(int[] pairs)
    {
        if (!(threeOfAKind(pairs) == 0) && (numPairs(pairs) > 0))
            return (true);
        return (false);
    }
    public Boolean straight(int[] pairs)
    {
        for (int i = 0; i < 13; i++)
        {
            if ((pairs[i] == 1) && (pairs[i + 1] == 1) && (pairs[i + 2] == 1) && (pairs[i + 3] == 1) && (pairs[i + 4] == 1))
                return (true);
        }
        if ((pairs[1] == 1) && (pairs[10] == 1) && (pairs[11] == 1) && (pairs[12] == 1) && (pairs[13] == 1))
            return (true);
        return (false);
    }
    public Boolean flush(int[] count)
    {
        if (count[0] == 5)
            return (true);
        if (count[1] == 5)
            return (true);
        if (count[2] == 5)
            return (true);
        if (count[3] == 5)
            return (true);
        return (false);
    }
    
  public Boolean straightFlush(int[] suites, int[] counts){
    if(flush(suites)&&straight(counts))
    return(true);
    
    return(false);
  }
  
  
  
  
  
  
  public Boolean royalFlush(int[] count, int[] suite)
    {
        if ((count[1] == 1) && (count[10] == 1) && (count[11] == 1) && (count[12] == 1) && (count[13] == 1)){
          if((suite[0]==5)||(suite[1]==5)||(suite[2]==5)||(suite[3]==5)){
            return(true);
          }}
      
      return(false);
    }
    public string scoreHand(int chooseHand)
    {
      List<string> hand;
      if(chooseHand == 1)
      hand = hand1;
      else
      hand = hand2;
      
      int[] suite = countSuite(hand);
            //Console.WriteLine(suite[0].ToString()+suite[1].ToString()+suite[2].ToString()+suite[3].ToString());
      int[] counts = countValues(hand);
      
      if(royalFlush(counts, suite))
      return("Royal Flush");
      
      if(straightFlush(suite,counts))
      return("Straight Flush");
      
      if(!((fourOfAKind(counts))==0))
      return("Four of a Kind");
      
      if(fullHouse(counts))
      return("Full House");
      
      if(flush(suite))
      return("Flush");
      
      if(straight(counts))
      return("Straight");
      
      if(!((threeOfAKind(counts))==0))
      return("Three of a Kind");
      
      if(numPairs(counts)==2)
      return("2 pairs");

      if(numPairs(counts)==1)
      return("1 pair");
      
      
      return("High Card");
    }












}