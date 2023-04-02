using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Shooting : MonoBehaviour
{

    public GameObject prefab;
    public TMP_Text bulletCount;

    public AudioSource audio;

    public int maxBullets;

    public int bullets;

    public float nextSpawnTime;
    public float spawnInterval;



    private void Start()
    {
        nextSpawnTime = Time.time;
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && bullets > 0)
        {
            Shoot();
        }

        if (Time.time > nextSpawnTime)
        {

            if (bullets < maxBullets)
            {
                bullets++;
            }

            nextSpawnTime += spawnInterval;
        }

        bulletCount.text = bullets.ToString();

    }

    void Shoot()
    {

        audio.Play();

        var pos = transform.position;
        pos.z = transform.position.z;
        pos.x = transform.position.x+1;
        var rot = Quaternion.Euler(new Vector3(0, 0, -90));

        Instantiate(prefab, pos, rot);

        bullets--;
    }
}
