using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zombiecontroller : MonoBehaviour
{
    public int zombieHealth = 100;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void GetHit(int damage)
    {
        zombieHealth -= damage;
        if (zombieHealth <= 0)
        {
            Destroy(gameObject);
        }
    }
}
