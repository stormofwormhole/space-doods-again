using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour {

    private Transform destination;

    public bool isBlackHole02;
    public float distance = 0.3f;

    void Start(){

        if(isBlackHole02 == false){
            destination = GameObject.FindGameObjectWithTag("BlackHole02").GetComponent<Transform>();
        }else{
            destination = GameObject.FindGameObjectWithTag("BlackHole01").GetComponent<Transform>();
        }
    }

    void OnTriggerEnter2D(Collider2D other){
        if(Vector2.Distance(transform.position, other.transform.position ) > distance)
        {

            other.transform.position = new Vector2(destination.position.x, destination.position.y);
        }
    
    }
}
