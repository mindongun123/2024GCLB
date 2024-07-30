
public enum EnumsStateGame
{
    None, Player, Monster, End, Loading
}


public enum EnumsNameCard
{
    CardNormal, CardShrededShot, CardShield, CardShuriken, CardHeal, CardDummy// 6 card
}

public enum EnumsNameMonster
{
    Kappo, Ripper, Pam, Caster, Magaritta, Scarlett, Otto, Modarlo, Kazuhna, Gavoc// 10 monster
}

public enum EnumsStateMonster
{
    Attack, None, Hurt, Armor, IncreasedDame, Blind// Tan cong, Khong lam gi, Bi thuong, Co giap, Tang dame, Mu
}

public static class Enums
{
    public static EnumsStateGame stateGame = EnumsStateGame.None;
}
