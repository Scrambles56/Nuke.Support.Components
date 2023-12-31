﻿// Copyright 2023 Maintainers of NUKE.
// Distributed under the MIT License.
// https://github.com/nuke-build/nuke/blob/master/LICENSE

namespace Scrambles.Nuke.Support.Components;

public static class ToolSettingsExtensions
{
    public static T WhenNotNull<T, TObject>(
        this T settings,
        TObject obj,
        Func<T, TObject, T> configurator)
    {
        return obj != null ? configurator.Invoke(settings, obj) : settings;
    }
}