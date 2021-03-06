﻿#if UNENG
namespace UnEngine
#else
namespace UnityEngine
#endif
{
    /// <summary>
    /// 
    /// </summary>
    public sealed class Time
    {
		public static float realtimeSinceStartup { get { return time; } }

        /// <summary>
        /// 
        /// </summary>
        public static float deltaTime { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public static float time { get; private set; }

        internal static void Update(float newTime)
        {
            deltaTime = newTime - time;
            time = newTime;
        }
    }
}