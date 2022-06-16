
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyLife : MonoBehaviour
{
    public float health = 50f;
    

    public void TakeDamage(float amount)
    {
        health -= amount;
        if (health <= 0)
        {
            Die();
        }
        if ()
        {
            Debug.Log("ganaste");
            SceneManager.LoadScene("Ganaste");
        }   
    }

    void Die()
    {
        Destroy(gameObject);
        
    }
    
}
