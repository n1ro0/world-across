using UnityEngine;
using System.Collections;

public class GuyCrashScript : MonoBehaviour
{


    public GameObject gameOverCanvas;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.collider.tag != "Bonus" && other.collider.tag != "Player")
        {
            Invoke("GameOver", 2f);
        }
      

    }

    private void GameOver()
    {
        Time.timeScale = 0f;
        gameOverCanvas.SetActive(true);
        GameObject player = GameObject.Find("Player");
        PlayerPrefs.SetInt("highScore", player.GetComponent<PlayerController>().ScoreValue);      
        if (gameObject.transform.parent)
        {
            Destroy(gameObject.transform.parent.gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

    }
}
