using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
	public PlayerMovement movement;
	public Vector3 startingPoint;
	public AudioSource SlamSound;
	private void OnCollisionEnter(Collision collision)
	{
		if (collision.collider.tag == "Obstacle")
		{
			SlamSound.Play();
			FindObjectOfType<GameManager>().EndGame();
		}
	}
}
