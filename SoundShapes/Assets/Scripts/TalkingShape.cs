using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TalkingShape : MonoBehaviour {
    public AudioClip bloop;
    // Use this for initialization
    void Start()
    {
        this.gameObject.AddComponent<AudioSource>();
        this.GetComponent<AudioSource>().clip = bloop;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        { // if left button pressed...
            Ray ray = GetComponent<Camera>().ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                // If the left mouse button is pressed down...
                GetComponent<AudioSource>().loop = true;
                GetComponent<AudioSource>().Play();
            }
            // If the left mouse button is released...
        }
        if (Input.GetMouseButtonUp(0))
        {
           GetComponent<AudioSource>().Stop();
        }
    }
}
