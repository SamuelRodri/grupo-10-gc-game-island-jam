using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundDisapear : MonoBehaviour
{
    private GameController gameController;
    private BoxCollider2D boxCollider;

    // Start is called before the first frame update
    void Start()
    {
        gameController = FindObjectOfType<GameController>();
        boxCollider = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(gameController.gameMode.Equals(GameMode.leaving))
        {
            boxCollider.enabled = false;
        }
    }
}
