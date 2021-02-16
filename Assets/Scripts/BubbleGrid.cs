using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleGrid : MonoBehaviour
{
    //This script will handle the grid and set up of the bubbles

    [SerializeField]
    private int rows = 20;

    [SerializeField]
    private int columns = 14;

    [SerializeField]
    private float tileSize = 0.68f;

    [SerializeField]
    private int emptyLines = 16;

    public GameObject gridBubbleGO;

    [HideInInspector]
    private float gridOffsetX = 0;
    public List<Ball> matchList = new List<Ball>();
    

    // Start is called before the first frame update
    void Start()
    {
        
    }
}
