using UnityEngine;
using System.Collections;

public class PlayerDeathController : MonoBehaviour
{

    public GameObject gameOverCanvas;
    void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Player")
		{
		    Time.timeScale = 0f;
            gameOverCanvas.SetActive(true);
		}
		if (other.gameObject.transform.parent) {
			Destroy(other.gameObject.transform.parent.gameObject);
		}
		else {
			Destroy(other.gameObject);
		}


	}
}
