using UnityEngine;
using UnityEngine.VR;

namespace VRStandardAssets.Examples
{
    // This script shows how renderscale affects the visuals
    // and performance of a scene.
    public class ExampleRenderScale : MonoBehaviour
    {
        [SerializeField] private float m_RenderScale = 1.5f;              //The render scale. Higher numbers = better quality, but trades performance


        [SerializeField] private float eyeTextureResolutionScale = 0.0f;      //Defined the variable to keep from erroring


        void Start ()
        {
           // UnityEngine.VR.VRSettings.eyeTextureResolutionScale = m_RenderScale;
	    }
    }
}