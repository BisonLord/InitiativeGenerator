using System;

class PlayerCharacter : IComparable<PlayerCharacter> {
  public string PlayerCharacterName { get; set; }
  public int Initiative { get; set; }
  
  public PlayerCharacter(string characterName) {
    this.PlayerCharacterName = characterName;
  }
    
  public void rollForInitiative(RandomNumber numberGenerator) {
    this.Initiative = numberGenerator.generateNumber(1 , 20);
  }
  
  public int CompareTo(PlayerCharacter comparedCharacter) {
    if (this.Initiative > comparedCharacter.Initiative) {
      return -1;
    } else if (this.Initiative == comparedCharacter.Initiative) {
      return 0;
    } else {
      return 1;
    }
  }
}