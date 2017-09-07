using UnityEngine;
using System.Collections;

public class TakeFreezeBonusScript : MonoBehaviour
{
    public float decreaseSpeedOn;
    // Use this for initialization
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.transform.parent.gameObject.name == "Player")
        {
            Time.timeScale = 0.1f;
            GameObject.Find("Player").GetComponent<Rigidbody2D>().velocity =
                (new Vector2(GameObject.Find("Player").GetComponent<Rigidbody2D>().velocity.x - decreaseSpeedOn, 0));
            Destroy(gameObject.transform.parent.gameObject);
        }
    }
}
