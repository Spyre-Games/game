using UnityEngine;
using System.Collections;

public class forward : MonoBehaviour {
    float movementSpeed = shooting.bulletSpeed;
    int x = -127;
    int multiplier = (10);
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.position += transform.forward * Time.deltaTime * movementSpeed;
        int y = (((-1) * (1 / 18) * x * x));
        transform.position += transform.up * y * Time.deltaTime * multiplier;
        x = x++;
    }
    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag != "bulletless")
        GameObject.Destroy(gameObject);
    }
    //   Debug.Log("test");
}

