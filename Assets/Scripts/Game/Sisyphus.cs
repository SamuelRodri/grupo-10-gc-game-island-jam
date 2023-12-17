using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sisyphus : MonoBehaviour
{
    public GameObject boulder;
    public GameController gameController;

    private Vector3 distanceBoulder;
    private Vector3 posicionOriginal;

    public bool isPushing = false;
    public bool isStoped = false;
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        gameController = FindObjectOfType<GameController>();
        distanceBoulder = boulder.transform.position - transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (gameController.gameMode.Equals(GameMode.pushing) && !isStoped)
        {
            if (!isPushing)
            {
                animator.SetBool("Pushing", true);
                isPushing = true;
            }

            transform.position = boulder.transform.position - distanceBoulder;
        }

        if (gameController.gameMode.Equals(GameMode.leaving))
        {
            animator.SetBool("Droped", true);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag.Equals("Limit"))
        {
            isStoped = true;
            animator.SetBool("Lost", true);
        }
    }
}
