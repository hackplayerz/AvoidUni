/*
 *		CopyRight : Dev.Alter0
 *		https://github.com/hackplayerz
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetPointController : MonoBehaviour {
	Text PointText = null;
	public int Point = 0;
	public float EnemeySpeed = -.1f;

	public int Count = 0;
	void Start () 
	{
		PointText = GameObject.FindGameObjectWithTag("Point").GetComponent<Text>();
	}
	public void GetPoint(){
		Point++;
		PointText.text = Point.ToString();
		if(Count == 10 && EnemeySpeed < .7f){
			EnemeySpeed -= .02f;
			Count = 0;
		}
	}
}
