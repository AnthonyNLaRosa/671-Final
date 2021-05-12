using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Unity.FPS.Gameplay
{
    public class AmbeinceController : MonoBehaviour
    {
        [FMODUnity.EventRef]
        public string eventPath_Ambience;
        FMOD.Studio.EventInstance ambienceState;

        [SerializeField]
        [Range(0, 2)]
        private float ambience_wind;

        [SerializeField]
        private float ambience_control;

        // Start is called before the first frame update
        void Start()
        {
            ambienceState = FMODUnity.RuntimeManager.CreateInstance(eventPath_Ambience);
            ambience_wind = ambience_control;
        }

        // Update is called once per frame
        private void OnTriggerEnter(Collider other)
        {

        }
    }
}
