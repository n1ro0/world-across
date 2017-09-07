using UnityEngine;
using System.Collections;

public class SpawnScript : MonoBehaviour {

	public GameObject[] objects;
	public float spawnDistance;
	public int initialSpawnCount;

	private float currentOffset = 0f;
	private float previousPosition;

	private Vector3 spawnPosition;

	// Use this for initialization
	void Start () 
	{
		previousPosition = transform.position.x;
		spawnPosition = transform.position;
		InitialSpawn ();
	}

	void Update()
	{
		currentOffset += transform.position.x - previousPosition;
		previousPosition = transform.position.x;
		if (spawnDistance - currentOffset <= 0.083)
		{
			Spawn ();
			currentOffset = 0;
		}
	}

	void Spawn ()
	{
		Instantiate (objects [Random.Range (0, objects.Length)], spawnPosition, Quaternion.identity);
		spawnPosition = new Vector3 (spawnPosition.x + spawnDistance, spawnPosition.y, spawnPosition.z);
	}
	

	void InitialSpawn()
	{
		for (int i = 0; i < initialSpawnCount; i++) 
		{
			Spawn();
		}
	}
}
