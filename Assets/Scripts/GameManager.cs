using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public enum PANEL
{
    ROOM,
    LIGHT_STAND,
    DRAWER,
    PC
}

public class GameManager : MonoBehaviour
{
    // 各パネルを取得
    public GameObject lightStandPanel;
    public GameObject drawerPanel;
    public GameObject pcPanel;
    public GameObject itemBox;
    public GameObject backButton;

    // 現在表示しているパネル
    public PANEL currentPanel = PANEL.ROOM;

    private void Start()
    {
        backButton.SetActive(false);
    }

    // ボタンを押したら該当するパネルを表示
    public void OnClickLightStandTrigger()
    {
        currentPanel = PANEL.LIGHT_STAND;
        lightStandPanel.SetActive(true);
        backButton.SetActive(true);
    }
    public void OnClickDrawerTrigger()
    {
        currentPanel = PANEL.DRAWER;
        drawerPanel.SetActive(true);
        backButton.SetActive(true);
    }
    public void OnClickPCTrigger()
    {
        currentPanel = PANEL.PC;
        pcPanel.SetActive(true);
        itemBox.SetActive(false);
        backButton.SetActive(true);
    }

    // ボタンを押したらパネルを全て非表示
    public void OnClickBackTrigger()
    {
        currentPanel = PANEL.ROOM;
        lightStandPanel.SetActive(false);
        drawerPanel.SetActive(false);
        pcPanel.SetActive(false);
        itemBox.SetActive(true);
        backButton.SetActive(false);
    }

    public void GameClear()
    {
        // 現在のシーンを取得
        Scene thisScene = SceneManager.GetActiveScene();
        // 現在のシーンを再読み込み
        SceneManager.LoadScene(thisScene.name);
    }
}