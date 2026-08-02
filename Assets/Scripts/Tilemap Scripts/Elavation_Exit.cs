using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elavation_Exit : MonoBehaviour
{
    public Collider2D[] moutainColliders;
    public Collider2D[] boundaryColliders;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            foreach (Collider2D mountain in moutainColliders)
            {
                mountain.enabled = true;
            }
            foreach (Collider2D boundary in boundaryColliders)
            {
                boundary.enabled = false;
            }
            collision.gameObject.GetComponent<SpriteRenderer>().sortingOrder = 5;
        }
    }
}
