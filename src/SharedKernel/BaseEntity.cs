using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SharedKernel
{
    public abstract class BaseEntity
    {
        public BaseEntity()
        {
            Id = Guid.NewGuid();
            Created = DateTimeOffset.UtcNow;
        }
        public Guid Id { get; private set; }
        
        public DateTimeOffset Created { get; set; } = DateTimeOffset.Now;
        public string Creator { get; set; }
        //To do: consider adding concurrency token https://www.npgsql.org/efcore/modeling/concurrency.html
        public DateTimeOffset Updated { get; set; } = DateTimeOffset.Now;
        public string Updater { get; set; }
    }
}
