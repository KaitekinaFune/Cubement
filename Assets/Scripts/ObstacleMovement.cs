using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    public Rigidbody rb;
    private float forwardForce;

	private void Start()
	{
        forwardForce = FindObjectOfType<ObstacleSpawn>().Speed;
	}

	void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        if (gameObject)
        {
            if (rb.position.z < -40)
                Destroy(gameObject);
		}
    }
}
