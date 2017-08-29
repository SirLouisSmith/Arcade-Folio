using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class G01_Mine : MonoBehaviour {

    public float startSpd, currentSpd,maxSpd;
    private float cTime;
    private Vector2 bottom;
    private GameObject manager, player;
	void Start () {
        bottom = new Vector2(this.transform.position.x, -7);
        manager = GameObject.Find("thisGameManager");
        player = GameObject.Find("Ship");
        SetSpeed();
	}
	
	// Update is called once per frame
	void Update () {
        this.transform.position = Vector2.MoveTowards(this.transform.position, bottom, currentSpd);
        if (this.transform.position.y <= -6)
        {
            manager.GetComponent<G01_Manager>().AddPoint();
            Destroy(this);
        }
        if (player == null)
            Destroy(this);
	}

    void SetSpeed()
    {
        cTime = manager.GetComponent<G01_Manager>().GetTime();
        float temp = startSpd + (cTime / 10);
        if (temp <= maxSpd)
            currentSpd = temp;
        else
            currentSpd = maxSpd;
        //Temp
        currentSpd = maxSpd;
    }
}
