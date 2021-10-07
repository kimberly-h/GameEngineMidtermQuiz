using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;

public class SaltSpawn : MonoBehaviour
{
    [DllImport("Quiz Code Midterm")]
    private static extern int RandomInt(int min, int max);
    private float time = 0f;
    public Rigidbody rb;
    public Transform playerPos;

    int spawnPerPos = 3;

 

    // Update is called once per frame
    void Update()
    {
        if (time > 0.5)
        {
            Instantiate(rb, new Vector3(RandomInt(29, 48), playerPos.position.y + 10, playerPos.position.z + 5), Quaternion.identity);
            time = 0;
        }

        time += Time.deltaTime;
    }
}
