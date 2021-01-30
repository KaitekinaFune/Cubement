using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform plr;
    private Vector3 offset;

	private void Start()
	{
		offset = GetComponent<Transform>().position;
	}


	void Update()
    {
		transform.position = new Vector3(plr.position.x, 0, plr.position.z) + offset;
    }
}
