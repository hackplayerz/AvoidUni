/*
 *		CopyRight : Dev.Alter0
 *		https://github.com/hackplayerz
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnController : MonoBehaviour {
	SetPointController pointCtrl = null;
	public GameObject EnemyPrefab = null;
	public GameObject HorUniPrefab = null;
	private int Count = 0;
	private int SetSpawnDeadline = 3;
	private float _delta = 0f;
	private float MaxRage = 0.6f;
	private float HorSpawnTime = 0;
	private float HorSpawnRemain = 4f;
	void Start () {
		pointCtrl = GameObject.FindGameObjectWithTag ("GameController").GetComponent<SetPointController> ();
	}
	void Update () {
		InstantiateEnemy ();
	}
	void InstantiateEnemy () {
		float _span = Random.Range (0.01f, MaxRage);
		HorSpawnTime += Time.deltaTime;
		_delta += Time.deltaTime;

		if (_delta > _span) {
			_delta = 0f;
			GameObject Enemy = Instantiate (EnemyPrefab) as GameObject;
			pointCtrl.Count++;
			float px = Random.Range (-9.5f, 10f);
			Enemy.transform.position = new Vector3 (px, 10, 0);
			Count++;
		}
		if (HorSpawnTime > HorSpawnRemain) {
			SpawnEnemy ();
			HorSpawnRemain -= 0.1f;
			HorSpawnTime = 0;
		}
	}
	void SpawnEnemy () {
		GameObject Spawner = Instantiate (HorUniPrefab) as GameObject;
		float py = Random.Range (-1f, .3f);
		Spawner.transform.position = new Vector3 (11, py, 0);
		Count++;
	}
}
