#region Game
public enum EnumsStateGame
{
    None, Start, Player, Monster, Loading, End
}
#endregion

#region Card
public enum EnumsNameCard
{
    CardNormal, CardShrededShot, CardShield, CardShuriken, CardHeal, CardDummy// 6 card
}
#endregion

#region Monster
public enum EnumsNameMonster
{
    MonsterKappo, MonsterRipper, MonsterPam, MonsterCaster, MonsterMagaritta, MonsterScarlett, MonsterOtto, MonsterModarlo, MonsterKazuhna, MonsterGavoc// 10 monster
}

public enum EnumsStateMonster
{
    Attack, None, Hurt, Armor, IncreasedDame, Blind// Tan cong, Khong lam gi, Bi thuong, Co giap, Tang dame, Mu
}
#endregion

#region Gun
public enum EnumsNameGun
{
    GunRifle, GunElectric, GunNerf, GunScanner, GunFlameThrower, GunLazerCanon
}

public enum EnumsTypeGun
{
    SingleUse, Normal, Effect, Burn
}

public enum EnumsEffectGun
{
    None, Burn, SkipArmor, Stunned, DisabledSelect, ReduceDamage, AccumulateDamage
}
#endregion



public static class Enums
{
    public static EnumsStateGame stateGame = EnumsStateGame.None;
}
