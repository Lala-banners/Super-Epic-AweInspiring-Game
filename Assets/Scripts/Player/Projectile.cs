using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float movementSpeed = 10f;
    private SpriteRenderer spriteRenderer;


    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.right * Time.deltaTime * movementSpeed;

        //If no longer visible
        if (!spriteRenderer.isVisible)
        {
            //Destroy net
            Destroy(gameObject);
        }
    }

    // OnTriggerEnter2D is called when the Collider2D other enters the trigger (2D physics only)
    /*private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.TryGetComponent<Ghost>(out Ghost ghost)
        {
            //Start capture beam 

            //If capture complete, remove Ghost from game

            //If capture incomplete, ghost state = attack

        }
    }*/
}
