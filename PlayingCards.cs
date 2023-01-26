using System;
using System.Collections.Generic;

class PlayingCards {
  private List<string> deck = new List<string>();

  public PlayingCards() {
    string[] suite = new string[] {"Clubs","Diamonds","Hearts","Spades"};
    string[] values= new string[] {"A","2","3","4","5","6","7","8","9","10","J","Q","K"};
    for(int i=0;i<4;i++) {
      for(int j=0;j<13;j++) {
        string newCard=values[j]+" of "+suite[i];
        deck.Add(newCard);
      }
    }
  }

  public void Shuffle() {
    Random myRand=new Random();
    int numShuffles=myRand.Next(500);
    int numCards=deck.Count;
    for(int i=0;i<numShuffles;i++) {
      int cardOne=myRand.Next(numCards);
      int cardTwo=myRand.Next(numCards);

      String tempCard=deck[cardOne];
      deck[cardOne]=deck[cardTwo];
      deck[cardTwo]=tempCard;
    }
  }

  public string getNextCard() {
    string nc;
    if(deck.Count>0) {
      nc=deck[0];
      deck.RemoveAt(0);
    }
    else {
      nc="Deck is empty";
    }
    return nc;
  }
}