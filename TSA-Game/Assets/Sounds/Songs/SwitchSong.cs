using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchSong : MonoBehaviour
{
    [SerializeField]
    AudioSource One = null;
    [SerializeField]
    AudioSource Two = null;
    [SerializeField]
    AudioSource Three = null;
    [SerializeField]
    AudioSource Four = null;

    // Use this for initialization
    void Start ()
    {
        One.GetComponent<AudioSource>().enabled = false;
        Two.GetComponent<AudioSource>().enabled = false;
        Three.GetComponent<AudioSource>().enabled = false;
        Four.GetComponent<AudioSource>().enabled = false;
    }
	
	// Update is called once per frame
	void Update ()
    {
		if (Input.GetKeyDown("1"))
        {
            One.GetComponent<AudioSource>().enabled = true;
            Two.GetComponent<AudioSource>().enabled = false;
            Three.GetComponent<AudioSource>().enabled = false;
            Four.GetComponent<AudioSource>().enabled = false;
        }

        if (Input.GetKeyDown("2"))
        {
            One.GetComponent<AudioSource>().enabled = false;
            Two.GetComponent<AudioSource>().enabled = true;
            Three.GetComponent<AudioSource>().enabled = false;
            Four.GetComponent<AudioSource>().enabled = false;
        }

        if (Input.GetKeyDown("3"))
        {
            One.GetComponent<AudioSource>().enabled = false;
            Two.GetComponent<AudioSource>().enabled = false;
            Three.GetComponent<AudioSource>().enabled = true;
            Four.GetComponent<AudioSource>().enabled = false;
        }

        if (Input.GetKeyDown("4"))
        {
            One.GetComponent<AudioSource>().enabled = false;
            Two.GetComponent<AudioSource>().enabled = false;
            Three.GetComponent<AudioSource>().enabled = false;
            Four.GetComponent<AudioSource>().enabled = true;
        }

        if (Input.GetKeyDown("m"))
        {
            One.GetComponent<AudioSource>().enabled = false;
            Two.GetComponent<AudioSource>().enabled = false;
            Three.GetComponent<AudioSource>().enabled = false;
            Four.GetComponent<AudioSource>().enabled = false;
        }
    }
}
