using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class Stone : MonoBehaviour
{
    public float pushPower = 0;
    public float stepPower = 100;
    public float cooldownPower = 5;

    private Rigidbody2D rb;
    private GameController gameController;

    public Sprite downSprite;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        gameController = FindObjectOfType<GameController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (gameController.gameMode.Equals(GameMode.pushing))
        {
            rb.AddForce(new Vector2(-1, 0.1f) * pushPower * Time.deltaTime, ForceMode2D.Force);

            if (Input.GetKeyDown(KeyCode.Space))
            {
                pushPower += stepPower;
            }

            if (pushPower > 0)
                pushPower -= Time.deltaTime * cooldownPower;
        }

        if(gameController.gameMode.Equals(GameMode.leaving))
        {
            GetComponent<SpriteRenderer>().sprite = downSprite;
        }
    }
}
