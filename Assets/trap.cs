using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trap : MonoBehaviour {
    public GameObject one;
    public GameObject two;
    public GameObject three;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void OnTriggerEnter(Collider other)
    {
        one.SetActive(true);
        two.SetActive(true);
        three.SetActive(true);
    }
}
