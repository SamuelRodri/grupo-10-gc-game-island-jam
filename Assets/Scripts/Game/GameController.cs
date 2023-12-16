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
    public GameMode gameMode = GameMode.pushing;

    // Camera
    public float shakeDuration = 0.3f;
    public float shakeStrength = 0.3f;

    // Start is called before the first frame update
    void Start()
    {
        pointsText.text = totalPoints.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.L))
        {
            gameMode = GameMode.leaving;
        }
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
}
