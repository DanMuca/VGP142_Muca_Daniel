using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandObjSpawn : MonoBehaviour
{
    public Transform Obj1;
    public Transform Obj2;
    public Transform Obj3;


    // Start is called before the first frame update
    void Start()
    {
        Transform[] Trans = GetComponentsInChildren<Transform>();

        Obj1.position = Trans[Random.Range(0, Trans.Length)].position;
        Obj2.position = Trans[Random.Range(0, Trans.Length)].position;
        Obj3.position = Trans[Random.Range(0, Trans.Length)].position;
    }
}
