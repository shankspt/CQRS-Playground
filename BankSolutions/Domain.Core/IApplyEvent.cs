﻿namespace Domain.Core
{
    public interface IApplyEvent<in TEvent>
    {
        void Apply(TEvent e);
    }
}