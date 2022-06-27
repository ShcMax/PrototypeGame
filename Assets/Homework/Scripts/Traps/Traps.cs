using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Traps : TrapsManager
{
    public struct FireTrap
    {
        public int Damage;

        public FireTrap(int damage)
        {
            this.Damage = damage;
        }
    }

    public struct FrozenTrap
    {
        public float SpeedDebuff;

        public FrozenTrap(float speedDebuff)
        {
            this.SpeedDebuff = speedDebuff;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        FireTrap fireTrap = new FireTrap(25);

        FrozenTrap frozenTrap = new FrozenTrap(3f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
