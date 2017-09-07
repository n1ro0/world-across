using UnityEngine;
using System.Collections;

public class DestroyerController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnBecameInvisible()
	{
		if (gameObject.transform.parent) {
            Destroy(gameObject.transform.parent.gameObject);

		}
		else {
            Destroy(gameObject);
            
		}
	}
    void ColisionDetector()
    {

    }
}
