using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreSController : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            GameController.Score += 30;
            Destroy(gameObject);
        }
    }
}
