using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast : MonoBehaviour
{
    [SerializeField]
    Transform rayOrgin;

    [SerializeField]
    Rigidbody projectilePrefab;

    [SerializeField]
    float projectileForce;

    public GhostAI Ghost;
    public LayerMask CheckLayers;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hitInfo;
            
        if (Physics.Raycast(rayOrgin.transform.position, transform.forward, out hitInfo, 25.0f, CheckLayers))
        {
            Debug.Log("Hit : " + hitInfo.transform.gameObject.name);
            if (hitInfo.transform.gameObject.name == "Ghost")
            {
                Ghost.GhostLookedAt = true;
                Ghost.rend.enabled = false;
            }

        }

        Vector3 endPos = transform.forward * 25.0f;
        Debug.DrawRay(rayOrgin.transform.position, endPos, Color.red);
    }

    public void FireProjectile()
    {
        if (rayOrgin && projectilePrefab)
        {
            Rigidbody temp = Instantiate(projectilePrefab, rayOrgin.position, rayOrgin.rotation);
            temp.AddForce(transform.forward * projectileForce, ForceMode.Impulse);

            Destroy(temp.gameObject, 2.0f);
        }
    }

}
