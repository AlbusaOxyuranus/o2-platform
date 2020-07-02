using System;

namespace O2Platform.Certificate.API.Data.Core.Data
{
    public interface IEntity
    {
        Guid Id { get; set; }
        long ModifiedDate { get; set; }
        long AddedDate { get; set; }

        void UpdateEntity();
        void CreateEntity();
    }
}