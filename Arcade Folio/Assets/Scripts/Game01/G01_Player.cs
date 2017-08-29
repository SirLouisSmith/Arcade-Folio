using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class G01_Player : MonoBehaviour {
    //public variables
    
    //private variables
    private Vector2[] shipLocal;
    private bool dead;
    private int localNum;
    
	void Start () {
        shipLocal = new Vector2[5];
        shipLocal[0] = new Vector2(-2, -4);
        shipLocal[1] = new Vector2(-1, -4);
        shipLocal[2] = new Vector2(0, -4);
        shipLocal[3] = new Vector2(1, -4);
        shipLocal[4] = new Vector2(2, -4);

        localNum = 2;
        dead = false;
	}

	void Update () {
        //Player input
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (localNum > 0)
            {
                localNum--;
                this.transform.position = shipLocal[localNum];
            }
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (localNum < 4)
            {
                localNum++;
                this.transform.position = shipLocal[localNum];
            }
        }
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            dead = true;
            Debug.Log("Dead");
        }
    }
    public bool IsDead()
    {
        return dead;
    }
}
