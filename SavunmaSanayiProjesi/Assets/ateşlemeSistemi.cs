using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AteþlemeSistemi : MonoBehaviour
{
    public GameObject bullet;
    public Transform bulletExitPos;

    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Instantiate(bullet, bulletExitPos.position, transform.rotation * Quaternion.Euler(0, 0, 0));
        }
    }
}
