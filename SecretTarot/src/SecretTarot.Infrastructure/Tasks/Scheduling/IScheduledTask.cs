﻿using System.Threading;
using System.Threading.Tasks;

namespace SecretTarot.Infrastructure.Tasks.Scheduling
{
    public interface IScheduledTask
    {
        string Schedule { get; }

        Task ExecuteAsync(CancellationToken cancellationToken);
    }
}
