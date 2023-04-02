using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteor : MonoBehaviour
{
    public float speed;

    public GameObject meteor;

    public int meteors;


    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {

            gameObject.transform.position = new Vector3(0, 0, 0);
            for (int i = 0; i < meteors; i++)
            {
                Instantiate(meteor, transform.position, Quaternion.identity);
            }
        }
    }
}
    
