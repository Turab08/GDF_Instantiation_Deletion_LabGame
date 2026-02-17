using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawningObjects : MonoBehaviour
{
    [Header("Prefabs")]
    public GameObject cube;
    public GameObject sphere;

    public void Cube() {
        Spawn(cube);
    }
    public void Sphere() {
        Spawn(sphere);
    }

    void Spawn(GameObject obj)
    {
        Instantiate(obj, new Vector3(Random.Range(-3, 3), 3, Random.Range(-3, 3)), Quaternion.identity, gameObject.transform);
    }
}
