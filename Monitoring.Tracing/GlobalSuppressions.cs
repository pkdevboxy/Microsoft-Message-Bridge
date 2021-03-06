// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GlobalSuppressions.cs" company="Microsoft Corporation">
//   Copyright 2015 Microsoft Corporation. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.MSInternal", 
        "CA904:DeclareTypesInMicrosoftOrSystemNamespace", Scope = "namespace", 
        Target = "Microsoft.MessageBridge.Monitoring.Tracing", Justification = "The correct namespace is Microsoft.")]
[assembly:
    System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1506:AvoidExcessiveClassCoupling", 
        Scope = "member", Target = "Microsoft.MessageBridge.Monitoring.Tracing.TraceActivityListener.#Initialize()", 
        Justification = "This pattern is by design.")]