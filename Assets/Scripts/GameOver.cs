using UnityEngine.SceneManagement;
using UnityEngine;

public class GameOver : MonoBehaviour
{
	public void Restart()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
		Time.timeScale = 1;
	}
}
