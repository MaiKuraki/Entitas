﻿//HintName: SomeContext.g.cs
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by
//     Entitas.Generators.ContextGenerator
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

public sealed partial class SomeContext : Entitas.Context<SomeEntity>
{
    public SomeContext()
        : base(
            0,
            0,
            new Entitas.ContextInfo(
                "Some",
                null,
                null
            ),
            entity =>
#if (ENTITAS_FAST_AND_UNSAFE)
                new Entitas.UnsafeAERC(),
#else
                new Entitas.SafeAERC(entity),
#endif
            () => new SomeEntity()
        ) { }
}