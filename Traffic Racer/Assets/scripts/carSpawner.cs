using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carSpawner : MonoBehaviour
{
    int car;
    int randomSpawner;
    public float timeScale;
    public GameObject[] cars;
    public GameObject spawner1;
    public GameObject spawner2;
    public GameObject spawner3;

    void Start()
    {
        InvokeRepeating("spawnCars", 1.5f, 0.6f);
    }

    void Update()
    {
        
      //  Time.timeScale = Time.timeScale + timeScale;
      //  Debug.Log(Time.timeScale);
    }
    void spawnCars()
    {
            randomSpawner = Random.Range(1, 3 + 1);

            switch (randomSpawner)
            {
                case 1:
                    car = Random.Range(0, cars.Length);
                    GameObject newCar = Instantiate(cars[car], spawner1.transform.position, Quaternion.identity);
                    break;
                case 2:
                    car = Random.Range(0, cars.Length);
                    GameObject newCar2 = Instantiate(cars[car], spawner2.transform.position, Quaternion.identity);
                    break;
                case 3:
                    car = Random.Range(0, cars.Length);
                    GameObject newCar3 = Instantiate(cars[car], spawner3.transform.position, Quaternion.identity);
                    break;
            }
    }
}
