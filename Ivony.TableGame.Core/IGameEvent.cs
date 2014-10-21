﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ivony.TableGame
{

  /// <summary>
  /// 定义游戏中出现的事件抽象
  /// </summary>
  public interface IGameEvent
  {

    /// <summary>
    /// 事件数据容器
    /// </summary>
    IDictionary<string, object> Data { get; }

  }
}
