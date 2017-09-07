using System;
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TakeScoresBonusScript : MonoBehaviour {
    public int BonusScores;
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
            Time.timeScale = 0f;
            var buffer = GameObject.Find("Player").GetComponent<PlayerController>().ScoreValue;
            GameObject.Find("Player").GetComponent<PlayerController>().ScoreValue =
                buffer + BonusScores;
            Destroy(gameObject.transform.parent.gameObject);
        }
    }
}
