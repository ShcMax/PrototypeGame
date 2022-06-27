using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shield : MonoBehaviour
{
    private SphereCollider _sphereCollider;
    private int healthShield = 50;
    private float lifeTime = 10f;    // Start is called before the first frame update
    private void Awake()
    {
        _sphereCollider = GetComponent<SphereCollider>();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
