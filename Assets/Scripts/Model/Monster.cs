using Sirenix.OdinInspector.Editor.Drawers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Monster : MonoBehaviour
{
    //DATA IN LEVEL
    private MonsterDT levelMonsterData;
    private int idx, idy;

    //POPUP
    [SerializeField]
    private Image detailPopup;
    [SerializeField]
    private Image leftPopup, rightPopup;

    #region GET SET
    public Monster(MonsterDT monsterData)
    {
        this.levelMonsterData = monsterData;
    }

    public void SetMonsterData(MonsterDT monsterData)
    {
        this.levelMonsterData = monsterData;
    }
    public void SetIdPosition(int x, int y)
    {
        this.idx = x;
        this.idy = y;
        SetPopupPosition();
    }

    public void SetPopupPosition()
    {
        print(this.idx + " " + idy);
        if (this.idy >= 2)
        {
            detailPopup = leftPopup;
            print("left");
        }
        else detailPopup = rightPopup;
    }
    #endregion

    public void Start()
    {
        leftPopup.gameObject.SetActive(false);
        rightPopup.gameObject.SetActive(false);

    }


    #region HANDLE POPUP
    public void OnMouseEnter()
    {
        if(IsOverUI())
        {
            return;
        }
        detailPopup.gameObject.SetActive(true);
        print("on mouse enter");
    }

    public void OnMouseExit()
    {
        detailPopup.gameObject.SetActive(false);
        print("exit");
    }

    public static bool IsOverUI()
    {
        PointerEventData eventDataCurrentPosition = new PointerEventData(EventSystem.current);
        eventDataCurrentPosition.position = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        List<RaycastResult> results = new List<RaycastResult>();
        EventSystem.current.RaycastAll(eventDataCurrentPosition, results);
        return results.Count > 0;
    }
    #endregion
}
