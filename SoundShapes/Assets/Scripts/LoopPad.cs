using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopPad : TapAndDrag {

    private bool active;
    private AudioSource soundMaker;

	// Use this for initialization
	void Start () {
        active = false;
        soundMaker = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public override void OnTap()
    {
        if(active)
        {
            active = false;
            soundMaker.volume = 0.0f;
        }
        else
        {
            active = true;
            soundMaker.volume = 1.0f;
        }
    }
}
