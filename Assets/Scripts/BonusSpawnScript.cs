using UnityEngine;
using System.Collections;

public class BonusSpawnScript : MonoBehaviour {

	public float minTimeSpawn = 10.0f;
	public float maxTimeSpawn = 30.0f;

	public GameObject[] bonuses;

	// Use this for initialization
	void Start () {
		InvokeSpawn ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	private void Spawn()
	{
		var spawnPosition = new Vector3 (transform.position.x, transform.position.y);
		Instantiate (bonuses [Random.Range (0, bonuses.Length)], spawnPosition, Quaternion.identity);
		InvokeSpawn ();
	}

	void InvokeSpawn ()
	{
		Invoke ("Spawn", Random.Range (minTimeSpawn, maxTimeSpawn));
	}
}
