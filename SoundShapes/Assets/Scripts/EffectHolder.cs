using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectHolder : TapAndDrag {


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public override void OnTap()
    {
        GameObject myEffect = transform.GetChild(0).gameObject;
        myEffect.SetActive(!myEffect.activeSelf);
        //base.OnTap();
    }
}
