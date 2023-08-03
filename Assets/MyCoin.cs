using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MyCoin : MonoBehaviour
{
    public int coin;
    public TextMeshProUGUI text_coin;

    public static MyCoin instances;

    public AudioSource audio;

    private void Awake()
    {
        if (instances == null)
        {
            instances = this;
        }

        if(audio == null)
        {
            audio = GetComponent<AudioSource>();
        }
    }

    void Start()
    {
        coin = 70;
        UpdateText();
    }

    public void AddCoin(int _coin)
    {
        coin += _coin;
        UpdateText();
        audio.Play();
    }

    public void UpdateText()
    {
        text_coin.text = coin.ToString();
    }
}
