using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Baffs : BaffsManager
{
    public struct SpeedBuff
    {
        public float Speed;

        public SpeedBuff(float speed)
        {
            this.Speed = speed;
        }
    }

    public struct HealthBuff
    {
        public int Health;

        public HealthBuff(int health)
        {
            this.Health = health;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        SpeedBuff speedBuff = new SpeedBuff(5f);

        HealthBuff healthBuff = new HealthBuff(50);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
