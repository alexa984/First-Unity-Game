﻿using UnityEngine;
using System.Collections;

public class LoopController : MonoBehaviour {
    public GameObject player;
    private float offsetX;
	// Use this for initialization
	public void Start () {
        this.offsetX = this.transform.position.x - this.player.transform.position.x;

	}
	
	// Update is called once per frame
	public void Update () {
       
            var position = this.transform.position;
            if (this.player.transform.position.x > 0f)
        {
            position.x = this.player.transform.position.x + offsetX;
            this.transform.position = position;
        }
        else position.x =0f ;
	}
}
