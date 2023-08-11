using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 10f;
    private Transform target;
    private int WaveIndex = 0;

    // Start is called before the first frame update
    void Start()
    {
        target = DirectionalPoints.points[0];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
