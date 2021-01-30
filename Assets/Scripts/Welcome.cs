using UnityEngine;
using UnityEngine.SceneManagement;

public class Welcome : MonoBehaviour
{
    public void GameStart ()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}
    
}
