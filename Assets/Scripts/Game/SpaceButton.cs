using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceButton : MonoBehaviour
{
    private GameController gameController;

    // Start is called before the first frame update
    void Start()
    {
        gameController = FindObjectOfType<GameController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (gameController.gameMode.Equals(GameMode.leaving))
        {
            GetComponent<SpriteRenderer>().enabled = false;
        }
    }
}
