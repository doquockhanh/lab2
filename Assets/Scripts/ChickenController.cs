using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickenController : MonoBehaviour
{
    public GameObject egg;
    void Start()
    {
        createEgg();
    }

    private void createEgg()
    {
        Instantiate(egg, transform.position, Quaternion.identity);
        CancelInvoke("createEgg");
        float nextInterval = Random.Range(1f, 3f);
        InvokeRepeating("createEgg", nextInterval, nextInterval);
    }

}
