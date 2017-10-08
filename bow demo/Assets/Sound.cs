using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour {

    // Use this for initialization
    public static AudioSource audio;
    void Start () {
        audio = GetComponent<AudioSource>();
    }
	public static void playaudio()
    {
        audio.Play();
    }
	// Update is called once per frame
	void Update () {
		
	}
}
