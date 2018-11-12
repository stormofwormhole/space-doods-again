using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthScript1 : MonoBehaviour {
     
    public Image Bar;
    public float max_health = 100f;
    public float cur_health = 0f;


	// Use this for initialization
	void Start () {

        cur_health = max_health;
        SetHealthBar();
	}

    public void TakeDamage(float amount) {

        cur_health -= amount;
        SetHealthBar();
    }
	// Update is called once per frame
	void SetHealthBar() {
        float my_health = cur_health / max_health;
        Bar.transform.localScale = new Vector2(Mathf.Clamp(my_health, 0f, 1f), Bar.transform.localScale.y);
	}
}
