﻿namespace Pirina.Kernel.Adaptor
{
    public interface IAdaptor<in TAdaptee, out TTarget>
    {
        TTarget Adapt(TAdaptee adaptee);
    }
}
