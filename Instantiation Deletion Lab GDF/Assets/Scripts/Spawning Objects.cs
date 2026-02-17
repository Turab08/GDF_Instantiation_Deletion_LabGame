using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawningObjects : MonoBehaviour
{
    [Header("Prefabs")]
    public GameObject cube;
    public GameObject sphere;

    public Material objectMaterial;

    public void Cube() {
        Spawn(cube);
    }
    public void Sphere() {
        Spawn(sphere);
    }

    void Spawn(GameObject obj)
    {
        objectMaterial.color = new Color(Random.value, Random.value, Random.value);
        obj.GetComponent<Renderer>().material = objectMaterial;
        Instantiate(obj, new Vector3(Random.Range(-3, 3), 3, Random.Range(-3, 3)), Quaternion.identity, gameObject.transform);
    }
}
