using UnityEngine;

public class ObstacleScore : MonoBehaviour
{
    private GameObject Player;
    public Rigidbody rb;
    private bool objectPassed = false;

    void Start()
    {
        Player = GameObject.Find("Player");
    }

    void FixedUpdate()
    {
        if (rb.position.z < 0 && !objectPassed)
        {
            objectPassed = true;
            if (FindObjectOfType<GameManager>().gameHasEnded == false)
            {
                Player.GetComponent<PlayerMovement>().Score += 1;
                FindObjectOfType<SFX>().PlayScoreSound();
            }
        }
    }
}

