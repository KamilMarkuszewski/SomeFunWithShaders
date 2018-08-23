using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets
{
    public class ShaderActivatorScript : MonoBehaviour
    {
        public Material UsedMaterial;

        void Awake()
        {
            _visibility = 1.0f;
            SetVisibility();
        }


        public float StartDelay = 0.0f;
        public float Speed = 0.1f;
        private float _visibility = 1.0f;

        private void SetVisibility()
        {
            UsedMaterial.SetFloat("Vector1_C1A4FAC3", _visibility);
        }

        void MakeVisible()
        {
            if (_visibility > -1.0f)
            {
                _visibility -= 0.1f;

                if (_visibility < -1.0f)
                {
                    _visibility = -1.0f;
                }
            }
            else
            {
                CancelInvoke("MakeVisible");
            }
            SetVisibility();
        }


        // Use this for initialization
        void Start()
        {
            InvokeRepeating("MakeVisible", StartDelay, 0.1f);
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
