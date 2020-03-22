using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PasswordManager : MonoBehaviour
{
    [SerializeField] GameManager gameManager;

    // 表示テキストの取得
    [SerializeField] Text[] viewPasswordTexts;
    // Alertテキストの取得
    [SerializeField] Text alertText;
    // ユーザが入力したパスワード
    string userInputPassword = "";
    // 現在の入力位置
    int currentIndex = 0;

    //　正解のパスワード
    string correctPassword = "3333";

    private void Start()
    {
        Reset();
    }

    // パスワードの入力
    public void InputKey(int number)
    {
        if (currentIndex >= viewPasswordTexts.Length)
        {
            return;
        }
        userInputPassword += number;
        viewPasswordTexts[currentIndex].text = number.ToString();
        currentIndex++;
        if (currentIndex >= viewPasswordTexts.Length)
        {
            CheckPass();
        }

    }

    // 正解を確認する
    void CheckPass()
    {
        if (correctPassword == userInputPassword)
        {
            // 正解！
            alertText.text = "CLEAR!";
            Invoke("PasswordCorrect", 1f);
        }
        else
        {
            // 不正解
            alertText.text = "ERROR";
            // リセットする
            Invoke("Reset", 1f);
        }
    }

    void PasswordCorrect()
    {
        gameManager.GameClear();
    }
    void Reset()
    {
        foreach (Text passText in viewPasswordTexts)
        {
            passText.text = "";
        }
        alertText.text = "";
        userInputPassword = "";
        currentIndex = 0;
    }
}
