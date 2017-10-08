using UnityEngine;
using System.Collections;

public class shooting : MonoBehaviour
{
    public static float bulletSpeed = 10;
    public Rigidbody bullet;
    public int Arrows = 20;

    void Fire()
    {
            Rigidbody bulletClone = (Rigidbody)Instantiate(bullet, transform.position, transform.parent.rotation);
            bulletClone.position += transform.forward * Time.deltaTime * bulletSpeed;
    }
    void OnCollisionEnter(Collision collision) { GameObject.Destroy(this.gameObject); }
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
            Fire();
    }
    
}