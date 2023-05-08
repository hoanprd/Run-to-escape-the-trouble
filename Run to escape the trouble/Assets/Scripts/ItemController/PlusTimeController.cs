using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlusTimeController : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            GameController.PlusTimeActive = true;
            Destroy(gameObject);
        }
    }
}
