using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

	public float acceleration;
	public float maxSpeed;

    public int ScoreValue;
    float previousPositionX;
    private Rigidbody2D rb;

	// Use this for initialization
	void Start ()
    {
		rb = GetComponent<Rigidbody2D> ();
	    previousPositionX = transform.position.x;
        if (!PlayerPrefs.HasKey("HighScore"))
        {
            PlayerPrefs.SetInt("HighScore", 0);
        }
        GameObject highScoreValueTextBox = GameObject.Find("HighScoreValueTextBox");
        (highScoreValueTextBox.GetComponent<Text>()).text = PlayerPrefs.GetInt("HighScore").ToString();
        
        
    }
	
	// Update is called once per frame
	void Update () {
	
	}

	void FixedUpdate()
	{
		var movement = new Vector2 (acceleration, 0);
		//rb.AddForce (movement);
		if (rb.velocity.x < maxSpeed) {
			rb.AddForce(movement);
		}
	    int score = (int) transform.position.x - (int) previousPositionX;
        ScoreValue +=score>0?score:0 ;
	    previousPositionX = transform.position.x;
	    if (ScoreValue > PlayerPrefs.GetInt("HighScore"))
	    {
	        GameObject highScoreValueTextBox = GameObject.Find("HighScoreValueTextBox");
            (highScoreValueTextBox.GetComponent<Text>()).text = ScoreValue.ToString();
	        PlayerPrefs.SetInt("HighScore", ScoreValue);
	    }
	    GameObject scoreValueTextBox = GameObject.Find("ScoreValueTextBox");
	    (scoreValueTextBox.GetComponent<Text>()).text = ScoreValue.ToString();

	}


}
