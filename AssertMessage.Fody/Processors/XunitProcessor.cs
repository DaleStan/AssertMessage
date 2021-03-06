﻿using Mono.Cecil;

public class XunitProcessor : ProcessorBase
{
    public override bool IsValidForModule(ModuleDefinition module)
    {
        return IsReferenced(module, "xunit.assert");
    }

    protected override bool IsThisFramework(MethodReference methodReference)
    {
        return IsTypeFrom(methodReference, "Xunit.");
    }
}