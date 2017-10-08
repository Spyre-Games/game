using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrowscript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
    float movementSpeed = bowscript.arrowSpeed;
    void Update()
    {
        transform.position += transform.forward * Time.deltaTime * movementSpeed;
        //int y = (((-1) * (1 / 18) * x * x));
        //transform.position += transform.up * y * Time.deltaTime * multiplier;
        // x = x++;
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag != "arrowless")
            movementSpeed = 0; //GameObject.Destroy(gameObject);
    }
}
