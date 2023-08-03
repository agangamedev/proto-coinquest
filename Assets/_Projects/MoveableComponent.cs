using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Project.Components
{
    public class MoveableComponent : MonoBehaviour
    {
        private float time;
        private float timesUp = 10;

        private void OnEnable()
        {
            time = 0;
        }

        private void Update()
        {
            time += Time.deltaTime;

            if(time > timesUp)
            {
                gameObject.SetActive(false);
            }
        }

    }
}