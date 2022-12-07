using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using YG;
using TMPro;


public class CheckConnectYandex : MonoBehaviour
{
    private void OnEnable() => YandexGame.GetDataEvent += CheckSDK;
    private void OnDisable() => YandexGame.GetDataEvent += CheckSDK;
    private TextMeshProUGUI scoreBest;
    // Start is called before the first frame update
    void Start()
    {
        CheckSDK();
        
    }

    public void CheckSDK()
    {
        if (YandexGame.auth == true)
        {
            Debug.Log("User authorization ok");
        }
        else
        {
            Debug.Log("User not authorization");
            YandexGame.AuthDialog();
        }
        GameObject scoreGO = GameObject.Find("BestScore");
        scoreBest = scoreGO.GetComponent<TextMeshProUGUI>();
        scoreBest.text = "Best Score: " + YandexGame.savesData.bestScore.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
