using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoDevMonoBehaviour : MonoBehaviour
{
    protected virtual void LoadComponents()
    {}

    protected virtual void Awake()
    {
        this.LoadComponents();  
    }

    protected virtual void Reset()
    {
        this.LoadComponents();
    }

    protected virtual void FixedUpdate()
    {}

    protected virtual void Update()
    {}

    protected virtual void Start()
    {}

    protected virtual void OnEnable()
    {}

}
