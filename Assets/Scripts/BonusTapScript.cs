using UnityEngine;
using System.Collections;

public class BonusTapScript : MonoBehaviour
{
    public AudioClip tapSound;
    public float destinationYPosition;
    public float speed;
    private bool _pressed;
    private float interpolation;
    private Vector3 vectorA;
    private AudioSource source;
	// Use this for initialization
	void Start () {
        source = GetComponent<AudioSource>();
	}
	void OnMouseDown()
    {
        if(Input.GetMouseButtonDown(0) && !_pressed)
        {
            source.PlayOneShot(tapSound, 0.5F);
            _pressed = true;
            interpolation = 0;
            vectorA =
                gameObject.transform.position =
                    new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);
        }
    }
	// Update is called once per frame
	void Update () {
        if (_pressed)
        {
            interpolation += Time.deltaTime * speed;

            Vector3 vectorB =
                gameObject.transform.position =
                    new Vector3(gameObject.transform.position.x, destinationYPosition, gameObject.transform.position.z);
            transform.position = Vector3.Lerp(vectorA, vectorB, interpolation);
        }
	}
}
