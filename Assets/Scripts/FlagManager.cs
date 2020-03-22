using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlagManager : MonoBehaviour
{
    // 電球を入手したかどうか
    public bool lightBulbFlag = false;

    // シングルトン化=どこからでもアクセスできる（１つしか存在しないから）
    public static FlagManager instance;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
}