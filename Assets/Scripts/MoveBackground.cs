using UnityEngine;
using System.Collections;

public class MoveBackground : MonoBehaviour
{
    public float speed_background;
	// Use this for initialization
	void Start ()
	{
	    speed_background = 0;
	}
	
	// Update is called once per frame
	void Update () {
        
        Vector2 offset = new Vector2((Time.time * 10) / 900, 0);
        GetComponent<Renderer>().material.mainTextureOffset = offset;
    }
}
