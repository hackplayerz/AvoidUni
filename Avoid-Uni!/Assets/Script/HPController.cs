/*
 *		CopyRight : Dev.Alter0
 *		https://github.com/hackplayerz
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPController : MonoBehaviour {
	GameObject hp;
	void Start () 
	{
		hp = GameObject.FindWithTag("HP");
	}
	public void GetDamage(){
		hp.GetComponent<Image>().fillAmount -= 0.1f;
	//	Debug.Log("Damage");
	}
}
