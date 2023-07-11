using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Salida : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI txtGanaste;
    [SerializeField] GameObject panelGanaste;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        txtGanaste.gameObject.SetActive(true);
        panelGanaste.SetActive(true);
        if(ObjetosManager.TengoTodosLosObjetos())
        {
            txtGanaste.text = "¡Felicidades! Escapaste del laberinto.";
        }
        else
        {
            txtGanaste.text = "Aún te faltan objetos para poder salir.";
        }
    }
}
