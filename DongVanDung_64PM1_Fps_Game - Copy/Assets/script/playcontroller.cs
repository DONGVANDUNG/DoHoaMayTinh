using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class playcontroller : MonoBehaviour
{
    private float timer = 3f;
    public int damage = 34;
    public float fireTime = 0.3f;
    private float lastFireTime = 0;
    public GameObject finish;
    public GameObject gameOver;
    public bool active = false;
    //Start is called before the first frame update
    void Start()
    {
        finish.SetActive(false);
        gameOver.SetActive(false);
    }
    void UpdateFireTime()
    {
        lastFireTime = Time.time;
        timer = Time.timeScale;
    }
    void Fire()
    {
        if (Time.time >= lastFireTime + fireTime)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform.tag.Equals("zombie"))
                {
                    hit.transform.gameObject.GetComponent<zombiecontroller>().GetHit(damage);
                }
            }
            UpdateFireTime();
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Fire();
        }
        if (!GameObject.FindGameObjectWithTag("zombie"))
        {
            finish.SetActive(true);
            active = true;
            if (active)
            {
                Invoke("LoadGame", 0.1f);
            }
        }
    }
    void Dead()
    {

    }
    void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "zombie")
        {
            active = true;
            gameOver.SetActive(true);
            if (active)
            {
                Invoke("LoadGame", 0.1f);
            }
        }
    }
    void LoadGame()
    {
        //Time.timeScale = 0;
        System.Threading.Thread.Sleep(4300);
        UnityEngine.SceneManagement.Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
    }

}
