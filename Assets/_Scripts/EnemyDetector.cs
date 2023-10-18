using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDetector : MonoBehaviour
{
    public static bool _canShoot = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        _canShoot = true;
        Debug.Log("can shoot");
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        _canShoot = false;
        Debug.Log("out of range");
    }
}
