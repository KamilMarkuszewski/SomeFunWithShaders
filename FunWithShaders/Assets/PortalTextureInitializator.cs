using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets
{
    public class PortalTextureInitializator : MonoBehaviour
    {

        public Camera Camera1;
        public Material CameraMat1;

        public Camera Camera2;
        public Material CameraMat2;

        // Use this for initialization
        void Start()
        {
            if (Camera2.targetTexture != null)
            {
                Camera2.targetTexture.Release();
            }

            Camera2.targetTexture= new RenderTexture(Screen.width, Screen.height, 24);
            CameraMat2.mainTexture = Camera2.targetTexture;

            if (Camera1.targetTexture != null)
            {
                Camera1.targetTexture.Release();
            }

            Camera1.targetTexture = new RenderTexture(Screen.width, Screen.height, 24);
            CameraMat1.mainTexture = Camera1.targetTexture;
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
