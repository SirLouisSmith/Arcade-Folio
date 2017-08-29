using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class G01_Manager : MonoBehaviour {

    public Text countdown, score;
    public GameObject mine, player, gameoverBox;
    private int scoreNum, rnd;
    private float counter, timerN, num, addN;
    private Vector2[] mineLocal;

	void Start () {
        scoreNum = 0;
        timerN = 0;
        counter = 3.5f;
        score.text = "Score: " + scoreNum;
        mineLocal = new Vector2[5];
        mineLocal[0] = new Vector2(-2, mine.transform.position.y);
        mineLocal[1] = new Vector2(-1, mine.transform.position.y);
        mineLocal[2] = new Vector2(0, mine.transform.position.y);
        mineLocal[3] = new Vector2(1, mine.transform.position.y);
        mineLocal[4] = new Vector2(2, mine.transform.position.y);

        num = 0;
        addN = 1;
	}
	
	// Update is called once per frame
	void Update () {
        score.text = "Score: " + scoreNum;
        if (counter >= 0.6f)
        {
            counter = counter - Time.deltaTime;
            countdown.text = Mathf.RoundToInt(counter) + "";
        }
        else if (counter >= -0.6f)
        {
            counter = counter - Time.deltaTime;
            countdown.text = "GO";
        }
        else
        {
            countdown.text = "";
            if (player != null)
            {
                if (!player.GetComponent<G01_Player>().IsDead())
                {
                    timerN += Time.deltaTime;
                    if (timerN >= num)
                    {
                        SpawnMines();
                        num += addN;
                        if (num >= 60)
                        {
                            if (addN >= 0.55f)
                                addN -= 0.01f;
                        }
                            
                    }
                }
                else
                {
                    Destroy(player);
                    gameoverBox.SetActive(true);
                }
            }
        }

	}

    public void AddPoint()
    {
        scoreNum++;
    }

    public float GetTime()
    {
        return timerN;
    }

    public void SpawnMines()
    {
        if (num >= 0 && num <= 19)
        {
            rnd = Random.Range(0, 5);

        }
        else if (num >= 20 && num <= 39)
        {
            rnd = Random.Range(0, 15);
            
        }
        else if (num >= 40 && num <= 59)
        {
            rnd = Random.Range(0, 24);

        }
        else if (num >= 60)
        {
            rnd = Random.Range(0, 29);

        }
        switch (rnd)
        {
            case 0:
                Instantiate(mine, mineLocal[rnd], Quaternion.identity);
                break;
            case 1:
                Instantiate(mine, mineLocal[rnd], Quaternion.identity);
                break;
            case 2:
                Instantiate(mine, mineLocal[rnd], Quaternion.identity);
                break;
            case 3:
                Instantiate(mine, mineLocal[rnd], Quaternion.identity);
                break;
            case 4:
                Instantiate(mine, mineLocal[rnd], Quaternion.identity);
                break;
            case 5:
                Instantiate(mine, mineLocal[0], Quaternion.identity);
                Instantiate(mine, mineLocal[1], Quaternion.identity);
                break;
            case 6:
                Instantiate(mine, mineLocal[0], Quaternion.identity);
                Instantiate(mine, mineLocal[2], Quaternion.identity);
                break;
            case 7:
                Instantiate(mine, mineLocal[0], Quaternion.identity);
                Instantiate(mine, mineLocal[3], Quaternion.identity);
                break;
            case 8:
                Instantiate(mine, mineLocal[0], Quaternion.identity);
                Instantiate(mine, mineLocal[4], Quaternion.identity);
                break;
            case 9:
                Instantiate(mine, mineLocal[1], Quaternion.identity);
                Instantiate(mine, mineLocal[2], Quaternion.identity);
                break;
            case 10:
                Instantiate(mine, mineLocal[1], Quaternion.identity);
                Instantiate(mine, mineLocal[3], Quaternion.identity);
                break;
            case 11:
                Instantiate(mine, mineLocal[1], Quaternion.identity);
                Instantiate(mine, mineLocal[4], Quaternion.identity);
                break;
            case 12:
                Instantiate(mine, mineLocal[2], Quaternion.identity);
                Instantiate(mine, mineLocal[3], Quaternion.identity);
                break;
            case 13:
                Instantiate(mine, mineLocal[2], Quaternion.identity);
                Instantiate(mine, mineLocal[4], Quaternion.identity);
                break;
            case 14:
                Instantiate(mine, mineLocal[3], Quaternion.identity);
                Instantiate(mine, mineLocal[4], Quaternion.identity);
                break;
            case 15:
                Instantiate(mine, mineLocal[0], Quaternion.identity);
                Instantiate(mine, mineLocal[1], Quaternion.identity);
                Instantiate(mine, mineLocal[2], Quaternion.identity);
                break;
            case 16:
                Instantiate(mine, mineLocal[0], Quaternion.identity);
                Instantiate(mine, mineLocal[1], Quaternion.identity);
                Instantiate(mine, mineLocal[3], Quaternion.identity);
                break;
            case 17:
                Instantiate(mine, mineLocal[0], Quaternion.identity);
                Instantiate(mine, mineLocal[1], Quaternion.identity);
                Instantiate(mine, mineLocal[4], Quaternion.identity);
                break;
            case 18:
                Instantiate(mine, mineLocal[0], Quaternion.identity);
                Instantiate(mine, mineLocal[2], Quaternion.identity);
                Instantiate(mine, mineLocal[3], Quaternion.identity);
                break;
            case 19:
                Instantiate(mine, mineLocal[0], Quaternion.identity);
                Instantiate(mine, mineLocal[2], Quaternion.identity);
                Instantiate(mine, mineLocal[4], Quaternion.identity);
                break;
            case 20:
                Instantiate(mine, mineLocal[1], Quaternion.identity);
                Instantiate(mine, mineLocal[2], Quaternion.identity);
                Instantiate(mine, mineLocal[3], Quaternion.identity);
                break;
            case 21:
                Instantiate(mine, mineLocal[1], Quaternion.identity);
                Instantiate(mine, mineLocal[2], Quaternion.identity);
                Instantiate(mine, mineLocal[4], Quaternion.identity);
                break;
            case 22:
                Instantiate(mine, mineLocal[1], Quaternion.identity);
                Instantiate(mine, mineLocal[3], Quaternion.identity);
                Instantiate(mine, mineLocal[4], Quaternion.identity);
                break;
            case 23:
                Instantiate(mine, mineLocal[2], Quaternion.identity);
                Instantiate(mine, mineLocal[3], Quaternion.identity);
                Instantiate(mine, mineLocal[4], Quaternion.identity);
                break;
            case 24:
                Instantiate(mine, mineLocal[1], Quaternion.identity);
                Instantiate(mine, mineLocal[2], Quaternion.identity);
                Instantiate(mine, mineLocal[3], Quaternion.identity);
                Instantiate(mine, mineLocal[4], Quaternion.identity);
                break;
            case 25:
                Instantiate(mine, mineLocal[0], Quaternion.identity);
                Instantiate(mine, mineLocal[2], Quaternion.identity);
                Instantiate(mine, mineLocal[3], Quaternion.identity);
                Instantiate(mine, mineLocal[4], Quaternion.identity);
                break;
            case 26:
                Instantiate(mine, mineLocal[0], Quaternion.identity);
                Instantiate(mine, mineLocal[1], Quaternion.identity);
                Instantiate(mine, mineLocal[3], Quaternion.identity);
                Instantiate(mine, mineLocal[4], Quaternion.identity);
                break;
            case 27:
                Instantiate(mine, mineLocal[0], Quaternion.identity);
                Instantiate(mine, mineLocal[1], Quaternion.identity);
                Instantiate(mine, mineLocal[2], Quaternion.identity);
                Instantiate(mine, mineLocal[4], Quaternion.identity);
                break;
            case 28:
                Instantiate(mine, mineLocal[0], Quaternion.identity);
                Instantiate(mine, mineLocal[1], Quaternion.identity);
                Instantiate(mine, mineLocal[2], Quaternion.identity);
                Instantiate(mine, mineLocal[3], Quaternion.identity);
                break;
        }
    }
}
