using UnityEngine;
using System.Collections;

public class TakeBombScript : MonoBehaviour
{
    public float ExplosivePower;
    public AudioClip tapSound;
    private AudioSource source;
	// Use this for initialization
	void Start () {
        source = GetComponent<AudioSource>();
	}	
	// Update is called once per frame
	void Update () {
	
	}
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.transform.parent.gameObject.name=="Player")
        {
            source.PlayOneShot(tapSound, 0.5F);
            GameObject.Find("Player").GetComponent<Rigidbody2D>().AddForce(new Vector2(-ExplosivePower, 0));
           
        }
    }
}
