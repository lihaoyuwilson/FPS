using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BunnyHealth : MonoBehaviour {

    public EnemyHealth eh;
    public Text txt;
    public ShowKey hi;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        txt.text = "Bear health:" + eh.currentHealth;
        if (eh.currentHealth <= 0)
        {
            hi.three = true;
        }
    }
}
