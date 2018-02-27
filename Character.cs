using System;

class Character : IComparable<Character> {
  public string CharacterName { get; set; }
  public int Initiative { get; set; }
  
  public Character(string characterName) {
    this.CharacterName = characterName;
  }
    
  public void rollForInitiative(RandomNumber numberGenerator) {
    this.Initiative = numberGenerator.generateNumber(1 , 20);
  }
  
  public int CompareTo(Character comparedCharacter) {
    if (this.Initiative > comparedCharacter.Initiative) {
      return -1;
    } else if (this.Initiative == comparedCharacter.Initiative) {
      return 0;
    } else {
      return 1;
    }
  }
}