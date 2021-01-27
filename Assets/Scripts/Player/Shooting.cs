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
    #endregion

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
        }
    }
}
