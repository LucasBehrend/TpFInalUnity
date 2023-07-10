﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Timer : MonoBehaviour
{

    public int currentMin = 4;
    public float currentSec = 59;
    [SerializeField] TextMeshProUGUI txtTimer;
    [SerializeField] TextMeshProUGUI txtPerdiste;
    [SerializeField] GameObject panelPerdiste;
    [SerializeField] GameObject player;
    public AudioSource audioSource;
    public AudioClip AlarmaSound;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = CollisionAreaScript.audioSource ;
        panelPerdiste.SetActive(false);
        txtPerdiste.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        currentSec -= Time.deltaTime;
        if (currentSec == 10 && currentMin == 0)
        {
            AudioDiezSeg();
        }

        if (currentSec < 0)
        {
            currentMin--;
            currentSec = 59;
        }

        if (currentMin < 0)
        {
            currentMin = 0;
            currentSec = 0;
            //player.SetActive(false);
            panelPerdiste.SetActive(true);
            txtPerdiste.gameObject.SetActive(true);
            txtPerdiste.text = "PERDISTE. Se te acabó el tiempo.";
        }
        txtTimer.text = currentMin.ToString() + ":" + currentSec.ToString("0");
    }
    void AudioDiezSeg()
    {
            audioSource.clip = AlarmaSound;
            audioSource.Play();
    }
}
