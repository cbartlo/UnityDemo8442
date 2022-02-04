using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CritterControl : MonoBehaviour
{
    
    CritterStats myStats; 
    // Start is called before the first frame update
    void Start()
    {
        myStats = new CritterStats();
        myStats.height = 1.4f + Random.Range(2,303);
        myStats.foodEaten = 0;
    }

    // Update is called once per frame
    void Update()
    {
        myStats.foodEaten++;
        Debug.Log("I eat!" + myStats.height.ToString());
    }
}
