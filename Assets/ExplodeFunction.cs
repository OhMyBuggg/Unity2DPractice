﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplodeFunction : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void AnimationEnd() {
      Destroy(gameObject);
    }
}
