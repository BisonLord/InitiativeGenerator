using System;

class RandomNumber {
  private Random randomNumber = new Random();
  
  public int generateNumber(int minimum, int maximum) {
    return randomNumber.Next(minimum, maximum);
  }
}