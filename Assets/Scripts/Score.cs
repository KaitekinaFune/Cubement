using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreText;
	public GameObject Player;
	bool gameHasEnded = false;

	private void Start()
	{
		scoreText.text = "0";
	}

	// Update is called once per frame
	void Update()
    {
		if (gameHasEnded == true)
			scoreText.text = "Game Over!";
		else
			scoreText.text = Player.GetComponent<PlayerMovement>().Score.ToString();
    }

    public void GameOverScreen()
	{
		gameHasEnded = true;
	}
}
