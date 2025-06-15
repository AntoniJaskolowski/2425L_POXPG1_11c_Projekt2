using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    public Inventory aplcunt;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!collision.gameObject.CompareTag("Player"))
        {
            return;
        }
        Inventory aplcunt = collision.gameObject.GetComponent<Inventory>();

        if (aplcunt == null)
        {
            return;
        }
        aplcunt.AplUp();
        //TODO Send info to Player
        //TODO Check if inventory component exists

        Destroy(gameObject);
    }
}
