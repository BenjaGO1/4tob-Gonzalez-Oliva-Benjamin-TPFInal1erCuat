using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class spawner : MonoBehaviour
{

    public GameObject EnemyPrefab;
    public Transform[] spawnPos;
    public int CantEnemyWave = 1;
    int CurrentWave = 0;
    int FinalWave = 5;
    float CurrentRestTime = 0;
    public float RestTime;

    
    void Update()
    {
    var enemiesInScene  = FindObjectsOfType<Enemy>();
    if (enemiesInScene.Length == 0)
    {
    currentRestTime += Time.deltaTime;
    if(currentRestTime > restTime)
    {
     for (int i = 0; i < cantEnemigosWave; i++)
                {
                    Create();
                }
                currentRestTime = 0;
                CurrentWave ++;
                cantEnemigosWave += Mathf.RoundToInt(cantEnemigosWave / 2);
            }
        }
        else if (CurrentWave == FinalWave)
        {
            destruir();
            SceneManager.LoadScene("Ganaste");
        }

    }

    void Create()
    {
        float y = Random.Range(spawnPos[0].position.y, spawnPos[1].position.y);
        float x = Random.Range(spawnPos[0].position.x, spawnPos[1].position.x);
        float z = Random.Range(spawnPos[0].position.z, spawnPos[1].position.z);
        Vector3 posicion = new Vector3(x, y, z);
        Instantiate(EnemigoPrefab, posicion, Quaternion.identity);
    }
    void destruir ()
    {
        Destroy(gameObject);
    }
}

  
