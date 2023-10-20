using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    private TMP_Text scoreText;
    private int score = 0;
    // Start is called before the first frame update
    void Awake()
    {
        scoreText = GameObject.Find("ScoreText").GetComponent<TMP_Text>();
        scoreText.text = "0";
    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D target)
    {
        if (target.tag == "Toxic")
        {
            transform.position = new Vector2(0, 100);
            target.gameObject.SetActive(false);
            StartCoroutine(RestartGame());
        }
        if (target.tag == "Water")
        {
            target.gameObject.SetActive(false);
            score++;
            scoreText.text = score.ToString();
        }
    }

    IEnumerator RestartGame()
    {
        yield return new WaitForSecondsRealtime(2f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
