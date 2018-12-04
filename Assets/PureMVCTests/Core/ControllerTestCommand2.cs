﻿//
//  PureMVC C# Multicore
//
//  Copyright(c) 2017 Saad Shams <saad.shams@puremvc.org>
//  Your reuse is governed by the Creative Commons Attribution 3.0 License
//

using PureMVC.Interfaces;
using PureMVC.Patterns.Command;

namespace PureMVC.Core
{
    /// <summary>
    /// A SimpleCommand subclass used by ControllerTest.
    /// </summary>
    /// <seealso cref="ControllerTest"/>
    /// <seealso cref="ControllerTestVO"/>
    ///具体命令2，结果为上次结果加上本次输入的两倍
    public class ControllerTestCommand2: SimpleCommand
    {
        /// <summary>
        /// Fabricate a result by multiplying the input by 2 and adding to the existing result
        ///     <para>
        ///         This tests accumulation effect that would show if the command were executed more than once.
        ///     </para>
        /// </summary>
        /// <param name="notification">the note carrying the ControllerTestVO</param>
        public override void Execute(INotification notification)
        {
            ControllerTestVO vo = (ControllerTestVO)notification.Body;

            // Fabricate a result
            vo.result = vo.result + (2 * vo.input);
        }

    }
}