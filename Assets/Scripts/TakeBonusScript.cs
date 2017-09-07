using UnityEngine;
using System.Collections;

public class TakeBonusScript : MonoBehaviour
{
    public float decreaseSpeedOn;
	// Use this for initialization
	void Start () {
	
	}	
	// Update is called once per frame
	void Update () {
	
	}
    void OnTriggerEnter2D(Collider2D other)
    {
        if(gameObject.name=="BlueBonus"|| gameObject.name=="BlueBonus")
        {          
            GameObject.Find("Player").GetComponent<Rigidbody2D>().AddForce(new Vector2(-decreaseSpeedOn, 0));
        }
        Destroy(gameObject.transform.parent.gameObject);

    }
}
