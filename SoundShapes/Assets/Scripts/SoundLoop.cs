using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundLoop : MonoBehaviour {
    public AudioClip bloop;
	// Use this for initialization
	void Start () {
        this.gameObject.AddComponent<AudioSource>();
        this.GetComponent<AudioSource>().clip = bloop;
        
    }

    // Update is called once per frame
    void Update(){
        // If the left mouse button is pressed down...
        if (Input.GetMouseButtonDown(0) == true)
        {
            GetComponent<AudioSource>().loop = true;
            GetComponent<AudioSource>().Play();
        }
        // If the left mouse button is released...
        if (Input.GetMouseButtonUp(0) == true)
        {
            GetComponent<AudioSource>().Stop();
        }
    }
}
