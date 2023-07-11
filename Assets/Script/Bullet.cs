using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed;
    public float lifeTime;
    void Start()
    {
        Destroy(gameObject, lifeTime);
    }

    void Update()
    {
        transform.position += transform.forward * speed;
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name != "CollisionArea" && collision.gameObject.name != "FirstPersonCharacter" && collision.gameObject.name != "miPistola")
        {
            Destroy(gameObject);
        }
        if(collision.gameObject.name == "Espantapajaros")
        {
            Destroy(collision.gameObject);
        }
    }
}