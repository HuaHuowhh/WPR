using System;

namespace Projektanker.Icons.Avalonia
{
    public class AppBuilderBase<TAppBuilder> where TAppBuilder : AppBuilderBase<TAppBuilder>, new()
    {
        internal void With<T>(IconProvider iconProvider)
        {
            throw new NotImplementedException();
        }
    }
}