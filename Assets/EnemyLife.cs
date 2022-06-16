
using UnityEngine;

public class EnemyLife : MonoBehaviour
{
    public float health = 50f;
    public int EnemyCounter = 5;

    public void TakeDamage(float amount)
    {
        health -= amount;
        if (health <= 0f)
        {
            Die();
        }
    }

    void Die()
    {
        Destroy(gameObject);
    }
    
}
