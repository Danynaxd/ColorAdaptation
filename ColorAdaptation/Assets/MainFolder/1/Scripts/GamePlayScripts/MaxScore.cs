﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MaxScore : MonoBehaviour {

	void Start ()
	{
		GetComponent <Text> ().text = PlayerPrefs.GetInt ("score").ToString ();
	}
}
