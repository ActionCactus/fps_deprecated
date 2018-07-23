using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using ActionCactus.Controllers.StateMachines;
using ActionCactus.Framework.Exceptions;

namespace ActionCactus.Controllers.Cameras
{
    public class FirstPersonCamera : MonoBehaviour
    {
        private PlayerCharacter pcStateMachine;
        public string test;
        private string test32;

        // Use this for initialization
        void Start()
        {
            this.pcStateMachine = GetComponent<PlayerCharacter>();

            if (this.pcStateMachine == null)
            {
                throw new InternalConfigurationException("Player character not initialized with PlaterCharacter state machine!");
            }
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}