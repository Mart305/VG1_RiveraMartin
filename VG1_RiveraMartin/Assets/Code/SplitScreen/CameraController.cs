using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using UnityEngine;

namespace SplitScreen { 
    public class CameraController : MonoBehaviour
    {
        public Transform target;
        public Vector3 offset;
        public float smoothness;
        Vector3 _velocity;

        void Start()
        {
            if (target)
            {
                offset = transform.position - target.position;
            }
        }

        void FixedUpdate()
        {
            if (target)
            {
                transform.position = Vector3.SmoothDamp(
                    transform.position,
                    target.position + offset,
                    ref _velocity,
                    smoothness
                );
            }
        }
    }
}
