using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageScript1 : MonoBehaviour {

    float damage = 5f;

	// Use this for initialization
	void Start () {
		
	}
	
   void OnTriggerEnter2D(Collider2D other)
    {
       //if (other.gameObject.tag =="Player"){
            
        other.gameObject.GetComponent<HealthScript>().TakeDamage(damage);
        Debug.Log("DAMAGE");
    }

}


