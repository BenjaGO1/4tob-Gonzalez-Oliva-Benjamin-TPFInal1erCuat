using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class spawner : MonoBehaviour
{

    public GameObject EnemySpawner;
    public int CantEnemyWave = 5;
    int CurrentWave = 0;
     public int FinalWave = 4;
    GameObject clon;
    public float RestTime;
    public int CloneAmount;


    void Update()
    {
        while (FinalWave > CurrentWave)
        {
            clon = Instantiate(EnemySpawner);
            CurrentWave++;
        } 
    }
}
