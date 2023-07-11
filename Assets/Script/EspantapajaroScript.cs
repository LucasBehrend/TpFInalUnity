using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EspantapajaroScript : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI txtEspantapajaros;
    [SerializeField] GameObject panel;
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
        if (collision.gameObject.name == "CollisionArea")
        {
            txtEspantapajaros.text = "Disparar con Pistola";
            txtEspantapajaros.gameObject.SetActive(true);
            panel.SetActive(true);
        }
    }
}
