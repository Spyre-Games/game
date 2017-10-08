using UnityEngine;
using System.Collections;

public class BulletDrop : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
    int x = -353;
    float multiplier = (1/10);
    
	// Update is called once per frame
	void Update () {
        int y = (((-1)*(1 / 1000) *x * x)) + 50;
        transform.position += transform.up * y * Time.deltaTime;
	}
}
