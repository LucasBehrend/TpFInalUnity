using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Salida : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI txtFaltanObj;
    [SerializeField] TextMeshProUGUI txtGanaste;
    [SerializeField] GameObject panelFaltanObj;
    [SerializeField] GameObject panelGanaste;
    public AudioSource audioSource;
    public AudioClip victorySound;
    bool estaActivado = false;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("chau jero");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        
        if(ObjetosManager.TengoTodosLosObjetos())
        {
            txtGanaste.gameObject.SetActive(true);
            panelGanaste.SetActive(true);
            txtGanaste.text = "¡Felicidades! Escapaste del laberinto.";
        }
        else
        {
            txtFaltanObj.gameObject.SetActive(true);
            panelFaltanObj.SetActive(true);
            txtFaltanObj.text = "Aún te faltan objetos para poder salir.";
            estaActivado = true;
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        if(estaActivado)
        {
            txtFaltanObj.gameObject.SetActive(false);
            panelFaltanObj.SetActive(false);
        }
    }

    public void VictoryAudio()
    {
        audioSource.clip = victorySound;
        audioSource.Play();
    }
}
