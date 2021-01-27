using UnityEngine;

public class NetBeamVisual : MonoBehaviour
{
    //Fire line visual to show where projectile will go

    public GameObject crosshairs;
    //public GameObject projectileVisual;
    private Vector3 target;

    // Start is called before the first frame update
    void Start()
    {
        //Hide the cursor
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        //Make target line
        target = transform.GetComponent<Camera>().ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, transform.position.z));
        crosshairs.transform.position = new Vector2(target.x, target.y); //make crosshairs position same as mouse for accurate shooting
    }
}
