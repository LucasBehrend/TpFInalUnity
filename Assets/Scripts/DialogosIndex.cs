using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogosIndex : MonoBehaviour
{
    [SerializeField] string[] txtindex;
    [SerializeField] int currentIndex = 0;
    [SerializeField] TextMeshProUGUI Indextxt;
    // Start is called before the first frame update
    void Start()
    {
        Indextxt.text = string.Empty;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            NextSentence();
        }
        else if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            PreviousSentence();
        }
    }
    public void NextSentence()
    {
        if (currentIndex < txtindex.Length)
        {
            currentIndex++;
            Indextxt.text = txtindex[currentIndex];
        }
        else
        {
            Indextxt.text = string.Empty;
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
