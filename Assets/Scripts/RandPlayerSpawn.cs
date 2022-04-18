using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandPlayerSpawn : MonoBehaviour
{
    public Transform PSpawn;

    // Start is called before the first frame update
    void Start()
    {
        Transform[] Trans = GetComponentsInChildren<Transform>();
        Debug.Log(Trans);

        PSpawn.position = Trans[Random.Range(0, Trans.Length)].position;
    }
}
