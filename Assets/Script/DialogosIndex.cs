using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogosIndex : MonoBehaviour
{
    [SerializeField] string[] txtindex;
    [SerializeField] int currentIndex = 1;
    [SerializeField] TextMeshProUGUI Indextxt;
    [SerializeField] GameObject panel;
    // Start is called before the first frame update
    void Start()
    {
        Indextxt.text = txtindex[0];
        panel.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightAlt))
        {
            NextSentence();
        }
        else if (Input.GetKeyDown(KeyCode.LeftAlt))
        {
            PreviousSentence();
        }
    }
    public void NextSentence()
    {
        if (currentIndex < txtindex.Length)
        {
            currentIndex++;
            if(currentIndex == txtindex.Length)
            {
                Indextxt.gameObject.SetActive(false);
                panel.SetActive(false);
            }
            Indextxt.text = txtindex[currentIndex];
            
        }
        
    }
    public void PreviousSentence()
    {
        if (currentIndex < txtindex.Length)
        {
            currentIndex--;
            Indextxt.text = txtindex[currentIndex];
        }
        else
        {
            Indextxt.text = string.Empty;
        }
    }
}