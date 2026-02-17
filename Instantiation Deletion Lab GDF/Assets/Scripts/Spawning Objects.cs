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

    public void Clear()
    {
        foreach (Transform child in transform)
        {
            Destroy(child.gameObject);
        }
    }

    void Spawn(GameObject obj)
    {
        GameObject newObject = Instantiate(obj, new Vector3(Random.Range(-3, 3), 3, Random.Range(-3, 3)), Quaternion.identity, gameObject.transform);

        Color color = new Color(Random.value, Random.value, Random.value);
        Renderer renderer = newObject.GetComponent<Renderer>();
        renderer.material.color = color;
    }
}
