using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveToPlayer : MonoBehaviour
{
    public float moveSpeed;
    public float minMoveSpeed = 0.5f;
    public float maxMoveSpeed = 5f;

    GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        UpdateMoveSpeed();
    }
    void Move()
    {
        if (player == null) return;
        transform.LookAt(player.transform.position);
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
    }
    // Update is called once per frame
    void Update()
    {
        Move();
    }
    void UpdateMoveSpeed()
    {
        moveSpeed = Random.Range(minMoveSpeed, maxMoveSpeed);
    }
}
