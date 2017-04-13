using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TapAndDrag : MonoBehaviour {

    public float timeToDrag = 2.0f; // easy access to get the right feel
    public float distToDrag = 32f; // same, but for distance dragged in pixels

    private float dragTime;
    private bool dragging;
    private Vector2 clickPos;
    private float distToCam;

	// Use this for initialization
	void Start () {
        dragging = false;
        dragTime = 0.0f;

  
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public virtual void OnTap ()
    {
        Debug.Log("Tapped");
    }

    private void OnMouseDown()
    {
        dragging = false;
        dragTime = 0.0f;
        clickPos = Input.mousePosition;
    }

    private void OnMouseDrag()
    {
        dragTime += Time.deltaTime;
        if(dragging)
        {
            transform.position = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, distToCam));
        }
        else
        {
            if (dragTime >= timeToDrag || Vector2.Distance(clickPos, Input.mousePosition) >= distToDrag)
            {
                dragging = true;
                distToCam = Vector3.Distance(transform.position, Camera.main.transform.position); // get distance to do screen-based translation
            }
                
        }
    }

    private void OnMouseUp()
    {
        if(!dragging)
        {
            OnTap();
        }

    }
}
