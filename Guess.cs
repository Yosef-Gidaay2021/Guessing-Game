

public class Guess{
    private readonly int userGuess;
    private readonly DateTime _guessTime;

    public Guess(int userGuess){
        this.userGuess = userGuess;
        this._guessTime = DateTime.Now;
    }   
}