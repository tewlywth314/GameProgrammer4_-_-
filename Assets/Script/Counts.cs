using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Counts : MonoBehaviour
{
    // Start is called before the first frame update
    private Text CountsText;
    public GameObject WinText;
    void Start()
    {
        WinText.SetActive(false);
        CountsText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        CountsText.text = "Counts : " + PlayerController.Coins.ToString();
        if(PlayerController.Coins == 12)
        {
            WinText.SetActive(true);
        }
    }
}
