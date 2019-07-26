using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameFunction : MonoBehaviour
{
    public GameObject Enemy;
    public float time;

    public Text ScoreText;
    public int Score = 0;
    public static GameFunction Instance;

    public GameObject GameTitle;
    public GameObject GameOverTitle;
    public GameObject PlayButton;
    public bool isPlaying = false;

    public GameObject RestartButton;
    public GameObject QuitButton;
    // Start is called before the first frame update
    void Start()
    {
        Instance = this;
        GameOverTitle.SetActive(false);
        RestartButton.SetActive(false);
        QuitButton.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if(time>0.5f && isPlaying == true){
          Vector3 pos = new Vector3(Random.Range(-2.5f, 2.5f), 4.5f, 0);
          Instantiate(Enemy, pos, transform.rotation);
          time = 0f;
        }

        if(Input.GetKey(KeyCode.Return)) {
          GameStart();
        }
    }

    public void AddScore() {
      Score += 10;
      ScoreText.text = "Score: " + Score;
    }

    public void GameStart() {
      isPlaying = true;
      GameTitle.SetActive(false);
      PlayButton.SetActive(false);
    }

    public void GameOver() {
      isPlaying = false;
      GameOverTitle.SetActive(true);
      RestartButton.SetActive(true);
      QuitButton.SetActive(true);
    }

    public void ResetGame() {
      Application.LoadLevel(Application.loadedLevel);
    }

    public void QuitGame() {
      Application.Quit();
    }

}
