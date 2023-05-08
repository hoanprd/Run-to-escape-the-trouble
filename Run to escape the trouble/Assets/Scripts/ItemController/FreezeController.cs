using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreezeController : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            GameController.FreezeActive = true;
            GameController.FreezeCD = 10;
            Destroy(gameObject);
        }
    }
}
