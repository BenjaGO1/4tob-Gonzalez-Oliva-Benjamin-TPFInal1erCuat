using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public float speed = 20f;
    public float LifeTime;
    //public ParticleSystem DestroyBullet;
    public GameObject enemy;
    public GameObject enemy2;
    public GameObject enemy3;
    public int cantenemy;
    public int cantenemy2;
    public int cantenemy3;

    void Start()
    {
        Destroy(gameObject, LifeTime);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.right * speed * Time.deltaTime;
    }

    private void OnDestroy()
    {
        //Instantiate(DestroyBullet, transform.position, transform.rotation);
        Destroy(gameObject);
    }

    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "enemy")
        {
            Destroy(enemy);
        }
    }
}
