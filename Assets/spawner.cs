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
    public int FinalWave = 5;
    float CurrentRestTime = 0;
    public float RestTime;

    
    void Update()
    {
    var enemiesInScene  = FindObjectsOfType<EnemyLife>();
    if (enemiesInScene.Length == 0)
    {
    CurrentRestTime += Time.deltaTime;
    if(CurrentRestTime > RestTime)
    {
     for (int i = 0; i < CantEnemyWave; i++)
                {
                    Create();
                }
                CurrentRestTime = 0;
                CurrentWave ++;
                CantEnemyWave += Mathf.RoundToInt(CantEnemyWave / 2);
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
        Instantiate(EnemyPrefab, posicion, Quaternion.identity);
    }
    void destruir ()
    {
        Destroy(gameObject);
    }
}

  
