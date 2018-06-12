﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShip : MonoBehaviour {

    public bool isSelected { get; private set; }
    public int ID;
    public bool isDrawPreview;
    public Vector2 targetPosition;

    public LineRenderer travelLine;
    public SpriteRenderer shipSprite;

	// Use this for initialization
	void Start () {
        SetInitialValue();

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void SetInitialValue () {
        isSelected = false;
    }

    private void OnCollisionEnter2D (Collision2D collision) {
        Debug.Log("Player (" + gameObject.name + ") hit");
    }

    public void Select () {
        isSelected = true;

        shipSprite.color = new Color(1, 1, 1, 0.5f);
    }

    public void Deselect () {
        isSelected = false;

        shipSprite.color = new Color(1, 1, 1, 1);
    }

    public void SetTargetPosition (Vector2 position) {
        targetPosition = position;
        DrawPreviewLine();
    }

    public void DrawPreviewLine () {
        travelLine.positionCount = 2;
        travelLine.SetPosition(0, gameObject.transform.position);
        travelLine.SetPosition(1, new Vector3(targetPosition.x, targetPosition.y, gameObject.transform.position.z));
    }
}
