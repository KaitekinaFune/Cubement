using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public bool gameHasEnded = false;
    public GameObject GameOverUI;
    public GameObject ScoreUI;
    public AudioSource GameOverSound;
    public GameObject SFX;

    public void EndGame()
    {
        if (gameHasEnded == false)
		{
            GameOverSound.Play();
            gameHasEnded = true;
            GameOverUI.SetActive(true);
            ScoreUI.SetActive(false);
            GameOverSound.Play();
            Invoke("PauseGame", 0.5f);
        }
    }
    public void PauseGame()
	{
        SFX.SetActive(false);
        Time.timeScale = 0;
    }
}
