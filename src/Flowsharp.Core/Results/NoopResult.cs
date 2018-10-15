﻿using Flowsharp.Models;
using Flowsharp.Services;

namespace Flowsharp.Results
{
    /// <summary>
    /// A result that does nothing.
    /// </summary>
    public class NoopResult : ActivityExecutionResult
    {
        protected override void Execute(IWorkflowInvoker invoker, WorkflowExecutionContext workflowContext)
        {
            // Noop.
        }
    }
}