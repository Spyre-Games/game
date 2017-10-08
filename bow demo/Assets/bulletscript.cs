using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletscript : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }
    float movementSpeed = bowscript.bulletSpeed;
    void Update()
    {
        transform.position += transform.forward * Time.deltaTime * movementSpeed;
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag != "bulletless")
            GameObject.Destroy(gameObject);
    }
}
