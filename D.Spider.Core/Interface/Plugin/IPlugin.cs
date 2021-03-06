﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D.Spider.Core.Interface
{
    /// <summary>
    /// 插件，一切都是插件
    /// </summary>
    public interface IPlugin : IRunningable<IPlugin>
    {
        /// <summary>
        /// 插件（实例）的唯一标志
        /// </summary>
        IPluginSymbol Symbol { get; }

        /// <summary>
        /// 状态
        /// </summary>
        PluginState State { get; }
    }
}
