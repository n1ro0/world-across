using UnityEngine;
using System.Collections;

public class SoundControll : MonoBehaviour
{

    
    public AudioClip tapSound;
    private AudioSource Source;
	// Use this for initialization
	void Start ()
	{
	    Source = GetComponent<AudioSource>();
	}

    void onMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Source.PlayOneShot(tapSound, 1F);

        }
    }

	// Update is called once per frame
	void Update () 
    {

	}
}
