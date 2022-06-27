using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    private float playerSpeed = 5;
    private int playerHealth = 100;

    public float PlayerSpeed { get => playerSpeed; set => playerSpeed = value; }
    public int PlayerHealth { get => playerHealth; set => playerHealth = value; }    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
