﻿namespace Netch.Controllers
{
    public interface IController
    {
        /// <summary>
        ///     控制器名
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        ///     停止
        /// </summary>
        public abstract void Stop();
    }
}