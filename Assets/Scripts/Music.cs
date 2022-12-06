using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour
{
    public GameObject backgroundMusic;
    public GameObject winMusic;
    public GameObject loseMusic;

    // Start is called before the first frame update
    void Start()
    {
        backgroundMusic.SetActive(true);
        winMusic.SetActive(false);
        loseMusic.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (RubyController.robotValue == 5)
        {
            backgroundMusic.SetActive(false);
            winMusic.SetActive(true);
        }

        if (RubyController.currentHealth == 0)
        {
            backgroundMusic.SetActive(false);
            loseMusic.SetActive(true);
        }

        if(RubyController.timeLeft == 0)
        {
            backgroundMusic.SetActive(false);
            loseMusic.SetActive(true);
        }
    }
}
