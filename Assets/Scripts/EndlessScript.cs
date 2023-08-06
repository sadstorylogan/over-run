using System.Collections.Generic;
using UnityEngine;

public class EndlessScript : MonoBehaviour
{
    public GameObject[] platforms;
    [SerializeField] private GameObject player;

    public List<GameObject> createdTiles;


    Vector3 pos = new(0, 0, 0);

    void Start()
    {


        float waitTime = 2f;
        InvokeRepeating("CreatePlatform", 0, waitTime);

    }

    private void CreatePlatform()
    {

        int platformNumber = Random.Range(0, platforms.Length);
        GameObject PlatformCreator = Instantiate(platforms[platformNumber], pos, Quaternion.identity) as GameObject;
        pos.z += 100f;

    }
}

 