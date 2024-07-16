using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinCollection : MonoBehaviour
{
    private int nofound = 37;
    private int Coin=0;
    public TextMeshProUGUI coinText;
    public TextMeshProUGUI HiScoreText;
    public TextMeshProUGUI NoFoundText;
    public static int HiScore;

    private void Start()
    {
        if (PlayerPrefs.HasKey("HighScore"))
        {
            HiScore = PlayerPrefs.GetInt("HighScore");
        }
    }
    private void OnTriggerEnter(Collider either)
    {
        Coin++;
        nofound--;
        coinText.text="Coin:" + Coin.ToString();
        NoFoundText.text="Unfounded coin : " +  nofound.ToString();
        if(Coin>= HiScore)
        {
            HiScore=Coin;
            PlayerPrefs.SetInt("HighScore",HiScore);
        }
        HiScoreText.text = "Highscore: " + HiScore.ToString();

        Debug.Log(Coin);
        Destroy(either.gameObject);

    }
}
