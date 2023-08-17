using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.InputSystem;


public class Shoot : MonoBehaviour
{
    public Transform ShootingPoint;
    public GameObject bulletPrefab;

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            Instantiate(bulletPrefab, ShootingPoint.position, transform.rotation);
        }
    }
}
