using UnityEngine;
using UnityEngine.UI;

public class HiScore : MonoBehaviour
{
    private GameObject Player;
    public Text scoreText;

    void Start()
    {
        Player = GameObject.Find("Player");
        var score = Player.GetComponent<PlayerMovement>().Score;
        scoreText.text = score.ToString();
    }
}
