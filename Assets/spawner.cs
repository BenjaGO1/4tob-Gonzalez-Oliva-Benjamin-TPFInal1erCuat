using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class spawner : MonoBehaviour
{

    public GameObject EnemySpawner;
    public int CantEnemyWave = 1;
    int CurrentWave = 0;
     public int FinalWave = 4;
    GameObject clon;
    public float RestTime;
    public int CloneAmount;
    public bool waited = true;


    void Update()
    {
        if (waited)
        {
            while (FinalWave > CurrentWave)
            {
                Instantiate(EnemySpawner);
                CurrentWave++;
                waited = false;

            }
        }
        if (!waited)
        {
            StartCoroutine(Wait());
        }
        

        if (CurrentWave >= FinalWave)
        {

        }
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(5);
        waited = true;
    }
}
