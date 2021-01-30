using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public int Score;
    public float sidewaysForce = 500f;

    void FixedUpdate()
    {
        if (Input.GetKey("d"))
		{
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
		}
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (rb.position.y < -1f)
		{
            FindObjectOfType<GameManager>().EndGame();
		}
    }
}
