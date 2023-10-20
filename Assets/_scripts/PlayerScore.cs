using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerScore : MonoBehaviour
{

    private Text scoreText;

    private int score = 0;


    void Awake()
    {
        scoreText = GameObject.Find("ScoreText").GetComponent<Text>();
        scoreText.text = "0";
    }

    void OnTriggerEnter2D(Collider2D target)
    { 
            if (target.tag == "toxin")
            {
                target.gameObject.SetActive (false);
                transform.position = new Vector2 (0, 100);
                StartCoroutine(RestartGame());
            }
            if (target.tag == "water")
            {
                target.gameObject.SetActive(false);
                score++;
                scoreText.text = score.ToString();
            }
    }

    IEnumerator RestartGame()
    { 
            yield return new WaitForSecondsRealtime (2f);
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
