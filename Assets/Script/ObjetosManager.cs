using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjetosManager : MonoBehaviour
{
    public static bool tengoBoleadoras = false;
    public static bool tengoGuitarra = false;
    public static bool tengoCaballo = false;
    public static bool tengoMate = false;
    public static bool tengoBotella = false;
    public static bool tengoPistola = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
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
