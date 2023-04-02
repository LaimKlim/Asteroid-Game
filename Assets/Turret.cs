using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour
{
    public Bullet bullet;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) {
            Bullet bullets = Instantiate(bullet, transform.position, Quaternion.identity);
        }
    }
    }

