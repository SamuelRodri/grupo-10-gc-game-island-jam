using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestructibleObject : MonoBehaviour
{
    [SerializeField] public Sprite brokenVersion;

    public int points;

    private GameController gameController;

    public Explosion explosion;

    // Start is called before the first frame update
    void Start()
    {
        gameController = FindAnyObjectByType<GameController>();
        explosion = transform.GetChild(0).gameObject.GetComponent<Explosion>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Boulder"))
        {
            gameController.DestroyElement(this);
        }
    }

    public void Destroy()
    {
        gameObject.GetComponent<SpriteRenderer>().sprite = brokenVersion;
    }
}
