using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Timer : MonoBehaviour
{

    public int currentMin = 9;
    public float currentSec = 59;
    [SerializeField] TextMeshProUGUI txtTimer;
    [SerializeField] TextMeshProUGUI txtPerdiste;
    [SerializeField] GameObject panelPerdiste;
    [SerializeField] GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        panelPerdiste.SetActive(false);
        txtPerdiste.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Time.deltaTime);
        currentSec -= 1f * Time.deltaTime;
        if(currentSec < 0)
        {
            currentMin--;
        }
        
        if(currentSec <= 0 && currentMin <= 0)
        {
            currentMin = 0;
            currentSec = 0;
            //player.SetActive(false);
            panelPerdiste.SetActive(true);
            txtPerdiste.gameObject.SetActive(true);
        }
        txtTimer.text = currentMin.ToString() + ":" + currentSec.ToString("0");
    }
}

