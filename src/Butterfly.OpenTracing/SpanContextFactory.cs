﻿using System;

namespace Butterfly.OpenTracing
{
    public class SpanContextFactory : ISpanContextFactory
    {
        public ISpanContext Create(SpanContextPackage spanContextPackage)
        {
            return new SpanContext(
                spanContextPackage.TraceId ?? Guid.NewGuid().ToString(),
                spanContextPackage.SpanId ?? Guid.NewGuid().ToString(),
                spanContextPackage.Sampled,
                spanContextPackage.Baggage ?? new Baggage(),
                spanContextPackage.References);
        }
    }
}