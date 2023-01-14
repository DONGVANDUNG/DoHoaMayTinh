using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zombiecontroller : MonoBehaviour
{
    public int damage = 2;
    public int zombieHealth = 34;
    public float fireTime = 0.3f;
    private float lastFireTime = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void UpdateFireTime()
    {
        lastFireTime = Time.time;
    }
    void Fire()
    {
        if (Time.time >= lastFireTime + fireTime)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform.tag.Equals("player"))
                {
                    hit.transform.gameObject.GetComponent<zombiecontroller>().GetHit(damage);
                }
            }
            UpdateFireTime();
        }
    }
    public void GetHit(int damage)
    {
        zombieHealth -= damage;
        if (zombieHealth <= 0)
        {
            Dead();
        }
    }
    void Dead()
    {
        Destroy(gameObject);
    }
}
