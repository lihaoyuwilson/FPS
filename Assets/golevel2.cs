using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class golevel2 : MonoBehaviour {
    public bool haslv2key=false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void OnTriggerEnter(Collider other)
    {
        if (haslv2key == true)
        {
            SceneManager.LoadScene("gamemodelevel2", LoadSceneMode.Single);
        }
    }
}
