using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public GameObject score;
    public GameObject gameOverCanvas;
    // Start is called before the first frame update
    private void Start()
    {
        Time.timeScale = 1;
        gameOverCanvas.SetActive(false);
    }

    public void Gameover()
    {
        gameOverCanvas.SetActive(true);
        score.SetActive(false);
        Time.timeScale = 0;
    }
    // Update is called once per frame

    void Update()
    {
        
    }

    public void Replay()
    {
        SceneManager.LoadScene(0);
        Score.score = 0;
    }
}
