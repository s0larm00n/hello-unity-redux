﻿using UnityEngine;

public class IncrementABController : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        Store.Instance.storeDispatch.OnNext(AB.Instance.IncrementAB());
    }
}