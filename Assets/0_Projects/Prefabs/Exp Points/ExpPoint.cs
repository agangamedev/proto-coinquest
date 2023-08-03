using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExpPoint : MonoBehaviour
{
    [SerializeField] private int point = 2;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            //other.SendMessage("GainExp", point);
            MyCoin.instances.AddCoin(point);
            Destroy(this.gameObject);
        }
    }
}
