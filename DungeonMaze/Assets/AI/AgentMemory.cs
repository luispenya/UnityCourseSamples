﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class AgentMemory : MonoBehaviour {

    public Dictionary<string, int> rawMemory;

	// Use this for initialization
	void Start () {
        rawMemory = new Dictionary<string, int>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
