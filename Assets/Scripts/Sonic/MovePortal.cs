using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePortal : MonoBehaviour {

    private Vector2 target;
    private Transform blackHole01;
    private Transform blackHole02;

    void Start(){
        blackHole01 = GameObject.FindGameObjectWithTag("BlackHole01").GetComponent<Transform>();
        blackHole02 = GameObject.FindGameObjectWithTag("BlackHole02").GetComponent<Transform>();
    }

    void Update(){

        if(Input.GetMouseButton(0)){
            target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            blackHole01.position = new Vector2(target.x, target.y);
        } else if(Input.GetMouseButtonDown(1)){
            target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            blackHole02.position = new Vector2(target.x, target.y);
        }
     }

}
