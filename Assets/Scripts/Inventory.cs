using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Inventory : MonoBehaviour
{
    public int apl = 0;
    //public Number of apples

    public void AplUp()
    {
        apl++;
        Debug.Log(apl);
    

    }

}
