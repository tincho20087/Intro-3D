﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClonaCybos : MonoBehaviour
{
    public GameObject cuboPrefab;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ClonarCubo()
    {
        Instantiate(cuboPrefab);
    }
}
