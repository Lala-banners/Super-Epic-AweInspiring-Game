using UnityEngine;

public class Shooting : MonoBehaviour
{
    #region Public Variables
    [Tooltip("Where the net will fire from")]
    public Transform firePoint;

    [Tooltip("The projectile prefab")]
    public GameObject projectile;

    [Tooltip("How fast the projectile will travel to the ghost")]
    public float fireRate = 2f;

    public Sprite aimVisual; //dotted line for accurate shooting
    public SpriteRenderer spriteRenderer;
    #endregion

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ShootNet();
    }

    public void ShootNet()
    {
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            Camera mainCam = Camera.main;
            Vector2 mousePos = Input.mousePosition;

            //Get Rotation for Z Rotation
            Vector2 worldMousePos = mainCam.ScreenToWorldPoint(mousePos);
            Vector2 firePointPos = firePoint.transform.position;

            //Direction = Target - Current
            Vector2 direction = worldMousePos - firePointPos; //setting direction
            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg; //setting angle of aiming
            Quaternion rotation = Quaternion.Euler(new Vector3(0f, 0f, angle)); //setting the rotation
            Instantiate<GameObject>(projectile, firePointPos, rotation); //instantiate net to follow the mouse

            spriteRenderer.flipX = direction.x < 0; //flipping sprite to point in direction of shooting
        }
    }
}
