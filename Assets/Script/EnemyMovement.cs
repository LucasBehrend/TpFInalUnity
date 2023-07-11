using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float speed;
    public Transform targetTR;
    bool collidingWithPlayer = false;

    // Update is called once per frame
    void Update()
    {
        if (ObjetosManager.tengoCaballo && !collidingWithPlayer)
        {
            var step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, targetTR.position, step) ;
        }
    }
   /* private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "CollisionArea")
        {
            collidingWithPlayer = true;
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.name == "CollisionArea")
        {
            collidingWithPlayer = true;
        }
    }*/
}
