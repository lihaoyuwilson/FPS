using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stair : MonoBehaviour {
    public bool start = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (gameObject.transform.position.y > 0 &&start==true)
        {
            gameObject.transform.Translate(Vector3.down * Time.deltaTime, Space.World);
        }
    }
}
