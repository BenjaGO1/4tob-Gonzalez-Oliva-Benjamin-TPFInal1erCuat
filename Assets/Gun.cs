using UnityEngine;

public class Gun : MonoBehaviour
{

    public float damage = 10f;
    public float range = 100f;
    public float impactForce = 30f;
    public float fireRate = 15f;

    public AudioSource source;
    public AudioClip clip;

    public Camera fpsCam;
    private float nextTimetoFire = 0f;

    void Update()
    {
        if (Input.GetButton("Fire1") && Time.time >= nextTimetoFire)
        {
            nextTimetoFire = Time.time + 1f / fireRate;
            Shoot();
        }
    }

    void Shoot()
    {
        PlayClip();
        RaycastHit hit;
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);
            EnemyLife enemylife = hit.transform.GetComponent<EnemyLife>();
            if(enemylife != null)
            {
                enemylife.TakeDamage(damage);
            }

            if (hit.rigidbody != null)
            {
                hit.rigidbody.AddForce(-hit.normal * impactForce);
            }
        }
    }
    public void PlayClip()
    {
        source.clip = clip;
        source.Play();
    }
}
