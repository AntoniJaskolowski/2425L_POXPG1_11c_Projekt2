using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AppleCount : MonoBehaviour
{
    public Inventory inventory;
    public TMP_Text ACount;
    // Start is called before the first frame update
    void Start()
    {
        inventory = GetComponent<Inventory>();
    }

    // Update is called once per frame
    void Update()
    {
        ACount.text = "Apples: " + inventory.apl;

    }
}
