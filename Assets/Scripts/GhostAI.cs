using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class GhostAI : MonoBehaviour
{

    public Transform Player;
    public Transform LookAwayCheck;
    public Renderer rend;

    int MoveSpeed = 3;
    int MinDist = 1;

    public bool GhostLookedAt = false;

    void Start()
    {
        rend = GetComponent<Renderer>();
    }

    void Update()
    {
        //LookAwayCheck.position = transform.position;

        if (GhostLookedAt == false)
        {
        transform.LookAt(Player);

            if (Vector3.Distance(transform.position, Player.position) >= MinDist)
            {

                transform.position += transform.forward * MoveSpeed * Time.deltaTime;

                rend.enabled = true;

            }
        } 
        else
        {
            GhostLookedAt = false;
        } 
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Bullet")
        {
            Destroy(gameObject);
            Debug.Log("Ghost Killed");
        }
    }
}
