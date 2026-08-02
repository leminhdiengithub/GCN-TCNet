using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elavation_Entry : MonoBehaviour
{
    public Collider2D[] moutainColliders;
    public Collider2D[] boundaryColliders;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {            
            foreach ( Collider2D mountain in moutainColliders)
            {
                mountain.enabled = false;
            }
            foreach (Collider2D boundary in boundaryColliders)
            {
                boundary.enabled = true;
            }
            collision.gameObject.GetComponent<SpriteRenderer>().sortingOrder = 15;
        }
    }
}
