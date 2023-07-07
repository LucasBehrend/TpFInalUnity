using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CollisionAreaScript : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI txtCollisionInfo;
    [SerializeField] GameObject panel;
    public bool tengoBoleadoras = false;
    public bool tengoGuitarra = false;
    public bool tengoCaballo = false;
    public bool tengoMate = false;
    public bool tengoBotella = false;
    public bool tengoPistola = false;
    bool isColliding = false;
    GameObject colisionador;
    GameObject caballo;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && isColliding)
        {
            if (colisionador.name == "Boleadora")
            {
                Destroy(colisionador);
                tengoBoleadoras = true;
            }
            if (colisionador.name == "Guitarra")
            {
                Destroy(colisionador);
                tengoGuitarra = true;
            }
            if (colisionador.name == "Pistola")
            {
                Destroy(colisionador);
                tengoPistola = true;
            }
            if (colisionador.name == "Caballo")
            {
                caballo = colisionador;
                tengoCaballo = true;
            }
            if (colisionador.name == "Botella")
            {
                Destroy(colisionador);
                tengoBotella = true;
            }
            if (colisionador.name == "Mate")
            {
                Destroy(colisionador);
                tengoMate = true;
            }
        }
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        panel.SetActive(true);
        isColliding = true;
        txtCollisionInfo.text = collision.gameObject.name;
        colisionador = collision.gameObject;
        mostrarUI(collision.gameObject.name);
    }
    private void OnCollisionExit(Collision collision)
    {
        panel.SetActive(false);
        txtCollisionInfo.text = "";
    }
    void mostrarUI(string collision)
    {
        txtCollisionInfo.text = "Presione E para agarrar " + collision;
    }
}
