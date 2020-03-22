using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawerManager : MonoBehaviour
{
    [SerializeField] GameObject lightBulbPanel;
    [SerializeField] GameObject alertText;
    [SerializeField] ItemBoxManager itemBoxManager;

    void Start()
    {
        LightBulbSetActive(false);
    }

    void LightBulbSetActive(bool isShow)
    {
        lightBulbPanel.SetActive(isShow);
        alertText.SetActive(isShow);
    }

    // 引き出しが押されたら
    // 1.電球の画像をだす
    // 2.Textをだす
    public void OnClickTrigger()
    {
        if (FlagManager.instance.lightBulbFlag)
        {
            return; // 処理をここで返す（以下は実行されない）
        }
        LightBulbSetActive(true);
        itemBoxManager.SetItem(ITEM.LIGHT_BULB);
        FlagManager.instance.lightBulbFlag = true;
    }

    // 電球の画像をクリックすると電球画像を非表示にする
    public void OnClickImage()
    {
        LightBulbSetActive(false);
    }
}