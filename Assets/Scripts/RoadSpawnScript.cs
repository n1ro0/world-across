using System.Linq;
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class RoadSpawnScript : MonoBehaviour {

	public GameObject[] objects;
	public float spawnDistance;

    private bool isVisible = false;

	// Use this for initialization
	void Start () {
 
	}
 
   
	// Update is called once per frame
	void OnBecameVisible()
	{
        if (isVisible)
            return;
	    isVisible = true;

	    var nextSegment = objects [Random.Range(0, objects.Length)];
	    var spawnPosition = new Vector3 (transform.position.x + spawnDistance, nextSegment.transform.position.y, transform.position.z);
	    Instantiate (nextSegment, spawnPosition, Quaternion.identity);
	}
}
