
using UnityEngine;
using System.Collections;

public class NewBehaviorScript : MonoBehaviour
{

    void OnCollisionEnter(Collision collision)
    {
        
        GameObject.Destroy(gameObject);
        Debug.Log("test");
    }
}
