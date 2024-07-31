

public interface ICard
{
    public int Mana { get; set; }
    public abstract void DisableCard();
    public abstract void OnClickCard();
}

public interface ICardHelp : ISetDataStart
{
    public abstract void PlayCardHelp();
}