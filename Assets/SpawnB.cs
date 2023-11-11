using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnB : MonoBehaviour
{
    public GameObject Circle;

    public float Xposition;
    public float Yposition;
    public float time;


    void Start()
    {
        StartCoroutine(SpawnManager());
    }


    IEnumerator SpawnManager()
    {
        Xposition = Random.Range(-7, 7);
        Yposition = Random.Range(-3, -4);
        time = Random.Range(1, 10);
      

        yield return new WaitForSeconds(2f);

        while (true)
        {
            Instantiate(Circle, new Vector2(Xposition, Yposition), Quaternion.identity);

            yield return new WaitForSeconds(time);
        }
    }
}
