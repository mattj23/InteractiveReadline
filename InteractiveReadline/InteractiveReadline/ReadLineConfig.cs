﻿using System;
using System.Collections.Generic;
using System.Text;
using InteractiveReadLine.Behaviors;
using InteractiveReadLine.Components;

namespace InteractiveReadLine
{
    public class ReadLineConfig
    {

        public ReadLineConfig()
        {
            this.KeyBehaviors = new Dictionary<KeyId, Action<IKeyBehaviorTarget>>();
        }

        public bool IsTesting { get; set; }

        public Dictionary<KeyId, Action<IKeyBehaviorTarget>> KeyBehaviors { get; }


        public static ReadLineConfig Test() => new ReadLineConfig() {IsTesting = true};

        public static ReadLineConfig Empty() => new ReadLineConfig();

    }
}