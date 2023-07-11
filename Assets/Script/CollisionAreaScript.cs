using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CollisionAreaScript : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI txtCollisionInfo;
    [SerializeField] GameObject panel;

    bool isColliding = false;
    GameObject colisionador;
    GameObject caballo;
    public Transform targetTR;
    public float speed;
    public static AudioSource audioSource;
    public AudioClip HorseSound;
    public AudioClip GuitarSound;
    public AudioClip GunSound;
    public AudioClip ReloadSound;
    public AudioClip MateSound;
    public AudioClip AlcoholSound;
    public AudioClip BoleadoraSound;
    [SerializeField] int ui = 0;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        panel.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.E) && isColliding )
        {
            if (colisionador.name == "Boleadora")
            {
                Destroy(colisionador);
                ObjetosManager.tengoBoleadoras = true;
                BoleadoraAudio();
                hidePanelandText();
            }
            if (colisionador.name == "Guitarra")
            {
                Destroy(colisionador);
                ObjetosManager.tengoGuitarra = true;
                GuitarAudio();
                hidePanelandText();
            }
            if (colisionador.name == "Pistola")
            {
                Destroy(colisionador);
                ObjetosManager.tengoPistola = true;
                ReloadAudio();
                hidePanelandText();
            }
            if (colisionador.name == "Caballo" && ObjetosManager.tengoMate)
            {
                caballo = colisionador;
                ObjetosManager.tengoCaballo = true;
                turnToLookAt();
                HorseAudio();
                hidePanelandText();
            }
            if (colisionador.name == "Caballo" && !ObjetosManager.tengoMate)
            {
                txtCollisionInfo.text = "Tu caballo está sediento. Dale Mate :)";
            }

            if (colisionador.name == "Botella")
            {
                Destroy(colisionador);
                ObjetosManager.tengoBotella = true;
                AlcoholAudio();
                hidePanelandText();
            }
            if (colisionador.name == "Mate")
            {
                Destroy(colisionador);
                ObjetosManager.tengoMate = true;
                MateAudio();
                hidePanelandText();
            }
        }

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Boleadora" || collision.gameObject.name == "Caballo" || collision.gameObject.name == "Guitarra" || collision.gameObject.name == "Botella" || collision.gameObject.name == "Pistola" || collision.gameObject.name == "Mate")
        {
            panel.SetActive(true);
            txtCollisionInfo.gameObject.SetActive(true);
            isColliding = true;
            txtCollisionInfo.text = collision.gameObject.name;
            colisionador = collision.gameObject;
            mostrarUI(collision.gameObject.name);
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        isColliding = false;
        panel.SetActive(false);
        txtCollisionInfo.text = "";
    }
    void mostrarUI(string collision)
    {
        txtCollisionInfo.text = "Presione E para agarrar " + collision;
    }
    void turnToLookAt()
    {
        Vector3 currentEulerAngles = transform.eulerAngles;
        transform.LookAt(targetTR);
        transform.eulerAngles = new Vector3(currentEulerAngles.x, transform.eulerAngles.y, currentEulerAngles.z);
    }
    void HorseMovement()
    {
        var step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, targetTR.position, step);
    }

    void HorseAudio()
    {
        audioSource.clip = HorseSound;
        audioSource.Play();
    }
    void GuitarAudio()
    {
        audioSource.clip = GuitarSound;
        audioSource.Play();
    }
    void BoleadoraAudio()
    {
        audioSource.clip = BoleadoraSound;
        audioSource.Play();
    }
    void GunAudio()
    {
        audioSource.clip = GunSound;
        audioSource.Play();
    }
    void ReloadAudio()
    {
        audioSource.clip = ReloadSound;
        audioSource.Play();
    }
    void AlcoholAudio()
    {
        audioSource.clip = AlcoholSound;
        audioSource.Play();
    }
    void MateAudio()
    {
        audioSource.clip = MateSound;
        audioSource.Play();
    }
    void hidePanelandText()
    {
        panel.SetActive(false);
        txtCollisionInfo.gameObject.SetActive(false);
    }
   
}