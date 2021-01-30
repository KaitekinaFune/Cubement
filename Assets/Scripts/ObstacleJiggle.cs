using UnityEngine;

public class ObstacleJiggle : MonoBehaviour
{
	public Rigidbody rb;
    void Start()
	{
		rb.AddForce(Random.Range(600, 1100), 0, 0);
	}
}
