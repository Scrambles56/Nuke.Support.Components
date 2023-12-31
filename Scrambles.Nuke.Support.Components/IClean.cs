﻿using Nuke.Common;
using Nuke.Common.Tools.DotNet;
using Scrambles.Nuke.Support.Components.Have;

namespace Scrambles.Nuke.Support.Components;

public interface IClean : IHaveSolution, IHaveConfiguration
{
    Target Clean => _ => _
        .Executes(() =>
        {
            DotNetTasks.DotNetClean(_ => _
                .SetProject(Solution)
                .SetConfiguration(Configuration)
            );
        });
}