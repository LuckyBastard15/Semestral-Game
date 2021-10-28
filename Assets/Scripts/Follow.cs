using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Follow : MonoBehaviour
{
    /*public Transform target;
    public float speed = 0;
    private float TimeKiller = 0;
    private float Timetomove = 0;
    private float distancia;
    public GameObject enemigo;
    public GameObject Bomba1;
    public GameObject Bomba2;
    public GameObject Bomba3;
    public GameObject Bomba4;
    public GameObject Bomba5;*/
    Rigidbody2D rb;
    GameObject target;
    public Transform Nave;
    float movespeed;
    Vector3 directionToTarger;
    public GameObject explosion;
    




    // Start is called before the first frame update
    void Start()
    {
        // target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        target = GameObject.Find("AlienSpaceship");
        rb = GetComponent<Rigidbody2D>();
        movespeed = Random.Range(1f, 3f);

    }

    void Update()
    {
        MoveBullet();
    }

    void MoveBullet()
    {
        if(target != null)
        {
            directionToTarger = (target.transform.position - transform.position).normalized;
            rb.velocity = new Vector2(directionToTarger.x * movespeed, directionToTarger.y * movespeed);
            
            Vector3 direction = Nave.position - transform.position;
            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.AngleAxis(angle + 180, Vector3.forward);
        }
        else
        {
            rb.velocity = Vector3.zero;
        }
    }



    // Update is called once per frame
    /*void Update()
    {

        TimeKiller += Time.deltaTime;
        Timetomove += Time.deltaTime;


        //target.position = angle;
        //transform.rotation = Quaternion.AngleAxis(30,Vector3.forward);

        //if (enemigo.activeInHierarchy == false) { SceneManager.LoadScene(sceneName: "Finish"); }

        Vector3 direction = target.position - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle + 180, Vector3.forward);




        if (Timetomove >= 1) { Bomba1.transform.position = Vector2.MoveTowards(Bomba1.transform.position, target.position, speed * Time.deltaTime); }
        distancia = Vector3.Distance(target.transform.position, transform.position);
        if (TimeKiller >= 6) { Bomba1.SetActive(false); }
        if (distancia <= 0.5) { enemigo.SetActive(false); }



        if (Timetomove >= 3) { Bomba2.transform.position = Vector2.MoveTowards(Bomba2.transform.position, target.position, speed * Time.deltaTime); }
        distancia = Vector3.Distance(target.transform.position, transform.position);
        if (TimeKiller >= 8) { Bomba2.SetActive(false); }
        if (distancia <= 0.5) { enemigo.SetActive(false); }


        if (Timetomove >= 5) { Bomba3.transform.position = Vector2.MoveTowards(Bomba3.transform.position, target.position, speed * Time.deltaTime); }
        distancia = Vector3.Distance(target.transform.position, transform.position);
        if (TimeKiller >= 10) { Bomba3.SetActive(false); }
        if (distancia <= 0.5) { enemigo.SetActive(false); }


        if (Timetomove >= 7) { Bomba4.transform.position = Vector2.MoveTowards(Bomba4.transform.position, target.position, speed * Time.deltaTime); }
        distancia = Vector3.Distance(target.transform.position, transform.position);
        if (TimeKiller >= 12) { Bomba4.SetActive(false); }
        if (distancia <= 0.5) { enemigo.SetActive(false); }


        if (Timetomove >= 9) { Bomba5.transform.position = Vector2.MoveTowards(Bomba5.transform.position, target.position, speed * Time.deltaTime); }
        distancia = Vector3.Distance(target.transform.position, transform.position);
        if (TimeKiller >= 14) { Bomba5.SetActive(false); }
        if (distancia <= 0.5) { enemigo.SetActive(false); }
}*/
}
