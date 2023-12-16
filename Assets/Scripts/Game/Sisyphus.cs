using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sisyphus : MonoBehaviour
{
    public GameObject boulder;
    public GameController gameController;

    private Vector3 distanceBoulder;
    private Vector3 posicionOriginal;

    // Start is called before the first frame update
    void Start()
    {
        gameController = FindObjectOfType<GameController>();
        distanceBoulder = boulder.transform.position - transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (gameController.gameMode.Equals(GameMode.pushing))
        {
            transform.position = boulder.transform.position - distanceBoulder;
        }
    }
}
