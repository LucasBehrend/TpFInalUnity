using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ObjetosManager : MonoBehaviour
{
    public static bool tengoBoleadoras = false;
    public static bool tengoGuitarra = false;
    public static bool tengoCaballo = false;
    public static bool tengoMate = false;
    public static bool tengoBotella = false;
    public static bool tengoPistola = false;
    int cantObjetos = 0;
    [SerializeField] TextMeshProUGUI[] objetos;
    [SerializeField] TextMeshProUGUI boleadora;
    [SerializeField] TextMeshProUGUI guitarra;
    [SerializeField] TextMeshProUGUI caballo;
    [SerializeField] TextMeshProUGUI mate;
    [SerializeField] TextMeshProUGUI botella;
    [SerializeField] TextMeshProUGUI pistola;
    [SerializeField] GameObject panel;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(cantObjetos > 0)
        {
            panel.SetActive(true);
        }
        if(tengoBoleadoras)
        {
            boleadora.gameObject.SetActive(true);
            cantObjetos++;
        }
        if(tengoGuitarra)
        {
            guitarra.gameObject.SetActive(true);
            cantObjetos++;
        }
        if(tengoCaballo)
        {
            caballo.gameObject.SetActive(true);
            cantObjetos++;
        }
        if(tengoMate)
        {
            mate.gameObject.SetActive(true);
            cantObjetos++;
        }
        if(tengoBotella)
        {
            botella.gameObject.SetActive(true);
            cantObjetos++;
        }
        if(tengoPistola)
        {
            pistola.gameObject.SetActive(true);
            cantObjetos++;
        }
    }
    public static bool TengoTodosLosObjetos()
    {
        if(tengoBoleadoras && tengoBotella && tengoCaballo && tengoGuitarra && tengoMate && tengoPistola)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
