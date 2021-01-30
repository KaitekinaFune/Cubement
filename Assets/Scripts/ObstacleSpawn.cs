using UnityEngine;
using System.Collections.Generic;
using System.Linq;

public class ObstacleSpawn : MonoBehaviour
{
	private int objNum;
	public float DelayTime = 2f;
	public GameObject Player;
	public float Speed = 2000f;
	public List<GameObject> Obstacles;
	int score;

	void Start()
	{
		Obstacles = Resources.LoadAll<GameObject>("Obstacles").ToList();
		InvokeRepeating("SpawnObject", 1f, 1f);
	}
    

	void SpawnObject ()
	{
		score = Player.GetComponent<PlayerMovement>().Score;
		if (score != 0 && score % 5 == 0)
			Speed -= 3000f;
		int objNumOld = objNum;
		objNum = Random.Range(0, Obstacles.Count);
		while (objNumOld == objNum)
			objNum = Random.Range(0, Obstacles.Count);
		Instantiate(Obstacles[objNum], new Vector3(0, 0, 0), Quaternion.identity);
	}
}
