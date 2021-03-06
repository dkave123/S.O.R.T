﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Life : MonoBehaviour {
	public int count = 4;
	public GameObject mons, victoryPanel;
	SpriteRenderer spriteRenderer;
    // Use this for initialization
    void Start () {
		spriteRenderer = (SpriteRenderer)mons.GetComponent<Renderer>();
    }
	
	// Update is called once per frame
	void Update () {
		if (count == 4) {
			Destroy (mons);
		}
    }
		
	void OnTriggerEnter2D(Collider2D Col)
    {
        
		if (Col.gameObject.tag == "Power") {
			count++;
		}

		StartCoroutine(Wait());
		StopCoroutine (Wait());
	}

	IEnumerator Wait(){
		spriteRenderer.color = new Color(255, 0, 0, 1);
		//spriteRenderer = (SpriteRenderer)mons.GetComponent<Renderer>();
		yield return new WaitForSeconds (0.1f);
		spriteRenderer.color = new Color(255, 255, 255, 255);
		//spriteRenderer = (SpriteRenderer)mons.GetComponent<Renderer>();
	}
}
