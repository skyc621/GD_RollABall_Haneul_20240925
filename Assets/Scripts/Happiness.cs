using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Happiness : MonoBehaviour
{
    void Update()
    {
        int RanNum1 = Random.Range(10, 1000);
        int RanNum2 = Random.Range(10, 1000);
        int RanNum3 = Random.Range(10, 1000);

        int RanNum4 = Random.Range(-10, -1000);
        int RanNum5 = Random.Range(-10, -1000);
        int RanNum6 = Random.Range(-10, -1000);

        for (int i = 0; i < 10000; i++)
        {
            transform.Rotate(new Vector3(RanNum1, RanNum2, RanNum3) * Time.deltaTime);
        }
        for (int i = 0; i < 10000; i++)
        {
            transform.Rotate(new Vector3(RanNum4, RanNum5, RanNum6) * Time.deltaTime);
        }

    }
}
