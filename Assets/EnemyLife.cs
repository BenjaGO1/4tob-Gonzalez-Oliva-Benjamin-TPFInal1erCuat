
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyLife : MonoBehaviour
{
    public float health = 50f;
    public float speed;

    public void TakeDamage(float amount)
    {
        health -= amount;
        if (health <= 0)
        {
            Die();
        }
         
    }
    void Update()
    {
        transform.Translate(0, 0, speed * Time.deltaTime);
    }

    void Die()
    {
        Destroy(gameObject);
        
    }

    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Player")
        {
            SceneManager.LoadScene("Perdiste");
        }
    }


}
