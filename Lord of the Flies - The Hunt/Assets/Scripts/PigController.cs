using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PigController : MonoBehaviour 
{
	public GameObject pigGO;
	public Transform spawn1;
	public Transform spawn2;
	public Transform spawn3;
	public Transform spawn4;
	public Transform spawn5;

	public int spawnRanNum;
	private float spawnIntervalTime = 0.5f;

	private int spawnTileMin = 1;
	private int spawnTileMax = 6;


	public void randomize()
	{
		spawnRanNum = Random.Range (spawnTileMin, spawnTileMax);
	}

	public void Update()
	{
		switch (spawnRanNum) 
		{
		case 1:
			pigGO.transform.position = spawn1.position;
			break;
		case 2:
			pigGO.transform.position = spawn2.position;
			break;
		case 3:
			pigGO.transform.position = spawn3.position;
			break;
		case 4:
			pigGO.transform.position = spawn4.position;
			break;
		case 5:
			pigGO.transform.position = spawn5.position;
			break;
		default:
			pigGO.transform.position = spawn5.position;
			break;
		}
	}

	public void Start()
	{
		InvokeRepeating ("randomize", 0, spawnIntervalTime);
	}
}