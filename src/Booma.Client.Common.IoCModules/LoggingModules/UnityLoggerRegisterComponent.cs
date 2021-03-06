﻿using Booma.Client.Logging;
using Common.Logging;
using SceneJect.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Booma.Client.Common.IoCModules
{
	/// <summary>
	/// Registeration component for <see cref="UnityLoggingService"/>
	/// </summary>
	public class UnityLoggerRegisterComponent : NonBehaviourDependency
	{
		public override void Register(IServiceRegister register)
		{
			//Just register the service. Let users define the flags.
			//Single instance is preferable though.
			register.Register<UnityLoggingService>(getFlags(), typeof(ILog));
		}
	}
}
