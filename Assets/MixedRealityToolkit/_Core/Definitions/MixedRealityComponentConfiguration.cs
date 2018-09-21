﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.﻿

using Microsoft.MixedReality.Toolkit.Core.Attributes;
using Microsoft.MixedReality.Toolkit.Core.Definitions.Utilities;
using Microsoft.MixedReality.Toolkit.Core.Interfaces;
using System;
using UnityEngine;

namespace Microsoft.MixedReality.Toolkit.Core.Definitions
{
    /// <summary>
    /// Defines a system, feature, or manager to be registered with the <see cref="IMixedRealityManager"/> on startup.
    /// </summary>
    [Serializable]
    public struct MixedRealityComponentConfiguration
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="componentType">The concrete type for the system, feature or manager.</param>
        /// <param name="componentName">The simple, human readable name for the system, feature, or manager.</param>
        /// <param name="priority">The priority this system, feature, or manager will be initialized in.</param>
        /// <param name="runtimePlatform">The runtime platform(s) to run this system, feature, or manager on.</param>
        /// <param name="configurationProfile">The configuration profile for the system, feature, or manager.</param>
        public MixedRealityComponentConfiguration(SystemType componentType, string componentName, uint priority, SupportedPlatforms runtimePlatform, ScriptableObject configurationProfile)
        {
            this.componentType = componentType;
            this.componentName = componentName;
            this.priority = priority;
            this.runtimePlatform = runtimePlatform;
            this.configurationProfile = configurationProfile;
        }

        [SerializeField]
        [Implements(typeof(IMixedRealityComponent), TypeGrouping.ByNamespaceFlat)]
        private SystemType componentType;

        /// <summary>
        /// The concrete type for the system, feature or manager.
        /// </summary>
        public SystemType ComponentType => componentType;

        [SerializeField]
        private string componentName;

        /// <summary>
        /// The simple, human readable name for the system, feature, or manager.
        /// </summary>
        public string ComponentName => componentName;

        [SerializeField]
        private uint priority;

        /// <summary>
        /// The priority this system, feature, or manager will be initialized in.
        /// </summary>
        public uint Priority => priority;

        [EnumFlags]
        [SerializeField]
        private SupportedPlatforms runtimePlatform;

        /// <summary>
        /// The runtime platform(s) to run this system, feature, or manager on.
        /// </summary>
        public SupportedPlatforms RuntimePlatform => runtimePlatform;

        [SerializeField]
        private ScriptableObject configurationProfile;

        /// <summary>
        /// The configuration profile for the system, feature, or manager.
        /// </summary>
        public ScriptableObject ConfigurationProfile => configurationProfile;
    }
}