using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stayinplace : MonoBehaviour {

    public Transform startPos, endPos;
    public string layer = "Ground";
    public bool needsCollision = true;

    private bool collision;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
        collision = Physics2D.Linecast (startPos.position, endPos.position, 1 << LayerMask.NameToLayer(layer));

        Debug.DrawLine(startPos.position, endPos.position, Color.green);

        if (collision == needsCollision)
        {
            transform.localScale = new Vector3(transform.localScale.x == 1 ? -1 : 1, 1, 1);
        }
	}
}
