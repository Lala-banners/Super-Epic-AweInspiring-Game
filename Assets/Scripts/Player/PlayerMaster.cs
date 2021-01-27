using UnityEngine;

public class PlayerMaster : MonoBehaviour
{
    //Move left and right
    //Flip sprite
    //Aim gun upwards with rotation

    #region Private Variables
    [SerializeField] private float currentHealth;
    [SerializeField] private float maxHealth = 100f;
    private SpriteRenderer spriteRenderer;

    #endregion

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    //Move the player left and right
    public void Move()
    {
        
    }

    public void Flip()
    {
        spriteRenderer.flipX = !spriteRenderer.flipX;
    }
}
