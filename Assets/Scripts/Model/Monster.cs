using MJGame;
using Spine.Unity;
using UnityEngine;
public class Monster : MonoBehaviour
{

    public MonsterAnimation monsterAnimation;
    private MonsterDT levelMonsterData;
    public Vector2Int keyPosition;


    public Monster(MonsterDT monsterData)
    {
        this.levelMonsterData = monsterData;
    }

    public void SetMonsterData(MonsterDT monsterData, Vector2Int keyPosition)
    {
        this.levelMonsterData = monsterData;
        this.keyPosition = keyPosition;
    }

    private void OnMouseDown()
    {
        SingletonComponent<HandleGamePlay>.Instance.SelectMonster(this);
    }


}