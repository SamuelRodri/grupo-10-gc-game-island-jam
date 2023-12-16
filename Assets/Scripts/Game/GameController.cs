using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public enum GameMode
{
    pushing, leaving
}

public class GameController : MonoBehaviour
{
    public int totalPoints;
    public TMP_Text pointsText;
    public TMP_Text timerText;
    public GameMode gameMode = GameMode.pushing;
    private bool pushStarted = false;

    // Camera
    public float shakeDuration = 0.3f;
    public float shakeStrength = 0.3f;

    // Timer
    public int pushTime = 3;
    private int timer;

    // Start is called before the first frame update
    void Start()
    {
        pointsText.text = totalPoints.ToString();
        timerText.text = "";
        timer = pushTime;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.L))
        {
            gameMode = GameMode.leaving;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (!pushStarted)
            {
                pushStarted = true;
                StartCoroutine("CountDown");
            }
        }

        if (timer == 0) gameMode = GameMode.leaving;
    }

    public void DestroyElement(DestructibleObject destructible)
    {
        AddPoints(destructible.points);
        CameraShake.Shake(shakeDuration, shakeStrength);
        Destroy(destructible.gameObject);
    }

    public void AddPoints(int points)
    {
        totalPoints += points;
        pointsText.text = totalPoints.ToString();
    }

    IEnumerator CountDown()
    {
        for(int i = 0; i <= pushTime; i++)
        {
            timerText.text = timer.ToString();
            yield return new WaitForSeconds(1f);
            timer -= 1;
        }
    }
}
