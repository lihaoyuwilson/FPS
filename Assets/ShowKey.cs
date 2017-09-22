using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowKey : MonoBehaviour {
    public bool one=false;
    public bool two=false;
    public bool three=false;
    public GameObject key;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(one==true &&two==true && three == true)
        {
            key.SetActive(true);
        }
	}
}
