using UnityEngine;
using System.Collections;

public class destroyontouch : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void OnCollisionEnter(Collision collision)
    {
        // Debug.Log(collision.gameObject.name);
        // GameObject.Destroy(this.gameObject);
    }
    void Update()
    {

    }
   
}
