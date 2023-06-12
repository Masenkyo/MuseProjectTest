using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.HighDefinition;

public class PlayerVignette : MonoBehaviour
{
    public float VignetteMaxValue;
    Vignette vignette;
    public VolumeProfile volumeProfile;

    // Update is called once per frame
    void Update()
    {
        volumeProfile.TryGet<Vignette>(out vignette);
        vignette.intensity.value = VignetteMaxValue;
    }
}
