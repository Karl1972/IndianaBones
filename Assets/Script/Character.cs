﻿using UnityEngine;
using System.Collections;

namespace IndianaBones
{
    public abstract class Character : MonoBehaviour
    {
        protected int lifePoints;
        
        public int xPosition;
        public int yPosition;
        public int xOld;
        public int yOld;
        public int movimento = 1;

        void Awake()
        {
            
            
            SetupStats();
        }

       
        protected abstract void SetupStats();

    }
}
