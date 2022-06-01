using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Photon.Pun;

public class GameManager : MonoBehaviour
{
	public string playerName = "";
	public string levelSeed = "";
	
    void Awake() {
		DontDestroyOnLoad(gameObject);
    }
}
