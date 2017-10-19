﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {
    // Use this for initialization
    void Start() {
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetMouseButtonDown(0)) {
            OnLeftMouseDown();
        }
    }

    void OnLeftMouseDown() {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit)) {
            print("OnLeftMouseDown");
            string tag = hit.collider.gameObject.tag;
            // TODO
            switch (tag) {
                case "NPC":
                    break;

                case "Pickable":
                    break;
            }
        }
    }
}
